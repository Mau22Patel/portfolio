CREATE TABLE [Students]
(
    [StudentID] INT PRIMARY KEY IDENTITY(1,1), 
    [StudentName] NVARCHAR(50),  
    [DateEnrolled] NVARCHAR(50)
);


INSERT INTO [Students] ([StudentName], [DateEnrolled])
VALUES 
('John Smith', '2024-02-15'),
('Alice Nguyen', '2024-03-01'),
('Liam Patel', '2024-04-10'),
('Sophia Chen', '2024-05-05');

CREATE TABLE [Courses]
(
    [CourseID] INT PRIMARY KEY IDENTITY(1,1), 
    [CourseName] NVARCHAR(50),  
    [Cost] DECIMAL(10, 2)
);



INSERT INTO Courses (CourseName, Cost)
VALUES 
('Introduction to Programming', 250.00),
('Database Fundamentals', 300.00),
('Web Development Basics', 275.50);

CREATE TABLE Enrolments (
    EnrollmentID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    Grade VARCHAR(5),

    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
