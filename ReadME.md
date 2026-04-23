# Dentist Management System

Desktop dental clinic management application built with **C# Windows Forms** and **SQL Server**. The solution is organized with a layered architecture that separates the user interface, business logic, data access, and data transfer objects.

## Overview

This project helps manage the daily operations of a dental clinic, including patients, dentists, appointments, treatments, medical records, allergies, invoices, payments, and login access.

## Features

- Patient registration and profile management
- Dentist registration and profile management
- Appointment scheduling
- Treatment management
- Medical record management
- Allergy tracking
- Mutuelle/insurance information management
- Invoice and payment management
- User login and authentication
- Patient image management
- Dashboard interface
- SQL Server data storage

## Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms
- SQL Server
- ADO.NET
- Guna UI2 WinForms
- Visual Studio

## Solution Structure

```text
DentistSolution/
|-- BL_Framwork/          # Business logic layer
|-- DAL_Framwork/         # Data access layer and SQL Server communication
|-- DTO_Framwork/         # Data Transfer Objects used between layers
|-- ProjectDentiste/      # Windows Forms presentation layer
|-- DataBase/             # Database-related files
|-- ScreenShots/          # Project screenshots
|-- packages/             # NuGet packages
|-- DentistSolution.sln   # Visual Studio solution
|-- .gitignore
`-- ReadME.md
```

## Main Modules

### Presentation Layer

The `ProjectDentiste` project contains the Windows Forms screens and user controls.

Main areas include:

- `Patients`
- `Dentists`
- `Appointments`
- `Treatments`
- `MedicalRecord`
- `Payment`
- `Mutuelle`
- `Allergies`
- `Login`
- `MainForm`

### Business Layer

The `BL_Framwork` project contains the business logic of the application.

Examples:

- `PatientBL`
- `DentistBL`
- `AppointmentBL`
- `TreatmentBL`
- `MedicalRecordBL`
- `InvoiceBL`
- `LoginBL`

### Data Access Layer

The `DAL_Framwork` project manages database communication using SQL Server and ADO.NET.

Examples:

- `PatientsDAL`
- `DentistDAL`
- `AppointmentDAL`
- `TreatmentDAL`
- `MedicalRecordDAL`
- `InvoiceDAL`
- `LoginDAL`

### DTO Layer

The `DTO_Framwork` project contains Data Transfer Objects used to move data between the presentation, business, and data access layers.

## Requirements

Before running the project, install:

- Visual Studio
- .NET Framework 4.7.2
- SQL Server
- NuGet package restore support

## Database Configuration

The application uses a SQL Server database named:

```text
DentisteDB
```

The current connection string is defined in the DAL classes, for example:

```text
server=.;database=DentisteDB;Integrated Security=True;
```

If your SQL Server configuration is different, update the connection string locally. Avoid committing real usernames or passwords to GitHub.

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/SoumBoul/DentistSolution.git
```

2. Open the solution in Visual Studio:

```text
DentistSolution.sln
```

3. Restore NuGet packages if Visual Studio does not restore them automatically.

4. Create or restore the SQL Server database `DentisteDB`.

5. Update the SQL Server connection string if needed.

6. Build and run the application.

## Screenshot

A database screenshot is available in:

```text
ScreenShots/Database.png
```

## Author

Developed by SoumBoul.

