using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private readonly WeatherApiService _svc = new WeatherApiService();
        private readonly HttpClient _imgHttp = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            // Press Enter in the city box to search
            txtCity.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnSearch.PerformClick(); };
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var q = txtCity.Text.Trim();
            if (string.IsNullOrWhiteSpace(q))
            {
                MessageBox.Show("Enter a city (e.g., Adelaide)", "City required");
                txtCity.Focus();
                return;
            }

            btnSearch.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var data = await _svc.GetByCityAsync(q);
                await RenderAsync(data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show(this, ex.Message, "Weather error");
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSearch.Enabled = true;
            }
        }

        private async Task RenderAsync(WaForecastRoot r)
        {
            // Main readings (metric)
            lblTemp.Text = $"{r.Current.TempC:0.#} °C";
            lblWind.Text = $"{r.Current.WindKph:0.#} kph";
            lblPressure.Text = $"{r.Current.PressureMb:0.#} mb";

            // Sunrise / Sunset (today)
            if (r.Forecast?.Days != null && r.Forecast.Days.Length > 0)
            {
                lblSunrise.Text = r.Forecast.Days[0].Astro.Sunrise ?? "-";
                lblSunset.Text = r.Forecast.Days[0].Astro.Sunset ?? "-";
            }
            else
            {
                lblSunrise.Text = lblSunset.Text = "-";
            }

            // Icon
            try
            {
                var iconUri = WeatherApiService.NormalizeIconUri(r.Current.Condition?.Icon);
                using (var s = await _imgHttp.GetStreamAsync(iconUri))
                {
                    picIcon.Image = Image.FromStream(s);
                }
            }
            catch
            {
            }
        }
    }
}