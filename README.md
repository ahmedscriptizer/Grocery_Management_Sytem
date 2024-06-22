# Grocery Management System
Welcome to the Grocery Management System! This project is designed to manage the operations of a grocery store efficiently, including product management, customer interactions, employee data, promotions, and sales. The system is built using C# Windows Forms and connected to MongoDB for data persistence.

## Features
+ CRUD Operations: Perform Create, Read, Update, and Delete operations on various collections.
+ Atomic Transactions: Ensure data integrity and consistency with atomic operations.
+ User Authentication: Secure login panel for employee and admin access.
+ Feedback System: Collect and manage customer feedback.
+ Inventory Management: Track and manage stock levels.
+ Sales Tracking: Record and analyze sales data.
+ Supplier Management: Manage supplier information and orders.
## Collections
The system includes the following MongoDB collections:

1. PRODUCTS
2. CUSTOMER
3. EMPLOYEE
4. PROMOTION
5. LOGIN PANEL
6. FEEDBACK
7. INVENTORY
8. SALES
9. SUPPLIER
10. Getting Started
## Prerequisites
+ Visual Studio (for C# Windows Forms)
+ MongoDB (local or cloud-based)
+ MongoDB Driver for C#
## Installation
### Set Up MongoDB
Ensure MongoDB is installed and running on your machine or accessible via a cloud service. Create the required collections:

``` use groceryDB
db.createCollection("PRODUCTS")
db.createCollection("CUSTOMER")
db.createCollection("EMPLOYEE")
db.createCollection("PROMOTION")
db.createCollection("LOGIN PANEL")
db.createCollection("FEEDBACK")
db.createCollection("INVENTORY")
db.createCollection("SALES")
db.createCollection("SUPPLIER")```

Configure Connection String

In the project, locate the MongoDB connection string in the configuration file and update it with your MongoDB instance details.

csharp
Copy code
// Example configuration in app.config or settings file
<connectionStrings>
    <add name="MongoDBConnectionString" connectionString="mongodb://localhost:27017/groceryDB" />
</connectionStrings>
Build and Run the Project

Open the solution in Visual Studio, build the project, and run it.

Usage
Login: Use the login panel to access the system.
Manage Products: Add, update, delete, and view products in the inventory.
Customer Management: Maintain customer information and view feedback.
Employee Management: Add and manage employee records.
Promotions: Create and apply promotions to products.
Sales: Track and analyze sales data.
Suppliers: Manage supplier details and inventory supplies.
Screenshots

Login panel for user authentication


Interface for managing products


Sales data tracking and analysis

Contributing
Contributions are welcome! Please fork the repository and submit a pull request with your changes. Ensure your code adheres to the project's coding standards.

License
This project is licensed under the MIT License. See the LICENSE file for more details.

Contact
For any inquiries or feedback, please reach out to:

Email: your.email@example.com
GitHub: yourusername
Thank you for using the Grocery Management System! We hope it helps you manage your grocery store operations effectively.
