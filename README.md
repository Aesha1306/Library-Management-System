📚 Library Management System (VB.NET + SQL Server)
📖 Overview

The Library Management System is a Windows-based application built using VB.NET and SQL Server to streamline library operations.
It enables librarians to manage books, members, and transactions (issue/return), while providing students and staff with a simple interface to search and borrow books.

🚀 Features

✅ User Authentication (Admin / Librarian login)

✅ Book Management (Add, Update, Delete, Search books)

✅ Member Management (Add, Update, Delete library members)

✅ Transaction Handling (Issue books, Return books, Check due dates)

✅ Fine Calculation for late returns

✅ Search & Filter for quick access to books and members

✅ Database Integration with SQL Server

🛠️ Tech Stack

Frontend: VB.NET (Windows Forms)

Backend: SQL Server

Language: Visual Basic .NET

IDE: Visual Studio

📂 Project Structure
Library-Management-System/
│── /Forms                # Windows Forms (UI)
│── /Database             # SQL Server scripts (Tables, Stored Procedures)
│── /Modules              # Business logic and helper modules
│── /bin/Debug            # Compiled files
│── README.md             # Project documentation

⚙️ Installation & Setup

Clone the repository

git clone https://github.com/your-username/Library-Management-System.git


Open project in Visual Studio

Go to File > Open > Project/Solution

Select the .sln file

Setup SQL Server Database

Open Database/LibraryDB.sql

Run the script in SQL Server Management Studio (SSMS)

Update Connection String

In your VB.NET project, open App.config or the database connection module

Replace with your SQL Server credentials

<connectionStrings>
   <add name="LibraryDB"
        connectionString="Data Source=YOUR_SERVER;Initial Catalog=LibraryDB;Integrated Security=True;" 
        providerName="System.Data.SqlClient" />
</connectionStrings>


Run the project

Press F5 in Visual Studio to launch the system

🎯 Usage

Admin Login → Manage users, books, and members

Librarian Login → Issue & return books, track transactions

Students/Staff → Search and request books

📸 Screenshots (Optional)

(Add screenshots of your app’s UI here once available)

🤝 Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you’d like to change.

📜 License

This project is licensed under the MIT License – feel free to use and modify it.
