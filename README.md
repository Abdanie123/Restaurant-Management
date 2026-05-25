# Restaurant Management System (POS)

## Description
A Restaurant Management System (Point of Sale) developed using C# (Windows Forms) and MySQL. The system allows users to manage menu items, create customer orders, track order details, and process payments through a graphical interface.

## Features
- Add, update, and delete menu items
- Categorize items (Food, Drinks, Dessert)
- Select menu items to create orders
- Automatically calculate total amount
- Store and manage orders with order details
- View order history
- Delete order items
- Process payments for orders

## Technologies Used
- C# (Windows Forms)
- MySQL Database
- Visual Studio
- MySQL Connector (MySql.Data)

## Database Structure
The system uses a database named `pos_restaurant_simple` with the following tables:

### Menu Items
- item_id (Primary Key)
- item_name
- price
- category

### Orders
- order_id (Primary Key)
- order_date
- payment_status

### Order Details
- order_detail_id (Primary Key)
- order_id (Foreign Key)
- item_id (Foreign Key)
- quantity
- price

## How to Run
1. Install MySQL or XAMPP
2. Create a database named:pos_restaurant_simple
3. Create the required tables (menu_items, orders, order_details)
4. Open the project in Visual Studio
5. Update the connection string: server=localhost;user=root;database=pos_restaurant_simple;password=**YOUR_PASSWORD**;
6. Run the application

## Author
Abdanie Hadjijamel – Information Systems Student
