Steps to start and submit the lab:<br>
Create a folder for Week 11 lab in your GitHub repository for this course.<br>
Include a Readme.md file in your Week 11 lab folder. The contents of your Week 11 Lab/Readme.md would be a summary of your lab.<br>
In Blackboard submit a link to your GitHub Week 11 Lab when you have completed your lab<br>
Week 11 Lab Directions:<br>
Applied Knowledge: In this lab, you will add another page to your application, move existing code from a page to the newly added page, update code for the new page so that it works correctly, and demonstrate session state in your application by displaying session state values.<br>
Objectives:<br>
Add a new page to application<br>
Enable session state in an application<br>
Use and display session state in application<br>
Instructions:<br>
1. Make a copy of your completed Week 9 Lab files and use this copy to start your Week 11 lab.<br>
2. You will add another link to your Navbar. Create a Tools page as part of your Navbar. This is similar to how FAQ was added to your navbar in week 9 lab.<br>
3. Move the code for the form in Views/Home/Index.cshtml to your Views/Home/Tools.cshtml. Only move the code for the form to the Tools page. Leave the description of your retail store in the Index.cshtml file. Add a heading to your Tools page. <br>For the form to work correctly on your Tools page, you must do the following
a. Change the asp-action in the <form> element to Tools<br>
b. Change the asp-action in the <a> link to Tools<br>
4. Change the IActionResult Index code in HomeController.cs to IActionResult Tools i.e., the two methods with the [HttpGet] and [HttpPost] above them. All you are doing here is changing the name of the method from Index to Tools.
5. Add an IActionResult Index method to HomeController.cs like you did for the Contact and About Us pages. You are doing this because you renamed the IActionResult Index method to Tools in step 4.
6. Add additional details to Views/Home/Index.cshtml file. This page is the landing page for your retail store. The additional details should be informational, styled, readable, easy to navigate with the goal of keeping customers staying on your site in mind.
7. By default, ASP.NET Core MVC doesn’t enable session state. Add the services to Program.cs that will enable session state. Be sure to add them in the correct order and exactly where each service should be.
8. In HomeController.cs, set three session states to get course name, student id and date. Use Course, StudentId and CurrentDate(yyyymmdd) as the session variables. Set these states in the IActionResult Tools ( ) method.
9. In the Tools view, display the session states values that were set in step 8. Save and run your code. The Tools page should look like the image below.<br>
10. Upload your completed files to your Week 11 lab folder in GitHub and submit your link in Blackboard.<br>
