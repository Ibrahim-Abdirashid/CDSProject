# 🚗 CADCAD Driving School - Student Management System

This project is a comprehensive management solution for handling students, lecturers, and all administrative processes within the CADCAD Driving School. It is a **Desktop Application** developed with **C# .NET Windows Forms**, adhering to the **Model-View-Controller (MVC)** architecture.

## 🛠️ Technologies Used

* **Language:** C#
* **Platform:** .NET Framework / .NET Core (Windows Forms Application)
* **Database:** **[INSERT YOUR DATABASE HERE (e.g., SQL Server, MySQL)]**
* **Architecture:** Model-View-Controller (MVC)

## ✨ Core Features

The system simplifies the management of:

* **Student Management:** Enrollment, modification, and searching of student records.
* **Lecturer Management:** Registration and administration of lecturer information.
* **Level Management:** Creation and maintenance of driving levels (e.g., Level A, B, etc.).
* **Fee Payment:** Recording of payments and tracking of student payment status.
* **Account System:** Secure login mechanism and management of user accounts (`AddAccount`).

## 🗄️ Project Structure (MVC Pattern)

The project is logically divided into three major components to maintain code cleanliness and separation of duties:

### 1. Models (Data and Business Logic)
These classes represent the application's data and business rules.
* `Student.cs`, `Lecturer.cs`, `Level.cs`, `FeePayment.cs`, `Accounts.cs`

### 2. Views / Forms (User Interface)
These are the visual windows (Forms) through which users interact with the system.
* `Student.cs`, `Lecturer.cs`, `Level.cs`, `Payment.cs`, `Login.cs`, `AddAccount.cs`

### 3. Controller (Glue between Models and Views)
These classes handle user input, interact with the Models (often involving the database), and select the appropriate View.
* `Database.cs`
* `StudentController.cs`, `LecturerController.cs`, `LevelController.cs`, `PaymentController.cs`, `AccountsController.cs`

## ⚙️ Getting Started

1.  **Clone the Repository:**
    ```bash
    git clone [Your GitHub URL]
    ```
2.  **Open in Visual Studio 2022:**
    * Launch `CDSProject.sln` using Visual Studio.
3.  **Database Configuration:**
    * Adjust the database connection settings (`Connection String`) within the `Database.cs` file or its equivalent.
4.  **Run:**
    * Press **Start** (or F5) to run and test the application.
