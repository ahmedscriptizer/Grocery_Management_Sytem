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

```MongoDB Shell
use groceryDB
db.createCollection("PRODUCTS")
db.createCollection("CUSTOMER")
db.createCollection("EMPLOYEE")
db.createCollection("PROMOTION")
db.createCollection("LOGIN PANEL")
db.createCollection("FEEDBACK")
db.createCollection("INVENTORY")
db.createCollection("SALES")
db.createCollection("SUPPLIER")
```

### Configure Connection String

In the project, locate the MongoDB connection string in the configuration file and update it with your MongoDB instance details.

``` csharp
// Example configuration in app.config or settings file
<connectionStrings>
    <add name="MongoDBConnectionString" connectionString="mongodb://localhost:27017/groceryDB" />
</connectionStrings>
```
### Build and Run the Project

Open the solution in Visual Studio, build the project, and run it.

## Usage
+ Login: Use the login panel to access the system.
+ Manage Products: Add, update, delete, and view products in the inventory.
+ Customer Management: Maintain customer information and view feedback.
+ Employee Management: Add and manage employee records.
+ Promotions: Create and apply promotions to products.
+ Sales: Track and analyze sales data.
+ Suppliers: Manage supplier details and inventory supplies.
### Screenshots
Here are some screenshots for some idea of how the forms are presented to the user.

Login panel for user authentication
![image](https://github.com/ahmedscriptizer/Grocery_Management_Sytem/assets/142499778/e0087178-d49f-4ae7-9368-b6ad1d016ffc)

Interface for managing products
![image](https://github.com/ahmedscriptizer/Grocery_Management_Sytem/assets/142499778/9518c436-c8a9-4e00-8d14-d9e466474057)

Sales data tracking and analysis

<img src="https://github.com/ahmedscriptizer/Grocery_Management_Sytem/assets/142499778/da3e4256-6ee2-4044-897b-cec7fb9b91c9" alt="image" width="500"/>

## License
You are allowed to modify or use this code any way you like.

***
Thank you for using the Grocery Management System! We hope it helps you manage your grocery store operations effectively.
