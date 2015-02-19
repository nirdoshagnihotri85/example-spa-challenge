# Single Page Application sample task

### In order to be considered for the MVC/Web API/Javascript position, you must complete the following steps.
*Note: This task should take no longer than 3-4 hours at the most to complete.*


### Prerequisites

- You will need to have Visual Studio 2012 or 2013 installed to complete this task.
- This will require familiarity with  [http://www.asp.net/mvc](ASP.NET MVC), [http://www.asp.net/web-api](Web API), and [http://www.asp.net/entity-framework](Entity Framework)

## Task

- Fork this repository (if you don't know how to do that, Google is your friend).
- Create a *src* directory.
- In the *src* directory, create a new ASP.NET MVC 5 and Web API application that will display a list of master/detail values stored in a database. 

JSON data structure of model is the below: 

```
"Screens":  
[
    {
      "ID": 8991,
      "Name": "EPAY",
      "System": "PAYROLL",
      "Title": "Employee Payment List",
      "LastUpdate": "Wed Jan 28 11:44:16 +0000 2015"
      "Fields": [
        {
          "ID": 21053,
          "Name": "_TRANNO",
          "Caption": "TRANNO",
          "Status": "Visible",
          "Tooltip": "Enter transaction number",
          "LastUpdate": "Mon Jan 26 03:35:21 +0000 2015"
        },
        ...
      ]
    },
    ...
  ]
```
*Notes:*
  - *the ID field is an auto-incrementing identity*
  - *the LastUpdate field is a date type and takes a value based on the time that the entity was last saved*
  - *the Field.Status property is an enumeration type and takes one of the following possible values: `Visible`, `Hidden`, or `Disabled`*


##### Model the Screen and Field classes and use Entity Framework to generate the database 

*The Screen object has a Fields property containing the set of related Field object instances.*

##### Seed 4 Screens into the system:

    Screen 1: 
      Name: EPAY 
      System: PAYROLL
      Title: Employee Payment List

    Screen 2: 
      Name: LHISTORY 
      System: HR
      Title: History of Leaves

    Screen 3: 
      Name: PHISTORY 
      System: PAYROLL
      Title: History Payment List

    Screen 4: 
      Name: PARRT 
      System: PAYROLL
      Title: Payroll Report Status
  
##### Seed the database with a random number - between 10 and 20 - Field instances for each Screen.  
  - At least 5 should have Status `Visible`
  - At least 3 should have Status `Hidden`
  - At least 2 should have Status `Disabled`


##### Create a two Web API routes, one to retrieve a list of Screens from the database; the other to retrieve a single Screen and all related Fields data

##### Create a read-only UI for Screens and Field data:

In a view that shows data in the system, create two list elements.   The contents of the lists should be populated asynchronously, accessing the Web API routes and some client-side javascript (e.g., `jQuery.ajax()`).  

- List 1 - 
  - Header: Screens
  - In this list display the set of all Screens in the system, grouping by the Screen.System property, and displaying the Screen Name and Title. Each item in the list should respond to a user click to select the Screen.

- List 2 - 
  - Header: Fields
  - On seletion of a Screen from List 1, List 2 should update to show those Fields that are associated with the selected Screen.  In this list, set the background color of rows based on their Status property: if `Visible`, use rgb(152,204,62); if `Hidden`, use rgb(210,210,210); if `Disabled`, use rgb(231,186,233);



## Once Complete
1. Commit and Push your code to your new repository
2. Send us a pull request, we will review your code and get back to you



