# UsingWebApiofCRUDthroughMVCController-via-Calling-Methods-in-MVC
Create a New Project
Asp.net Web Application 
Select Web API , Check MVC , Check WebApi
Create One More Project in Same Solution
Asp.net Web Application
MVC, Check MVC
Create DB==>CRUDDB
Create Table==>Employee
Create ADO.net Entity Model in WebAPI(DBModels)
Entities Name==>DB Model
Select only Table ==>Employee(then Build it)
Add WebAPI Controller with Actions Using EF(fill the Model Class, Context Class) Controller Name==Employee
No need to Check If Model State here so delete that code from Put And Post
Insert Some Values in table using SQL 
Run Your Project once LocalHost/Api/Employyee
Now work on MVC project(Create a New Controller)eMPTY(Employee (Name))
Here also Create a Model Class with Name mvcEmployeeModel(rather than creating a reference) Copy properties from WebApi Model to Mvc Model
Create a View of Index(List,Model Class)Dont Select Context Class)
In Order to Consume WebApi Method we must install WEBAPICLIENT using  Manage Nuget Packages)Install (System.Net.Http)
For Accesing Methods of WebApi We have to create object of Web Api so rather than Creating Object Agian and again we must do code of it in sepearte class that and MArk it as Public Static(GlobalVariables.cs)
Now Write Down the Code to access WebApi get method in Index Method
Now Run the project and check both the project is in running Status(Solution==>Properties==>Check Multiple and select Start Apply Ok
As here Both the controller has HOme we can Recognize it going through it local address
Add some Layout Code for better Front End
Install Alertify JS and Drag and Drop in Layout file
For Delect just check through Alertify Js code 



https://www.youtube.com/watch?v=iublAXAm8HQ
