# _Pierres Treat Shop_

#### By _**Jeremy Kale Padot**_


## Description

_An MVC web application allowing Pierre to log his savory and sweet treats with user authentication and many-to-many relationships._

## Program User Stories

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application will display a home page in which the user may choose to view treats and flavors or create an account | Home | "View Treats", "Create Account"|
| User can create, read, update, delete, and list Treats and Flavors in a catalog inventory.| New Treat, and flavor is entered | Treat and Flavor are now avaliable to view and edit |
| When user clicks "Add Treat", they are directed to page to add new treat  | Click: "Add Treat" | "Add A New Treat" Name: "Input Name" |
| When a user creates a treat, they are prompted to add a flavor | Click: "Add Flavor | "Add a new flavor" Name: "Input Name" |
| User can assign many flavors to treats | "Treat Name" Click: "Add a new flavor" | Flavor Name: "Input Name", "Input Name | 
| When user clicks "Add Flavor", they are directed to page to add new flavor  | Click: "Add Flavor" | "Add A New Flavor" Name: "Input Name" |
| User can assign many treats to flavors | "Flavor Name" Click: "Add a new Treat" | Treat Name: "Input Name", "Input Name |
| User can Create an Account and edit fields | "Create Account" | User is logged in|
| If a user is not logged in, only a read view is avaliable|"Add a new Treat" | "You must create an account to perform this action" |


## Setup/Installation Requirements

### 1.  Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.

#### Install dotnet script
Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).

### 2. Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
```sh
cd desktop
git clone https://github.com/kalepadot/PierresTrests.Solution
cd PierresTreats.Solution
```
### 3. Install all necessary packages and make sure the project will build
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd TreatShop
dotnet restore
dotnet build
```

### 4. Create the database and tables
Enter the following to build your database and tables for the program:
```sh
dotnet ef migrations add Initial
dotnet ef database update
```

### 5. Launch the project in your browser
In your terminal, type:
```sh
dotnet watch run
```
Then hold ```command``` while clicking the link in your local terminal to your local address, which should be:
```sh
http://127.0.0.1:5000
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kalepadot/PierresTreats.Solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _MySQL_
* _EF Core 2.2.6_
* _ASP.NET Core Identity_
* _Razor 2.2.0_
* _Material Design Lite_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Jeremy Kale Padot_**
