# Dentist Management System

Desktop application developed with **C# WinForms** and **SQL Server** for managing a dental clinic.  
The project demonstrates a **3-tier architecture** separating the user interface, business logic, and data access.

---

## Features

- Add a new patient
- Update patient information
- Display patients in a DataGridView
- Manage personal information
- Upload and display patient images
- Use stored procedures for database operations

---

## Technologies

- C#
- .NET Framework
- WinForms
- SQL Server
- ADO.NET
- Stored Procedures
- Visual Studio

---

## Project Architecture

The application follows a **3-tier architecture**.

### Presentation Layer (UI)
WinForms interface responsible for user interaction.

Examples:

- `frmAddUpdatePatient`
- `frmPatientList`
- `ctrlPersonInfo`

Responsibilities:
- Display data
- Handle user actions
- Communicate with the Business Layer

---

### Business Layer (BL)

Contains the **business logic** of the application.

Responsibilities:

- Validate data
- Apply business rules
- Communicate with the Data Access Layer

---

### Data Access Layer (DAL)

Responsible for **database communication**.

Uses:

- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`
- Stored Procedures

---

### DTO Layer

DTO (Data Transfer Objects) are used to transfer data between layers.

Examples:

- `PersonDTO`
- `PatientDTO`

---