

CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    FatherName NVARCHAR(100) NOT NULL,
    RollNumber NVARCHAR(50) NOT NULL,
    Contact NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    DOB DATE NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    ImagePath NVARCHAR(255) NULL,
    ClassID INT,  -- Foreign key to the Class table
    CONSTRAINT FK_Students_Class FOREIGN KEY (ClassID) REFERENCES Class(ClassID)
);
CREATE TABLE Class (
    ClassID INT IDENTITY(1,1) PRIMARY KEY,
    ClassName NVARCHAR(50) NOT NULL
);
select * from Teachers

CREATE TABLE Teachers (
    TeacherID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    FatherName NVARCHAR(100) NULL,
    Gender NVARCHAR(10) NOT NULL,
    DOB DATE NOT NULL,
    Contact NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Cnic NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    ImagePath NVARCHAR(255) NULL
);
CREATE TABLE Subjects (
    SubjectID INT IDENTITY(1,1) PRIMARY KEY,
    SubjectName NVARCHAR(100) NOT NULL
);
CREATE TABLE TeacherAssignments (
    AssignmentID INT IDENTITY(1,1) PRIMARY KEY,
    TeacherID INT,  -- Foreign key to Teachers table
    SubjectID INT,  -- Foreign key to Subjects table
    ClassID INT,    -- Foreign key to Class table
    CONSTRAINT FK_TeacherAssignments_Teacher FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID),
    CONSTRAINT FK_TeacherAssignments_Subject FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
    CONSTRAINT FK_TeacherAssignments_Class FOREIGN KEY (ClassID) REFERENCES Class(ClassID)
);
CREATE TABLE Fee (
    FeeID INT PRIMARY KEY IDENTITY,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    Month NVARCHAR(20),
    Amount DECIMAL(10,2),
    Status NVARCHAR(10), -- Paid / Unpaid
    PaymentDate DATE,
    PaymentMethod NVARCHAR(20),
    Notes NVARCHAR(255)
);
CREATE TABLE Teachers (
    TeacherID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    FatherName NVARCHAR(100) NULL,
    Gender NVARCHAR(10) NOT NULL,
    DOB DATE NOT NULL,
    Contact NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Cnic NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    ImagePath NVARCHAR(255) NULL
);

drop table Teachers

INSERT INTO Students (Name, FatherName, RollNumber, Contact, Email, Gender, DOB, Address, ImagePath, ClassID)
VALUES
('Ahmed Ali', 'Farooq Ali', 'A001', '0300-1234567', 'ahmed.ali@email.com', 'Male', '2005-08-15', '123 Block A, Lahore', NULL, 1),
('Fatima Khan', 'Shahbaz Khan', 'A002', '0301-7654321', 'fatima.khan@email.com', 'Female', '2006-09-20', '456 Block B, Karachi', NULL, 2),
('Sara Shah', 'Zahid Shah', 'A003', '0312-2345678', 'sara.shah@email.com', 'Female', '2007-03-12', '789 Block C, Islamabad', NULL, 1),
('Ali Hassan', 'Jamil Hassan', 'A004', '0321-3456789', 'ali.hassan@email.com', 'Male', '2005-06-10', '321 Block D, Peshawar', NULL, 2),
('Ayesha Raza', 'Faisal Raza', 'A005', '0333-4567890', 'ayesha.raza@email.com', 'Female', '2006-12-25', '654 Block E, Quetta', NULL, 3),
('Usman Tariq', 'Muhammad Tariq', 'A006', '0344-5678901', 'usman.tariq@email.com', 'Male', '2007-05-30', '987 Block F, Multan', NULL, 3),
('Mariam Iqbal', 'Imran Iqbal', 'A007', '0355-6789012', 'mariam.iqbal@email.com', 'Female', '2005-02-08', '135 Block G, Faisalabad', NULL, 1),
('Omar Rehman', 'Arif Rehman', 'A008', '0366-7890123', 'omar.rehman@email.com', 'Male', '2006-11-14', '246 Block H, Sargodha', NULL, 2),
('Zainab Malik', 'Asim Malik', 'A009', '0377-8901234', 'zainab.malik@email.com', 'Female', '2007-07-21', '369 Block I, Rawalpindi', NULL, 3),
('Bilal Ahmed', 'Salman Ahmed', 'A010', '0388-9012345', 'bilal.ahmed@email.com', 'Male', '2005-01-05', '481 Block J, Gujranwala', NULL, 1);


 


