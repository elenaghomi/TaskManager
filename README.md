<div align="center">

![Task Manager Project Screenshot](https://via.placeholder.com/800x400?text=Task+Manager+API+Screenshot+Place+Here)

# Task Manager API

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQLite-003B57?style=flat&logo=sqlite)](https://www.sqlite.org/)
[![ORM](https://img.shields.io/badge/ORM-EF%20Core-512BD4?style=flat&logo=nuget)](https://docs.microsoft.com/en-us/ef/core/)
[![License](https://img.shields.io/badge/License-MIT-blue?style=flat)](LICENSE)

A robust, lightweight, and RESTful API designed for managing daily tasks efficiently. Built with .NET 8 and SQLite, this project is optimized for Linux environments and requires no heavy database server installation.

</div>

---

## 📋 Features

- 🚀 High Performance: Built on .NET 8
- 💾 Lightweight SQLite database (tasks.db)
- 📄 Built-in Swagger documentation
- 🐧 Linux-ready (Ubuntu/Debian)
- Full CRUD operations for task entities

---

## 🛠️ Prerequisites (Ubuntu/Linux)

Install the .NET 8 SDK:

```bash
# Update package list  
sudo apt-get update

# Install SDK  
sudo apt-get install -y dotnet-sdk-8.0

# Verify  
dotnet --version
```
---

## 🚀 Installation & Run
```
### 1. Clone the Repository  
git clone https://github.com/YOUR_USERNAME/TaskManager.git  
cd TaskManager

### 2. Restore Dependencies  
dotnet restore

### 3. Run the Application  
dotnet run
```
Accessible at:  
Localhost: http://localhost:5000  
Swagger UI: http://localhost:5000/swagger

---

## 🔌 API Endpoints

Prefix: /api/manager

Method | Endpoint | Description | Body  
-------|----------|-------------|------  
GET | /api/manager | Fetch all tasks | N/A  
GET | /api/manager/{id} | Get task by ID | N/A  
POST | /api/manager | Create task | { "title": "string", "isDone": boolean }  
PUT | /api/manager/{id} | Update task | { "title": "string", "isDone": boolean }  
DELETE | /api/manager/{id} | Delete task | N/A

---

## 📂 Project Structure
```
TaskManager/  
├── Controllers/  
├── Models/  
├── Data/  
├── Services/  
├── Contracts/  
├── tasks.db  
├── Program.cs  
└── README.md  
```
---

