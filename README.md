# # 🏦 Bank Management System (3-Tier Architecture)

A robust, scalable, and secure Bank Management System built with **C#** and **ADO.NET**. This project demonstrates enterprise-level software engineering principles by strictly separating concerns into three distinct layers.

## 🏗️ System Architecture
* **Presentation Layer (UI):** Currently a well-structured Console application. Designed to be completely decoupled from database logic.
* **Business Logic Layer (BLL):** Handles data processing, business rules, cryptography, and complex permission logic.
* **Data Access Layer (DAL):** The only layer that communicates with the SQL Server database. Fully protected against security threats.

## ✨ Key Features
* **Advanced Security:** Complete protection against SQL Injection using parameterized queries (`SqlParameters`).
* **Smart Permissions:** User access control is managed using complex **Bitwise Operations** for optimized memory and performance.
* **Data Encryption:** Sensitive user data (like passwords) is encrypted before reaching the database.
* **Currency Exchange System:** Built-in calculator and management for currency conversion rates.
* **Robust Error Handling:** Centralized exception handling and crash prevention using `TryParse` and null-reference checks.

## 🛠️ Tech Stack
* **Language:** C#
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET
* **Core Concepts:** OOP, 3-Tier Architecture, Separation of Concerns, Bitwise Logic.

## 🚀 Future Roadmap
* [ ] Implement **Windows Forms (GUI)** as a secondary presentation layer to demonstrate UI flexibility without altering the backend logic.
* [ ] Refactor connection string management using configuration files.
* [ ] Migrate to ASP.NET Core Web API.
