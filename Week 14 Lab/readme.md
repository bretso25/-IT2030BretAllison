Steps to start and submit the lab:<br>
Create a folder for Week 14 lab in your GitHub repository for this course.<br>
Include a Readme.md file in your Week 14 lab folder. The contents of your Week 14 Lab/Readme.md would be a summary of your lab.<br>
In Blackboard submit a link to your GitHub Week 14 Lab when you have completed your lab<br>
Week 14 Lab Directions:<br>
Applied Knowledge: In this lab, you will add a page to your application and validate data for the newly added page using the validation techniques and data attributes to validate the data.<br>
Objectives:<br>
Add a page to application<br>
Validate data for the page added<br>
Instructions:<br>
 Make a copy of your completed Week 11 Lab files and use this copy to start your Week 14 lab. You will add another link to your Navbar.<br>
 Add a Customer class to your Models folder with the following fields:<br>
First Name – string, 10 characters and no special characters<br>
Last Name– string, 10 characters and no special characters<br>
Street Address - string<br>
City - string<br>
State – 2 characters and no special characters<br>
Zip Code – 5 digits<br>
Phone – 10 digits<br>
Email - string<br>
 Each of these fields will be displayed in a Razor view file named Support.cshtml. In your Customer.cs class, you are to validate all 8 fields to ensure that only valid data is entered in the fields. Additionally, the First Name, Last Name, State, Zip Code, and phone should be validated as specified above. All fields are required.<br>
 Create a Views/Support folder, add your Support.cshtml file to this folder and include labels and input to display the 8 fields from the customer class. It should be a strongly typed view and  include a heading. The form should be styled like the styling for the Tools page. It will be part of your Navbar. The name of this new page is Support. The Support page will be a web form that will store the information in step 2 from customers visiting your retail store.
 Add a Support Controller to display the Support View. Be sure to include code for your [HttpGet] and [HttpPost] methods.<br>
 Add code in your Views/Shared/_Layout.cshtml to include a link in your navbar for your Support page. Make sure that your ASP.NET tag helpers are using the correct controllers and action methods.
 Upload your completed files to your Week 14 lab folder in GitHub and submit your link in Blackboard. The images below are screenshots of the Support page.<br>
