# 🔒 PassWordGen - Password Management Application

PassWordGen is a simple password management tool that allows users to securely store, generate, and manage their passwords in an encrypted SQLite database. The application uses AES encryption for storing passwords safely. It also provides a user-friendly interface for adding, updating, and deleting password records.

---

## ✨ Features

- **🔐 Password Management**: Store and manage passwords with associated usernames and URLs.
- **🛡️ Encryption**: All passwords are encrypted using AES encryption before being saved in the database.
- **⚙️ Password Generation**: Easily generate random passwords with configurable length and options for including special characters.
- **🗄️ Database Integration**: Stores password records in a local SQLite database.
- **🔍 Search Functionality**: Search stored passwords based on name, username, URL, or password.
- **📋 Copy Password**: Copy generated or stored passwords to the clipboard with a single click.
- **✏️ Record Update & Deletion**: Update or delete password records from the database.
- **🖥️ Simple Interface**: Easy-to-use interface with data grid view for displaying saved passwords.
- **🌐 Web Navigation**: Double-click a URL in the data grid to open it in your default browser.

---

## 🛠️ Installation

1. **📥 Download** or clone the repository.
2. Open the project in **Visual Studio**.
3. **🔧 Build** the project.
4. Ensure the required SQLite database file (`database.db`) is available in the project's folder (PassWordGen/PassWordGen/debug/bin/database.db).
5. **▶️ Run** the application.

---

## 🚀 How to Use

1. **Create main Password**:  
   - At the first start of an application click on "Nemáte heslo?" link to create a new main password.  
   - Chose strong but well remembered password, because it is not possible to retrieve a lost password.  

2. **Add a Password Record**:  
   - Fill in the password name, username, password, and optional URL.  
   - Click the **Save** button to store the record in the database.  

3. **Generate a Password**:  
   - Select the desired password length and specify whether to include special characters.  
   - Click the **Generate** button to create a new password.  

4. **Update a Password**:  
   - Select a record from the data grid, edit the fields, and click the **Update** button.  

5. **Delete a Password**:  
   - Select a record from the data grid and click the **Delete** button to remove it from the database.  

6. **Search**:  
   - Enter a search term in the search field to find passwords by name, username, or URL.  

7. **Open URL**:  
   - Double-click a URL from the data grid to open it in your default web browser.  

---

## 🛑 Requirements

- **Windows OS**
- **.NET Framework**
- **SQLite** (included in the project)

---

## 📚 Technologies Used

- **C#**: The main programming language.
- **SQLite**: A lightweight database for storing password data.
- **AES Encryption**: To encrypt passwords before storing them.
- **Windows Forms**: For the user interface.

---

## 📄 License

This project is licensed under the **MIT License**.

---

## 📧 Contact

For any inquiries or issues, contact the developer:  
📩 [kolibal.m@gmail.com](mailto:kolibal.m@gmail.com)
