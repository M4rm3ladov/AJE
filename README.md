
# Point of Sale and Inventory System

A desktop point of sale and inventory system for a local retailer


## Technologies

- Vb.Net

- MySql

- Winforms

- Report Viewer

## I. Authentication
  ### A. Admin
  - Profiling
  ### B. Manager
  - Inventory
  - Customers
  - Reports
  ### C. Cashier
  - Point of Sale

## II. Profiling
  ### A. Items
  #### Items
  CRUD store items with filtered search by item code, description, brand, or category
  #### Category
  CRUD items' categories
  #### Brand
  CRUD item's brands
  #### Unit
  CRUD item's units of measurement

  ### B. Users
  #### System Accounts
  CRUD system accounts with filtered search by name, username, or branch 
  #### Cashier
  CRUD cashier accounts which is connected to a system account with filtered search by name or username
  #### Manager
  CRUD manager accounts which is connected to a system account with filtered search by name or username
  
  ### C. Services
  CRUD store services with filtered search by service code or description
  
  ### D. Branch
  CRUD store branches/locations
  
  ### E. Supplier
  CRUD inventory suppliers with filtered search by name or address
  
  ### F. Credit Limit Adjust
  Create or update the maximum credit limit allotment for each users
  
  ### G. Critical Stock Adjust
  Create or update the minimum critical stock for each inventory items

## III. Inventory
  ### A. Stock List
  - Read all items with filtered search by item code, description, categories, brands, or item stock status
  - Read and print history report of all items in stock filtered by date range  
  
  ### B. Stock In
  - CRUD stocked in items
  - Read and print history report of all stocked in items by date range  
  
  ### C. Stock Transfer
  - CRUD transferred stock items to different branches
  - Read and print history report of all transfered stock items by date range  
  
  ### E. Stock Return
  - CRUD returned stock items to a supplier
  - Read and print history report of all returned stock items by date range  
  
  ### F. Stock Out
  - CRUD stocked out items 
  - Read and print history report of all stocked out items by date range  
  
  ### G. Periodic Stock Adjustment
  - CRUD quantity adjusted stock items
  - Read and print history report of all adjusted stock items by date range
  
## IV. Customers
CRUD customers information and credit limit with filtered search by customer code or name

## V. Reports
  ### A. Sales Report
  #### All Sales
  Read and print history report of all sales by date range
  
  #### Cash Sales
  Read and print history report of all cash sales by date range
  
  #### Credit Sales
  Read and print history report of all credit sales by date range
  
  ### B. Customer Report
  #### Customer Balance
  Read and print history report of all customer balance by date range
  
  #### Customer Transactions
  Read and print history report of specific customer's transactions by date range
  
  #### Customer Payment History
  Read and print history report of all customer payments by date range
  
  ### C. Cashier Report
  #### Cashier Log Report
  Read and print history report of all cashier logs by date range
  
  #### Cash In Report
  Read and print history report of all cashier cash in by date range
  
  #### Cash Out Report
  Read and print history report of all cashier cash out by date range
  
  ### D. Refund Report
  #### Refunded Cash Sales
  Read and print history report of all refunded cash sales by date range
  
  #### Refunded Credit Sales
  Read and print history report of all refunded credit sales by date range
  
  ### E. Void Report
  #### Voided Cash Sales
  Read and print history report of all voided cash sales by date range
  
  #### Voided Credit Sales
  Read and print history report of all voided credit sales by date range

## VI. Point of Sale
  ### A. Initial Balance
  Create initial cash balance of a cashier with manage authentication approval 

  ### B. Items and Services Search
  Read all items or services filtered by code or description

  ### C. New Transaction
  #### Cash
  Create new cash transaction
  #### Credit
  - Create new credit transaction
  - Select a customer from customer list

  ### E. Add to Cart
  CRUD items or services to cart with price specified by range

  ### F. Check Out
  Create new check out transaction with invoice or receipt

  ### G. Cash In
  Create new cash in log details
  
  ### H. Cash Out
  Create new cash out log details

  ### I. Refund
  #### Refund Items and Services
  CRUD refund cash or credit transactions by receipt or invoice
  
  #### Refund History
  Read all refunded cash or credit transactions by invoice or receipt

  ### J. Customer Balance
  #### Settle Credit Balance
  CRUD credit balance payment of a specific customer filtered by input date or sale date 
  
  #### Payment History
  Read all payments history of a specific customer filtered by transaction date

  ### K. Void Transactions
  #### Orders
  CRUD void order transaction filtered by sale date or input date
  
  #### Void History
  Read all voided order transactions filtered by date range

  #### Logout
  Logs out cashier saving cashier log

## VII. Logout
Logs out system account user 
  
## Screenshots

### Login

![Login](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Login.PNG?raw=true)

### Home

![Home](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/main%20menu.PNG?raw=true)

### Profiling
#### Items

![Items](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Profiling%20Items.PNG?raw=true)

#### Services

![Services](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Profiling%20Services.PNG?raw=true)

### Customers

![Customers](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Customers.PNG?raw=true)

### Inventory

#### Stock List
![StockList](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Stock%20List.PNG?raw=true)

#### Stock In
![StockIn](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Stock%20In.PNG?raw=true)

#### Stock In History
![StockInHistory](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Stock%20In%20History.PNG?raw=true)

#### Stock In Report
![StockInReport](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Stock%20In%20Report.PNG?raw=true)

### Point Of Sale

#### Add To Cart
![AddToCart](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Pos%20AddCart.PNG?raw=true)

#### Checkout
![Checkout](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Pos%20Checkout.PNG?raw=true)

### Report

#### Sales
![Sales](https://github.com/M4rm3ladov/AJE/blob/master/ScreenShots/Sales%20Report.PNG?raw=true)
