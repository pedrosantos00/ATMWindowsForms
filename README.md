### ATMWindowsForms
![Screenshot 2023-02-12 155451](https://user-images.githubusercontent.com/62798656/218324027-f4fc186c-e01b-4b8f-a340-50c7108dc25b.png)  <br>
ATM Windows Forms is a desktop application designed to simulate an ATM machine. It offers a range of features including login, deposit, transfer, withdraw, data editing, and more. The application is built using the Windows Forms framework and .NET Core 6, providing a user-friendly interface and a smooth experience. The application also makes use of asynchronous programming to improve performance.

## **Features**

Login: Secure login system using user credentials. <br>
Deposit: The user can deposit money into their account. <br>
Transfer: The user can transfer money to another account. <br>
Withdraw: The user can withdraw money from their account. <br>
Edit Data: The user can edit their personal information such as name, address, and phone number. <br>
MBWAY: A payment option using phone numbers. <br>
Account History: The user can view their account history. <br>
Pay Services: The user can pay for various services. <br>

## **Requirements**

.NET Core 6 <br>
Visual Studio 2019 or higher <br>
SQL Server

## **Installation**

Clone the repository to your local machine using the following command:<br>
git clone https://github.com/pedrosantos00/ATMWindowsForms.git<br>
Open the solution file ATM-Windows-Forms.sln using Visual Studio.<br>

Go to the app.config file and put in your connection string.<br>
( Don't change the name ! ) <br>

Use SQL Server Management Studio to create the database.<br>

Open the Package Manager Console and run the following command:<br>

Update-Database<br>

Use SQL Server Management Studio to create the database.<br>

Run the following query to add the bank names:<br>

INSERT INTO [dbo].[Banks] ([Name]) VALUES ('Millennium');<br>
INSERT INTO [dbo].[Banks] ([Name]) VALUES ('Montepio');<br>
INSERT INTO [dbo].[Banks] ([Name]) VALUES ('NovoBanco');<br>
INSERT INTO [dbo].[Banks] ([Name]) VALUES ('Santander');<br>

Run the following query to add a user name:<br>

INSERT INTO [dbo].[Users] ([FirstName], [LastName], [Email], [Password], [PhoneNumber], [Balance], [BankId])
VALUES ('John', 'Doe', 'john.doe@email.com', 'password123', '123456789', 1000, 1);

Build the solution using Ctrl + Shift + B or by going to Build > Build Solution.<br>

Run the application by hitting F5 or by going to Debug > Start Debugging.<br>

## **Usage**

Upon opening the application, you will be prompted to log in using your credentials.<br>

Once you have logged in, you will have access to all the features including deposit, transfer, withdraw, data editing, and more.<br>

## **Tools Used**

.NET Core 6<br>
Entity Framework<br>
Windows Forms<br>
SQL Server<br>
Visual Studio<br>
Package Manager Console<br>
Async programming

## **Contributing** 

If you would like to contribute to the project, feel free to submit a pull request or reach out to the project maintainers for more information.<br>

## **License**

This project is licensed under the MIT License.

## **Contact**

For any questions or feedback, feel fry to contact me 
