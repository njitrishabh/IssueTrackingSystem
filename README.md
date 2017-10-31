# IssueTrackingSystem
Created a Web app for an issue tracking system, developed using ASP.NET MVC Framework.

An issue consists of the following basic properties:

1. Title

2. Status

3. Description

4. Severity

5. Assignee

6. DueDate

A user can create a new issue and view it afterwards.
All issues are persisted in the SQL Server Express LocalDB for retrieval, using a .NET Framework data-access technology known as the Entity Framework to create Model classes using the Code First approach.

An issue can be retrieved via a unique URL:(eg: http://localhost:54898/Issues/Details/4), where "4" is the unique Id of a specific issue from the database & "54898" is the port number on which the app runs and would differ on evry users computer.

The example project dashboard url: http://localhost:54898/Issues/Index

Project setup instructions in Visual studio:

Note: In order to use System.Data.Entity, and the related class, you need to install the Entity Framework NuGet Package(https://www.nuget.org/packages/EntityFramework/). Follow the link for further instructions.

Execution Instructions:

Note: The app runs on localhost:port on the users computer

1. Open the app in Visual studio by double clicking on the IssueTracking.sln file.
2. once the app opens press F5 to run the app. It will be excuted in your default browser.
3. You will see a login page loaded first, new user should register first with register button
(Ex: One Existing user Login credentials- email: john@njit.edu, password: John@123)
4. Then you would be redirected to the IssueTracking dashboard where you can see a lookup of all the xisting issues from the database
and hece, perfrom CRUD operations as per users need.
