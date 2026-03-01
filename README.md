# School-Management-System
School Management System is a desktop application built with C# (Windows Forms) and MS SQL Server to efficiently manage students, teachers, classes, subjects, and fees. It features interactive dashboards, search, filtering, fee tracking, teacher assignments, and a clean, user-friendly Three-Tier Architecture.


# School Management System

A professional **School Management System** designed to manage students, teachers, classes, subjects, and fees efficiently. Built using **C# (Windows Forms)** for a modern, interactive interface and **Microsoft SQL Server** for a robust backend, this system demonstrates clean **Three-Tier Architecture** with Presentation, Business Logic, and Data Layers.

---

## Features

- **Student Management:** Add, update, delete, and view student records with personal details, roll number, contact, class, and photo.  
- **Teacher Management:** Manage teacher profiles including subject and class assignments.  
- **Class & Subject Management:** Create, update, and assign classes and subjects.  
- **Teacher Assignments:** Link teachers with specific classes and subjects maintaining relational integrity.  
- **Fee Management:** Record monthly fees, track status (Paid/Unpaid), payment method, and notes.  
- **Search & Filter:** Quickly search students and teachers by name, CNIC, or class.  
- **Beautiful UI:** Interactive forms, DataGridViews, ComboBoxes, PictureBoxes, color themes, and icons.  
- **Reports:** Generate student, teacher, and fee reports directly from the UI.  

---

## Database Tables

1. **Class** – Stores class names.  
2. **Students** – Stores student details including ClassID as foreign key.  
3. **Teachers** – Stores teacher information.  
4. **Subjects** – Stores subjects taught in the school.  
5. **TeacherAssignments** – Maps teachers to subjects and classes.  
6. **Fee** – Tracks fee payments, status, payment method, and notes.

---

## Technology Stack

- **Language:** C# (Windows Forms)  
- **Database:** Microsoft SQL Server  
- **Architecture:** Three-Tier (Presentation, Business Logic, Data Layer)  
- **Tools:** SQL Server Management Studio (SSMS), Visual Studio  

---

## Installation & Usage

Open SQL Server Management Studio (SSMS).

Create a new database, e.g., SchoolDB.

All required SQL tables and queries are already included in the project.

The complete database schema (CREATE TABLE scripts)

Sample data insertion queries

Stored procedures and necessary SQL queries used in the application

Run the provided SQL script file in SSMS to automatically create all tables and relationships.

Open the solution in Visual Studio.

Update the connection string in the application:

Data Source=YourServerName;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=False;

Build and run the project.
