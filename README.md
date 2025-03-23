# 🎓 EduPlatform

EduPlatform is a simple yet powerful educational management system built using ASP.NET Core and Entity Framework Core. It allows users to manage students, instructors, courses, and enrollments efficiently. 🚀

## 📌 Features
- 🏫 Manage students and instructors
- 📚 Create and enroll in courses
- 🔍 View course details and enrolled students
- 📅 Track enrollment history
- ⚡ Built with ASP.NET Core & Entity Framework Core
- 🌐 API access via Swagger & Postman

## 🛠 Tech Stack
- 🌍 **ASP.NET Core** (MVC + Web API)
- 🗄 **Entity Framework Core** (EF Core)
- 🛢 **SQL Server** (Database)
- 🎨 **Bootstrap** (Frontend styling)
- 🧩 **Swagger** (API Documentation)

## 🚀 Getting Started
### 1️⃣ Clone the Repository
```sh
[ git clone https://github.com/EfsanNart/education-platform.git)
```
### 2️⃣ Navigate to the Project Folder
```sh
 cd EduPlatform
```
### 3️⃣ Set Up the Database
Modify the `appsettings.json` file with your SQL Server connection string:
```json
"ConnectionStrings": {
  "Default": "Server=LAPTOP-IOOHI3VQ\\SQLEXPRESS;Database=EduPlatformDB;Trusted_Connection=True;"
}
```
Then run:
```sh
 dotnet ef database update
```
### 4️⃣ Run the Application
```sh
 dotnet run
```
### 5️⃣ Access the API
Open your browser and navigate to:
```
https://localhost:5001/swagger
```

## 📂 Folder Structure
```
EduPlatform/
│── EduPlatform.Data/         # Database context and migrations
│── EduPlatform.Models/       # Data models
│── EduPlatform/Controllers/  # API controllers
│── EduPlatform/Views/        # Razor Views (MVC)
│── appsettings.json          # Configuration file
│── Program.cs                # Entry point
```

## 📸 Screenshots
🚧 *Coming soon!*

## 🤝 Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you’d like to change. 💡

## 📝 License
This project is licensed under the MIT License. 📜

---
**Happy Coding! 🚀**

