<div align="center">

![Task Manager Project Screenshot](https://via.placeholder.com/800x400?text=Task+Manager+API+Screenshot+Place+Here)

# Task Manager API

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQLite-003B57?style=flat&logo=sqlite)](https://www.sqlite.org/)
[![ORM](https://img.shields.io/badge/ORM-EF%20Core-512BD4?style=flat&logo=nuget)](https://docs.microsoft.com/en-us/ef/core/)
[![License](https://img.shields.io/badge/License-MIT-blue?style=flat)](LICENSE)

A robust, lightweight, and RESTful API designed for managing daily tasks efficiently. Built with **.NET 8** and **SQLite**, this project is optimized for Linux environments and requires no heavy database server installation.

</div>

---

## 📋 Features

- **🚀 High Performance:** Built on the latest .NET 8 framework.
- **💾 Lightweight Database:** Uses SQLite (`tasks.db`) for zero-configuration storage.
- **📄 Swagger Documentation:** Integrated UI for testing API endpoints interactively.
- **🐧 Linux Ready:** Fully compatible with Ubuntu/Debian environments.
- **CRUD Operations:** Complete management (Create, Read, Update, Delete) of task entities.

---

## 🛠️ Prerequisites (Ubuntu/Linux)

Before running the project, ensure you have the **.NET 8 SDK** installed.

```bash
# 1. Update package list
sudo apt-get update

# 2. Install .NET 8 SDK
sudo apt-get install -y dotnet-sdk-8.0

# 3. Verify installation
dotnet --version

🚀 Installation & Run
Follow these steps to set up the project on your local machine:
1. Clone the Repository
git clone [https://github.com/elenaghomi/TaskManager.git](https://github.com/elenaghomi/TaskManager.git)
cd TaskManager

2. Restore Dependencies
dotnet restore

3. Run the Application
You don't need to manually create the database; the application handles it automatically on startup.
# Run in development mode to see Swagger UI
dotnet run

After running, the API will be accessible at:
 * Localhost: http://localhost:5000
 * Swagger UI: http://localhost:5000/swagger
🔌 API Endpoints
All endpoints are prefixed with /api/manager.
| Method | Endpoint | Description | Request Body (JSON) |
|---|---|---|---|
| GET | /api/manager | Fetch all tasks | N/A |
| GET | /api/manager/{id} | Get a single task by ID | N/A |
| POST | /api/manager | Create a new task | { "title": "string", "isDone": boolean } |
| PUT | /api/manager/{id} | Update an existing task | { "title": "string", "isDone": boolean } |
| DELETE | /api/manager/{id} | Delete a task | N/A |
📂 Project Structure
TaskManager/
├── Controllers/       # API Controllers (Endpoints)
├── Models/            # Database Entities (TaskEntity)
├── Data/              # DbContext & Database Configuration
├── Services/          # Business Logic & Data Access Layer
├── Contracts/         # DTOs (Data Transfer Objects)
├── tasks.db           # SQLite Database File (Created on run)
├── Program.cs         # App Entry Point & Configuration
└── README.md          # Project Documentation

🤝 Contributing
Contributions are welcome! Please feel free to submit a Pull Request.
 * Fork the Project
 * Create your Feature Branch (git checkout -b feature/AmazingFeature)
 * Commit your Changes (git commit -m 'Add some AmazingFeature')
 * Push to the Branch (git push origin feature/AmazingFeature)
 * Open a Pull Request
<div align="center">
<sub>Built for educational purposes.</sub>
</div>

