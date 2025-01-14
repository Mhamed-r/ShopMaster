🛒 Shop Master Windows Forms Application Using ADO.NET
Overview
Shop Master is a Windows Forms application designed to manage product information and user interactions with a database. The project leverages ADO.NET for database operations and features both user and admin functionalities.

Features
🔑 User Login and Registration: Secure authentication for users and administrators.

⭐ View and Store Favorite Products: Users can browse products and mark their favorites.

🛠️ Admin Management: Admins can manage product details and categories.

Database Design
The application uses a well-structured relational database with the following tables:

Users Table: Stores user credentials, including username, password, email, age, address, and role (admin or user).

Categories Table: Stores various product categories, such as electronics and clothing.

Products Table: Contains details of products, including their names, prices, and associated categories.

Favorites Table: Keeps track of users' favorite products by linking users to products.

Application Structure
The application consists of several main pages:

🔐 Login Page
Allows existing users to log in.

📝 Registration Page
Enables new users to create an account.

👤 User Pages
View Products: Users can browse available products.

Add to Favorites: Users can mark products as favorites.

⚙️ Admin Pages
Manage Products: Admins can add, edit, or delete products.

Manage Categories: Admins can add, edit, or delete categories.

Manage Users: Admins can view and manage user accounts.

Getting Started
Prerequisites
🛠️ Visual Studio with .NET Framework

🗄️ SQL Server or another compatible database system

Installation
Clone the repository:

sh
git clone https://github.com/yourusername/shop-master.git
Open the project in Visual Studio.

Set up the database using the provided SQL scripts.

Update the database connection string in the application configuration file.

Build and run the application.

Usage
Register as a new user or log in with existing credentials.

Browse products and add them to your favorites.

Admins can access the admin pages to manage products, categories, and user accounts.

Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

License
This project is licensed under the MIT License.

Acknowledgements
A huge thank you to my amazing instructor, Aya El-Sharnouby, and my friends Ahmed ELGaiar, Mostafa Elwahsh, and Nadine Aly for their support and encouragement. 🙏
