<h1>Week 16 Lab</h1>
<h3>Instructions:</h3>
*In your Readme.md file in your Week 16 folder in GitHub, list three things you learned in ASP.NET Core MVC web programming course. Be specific and include a brief description with details.<br>
*List three things you would like to improve in your application. Be specific and include a brief description with details.<br>
*Make a copy of your Week 14 lab files and using the copy, make 3 style updates to your application. Use Bootstrap for your styling updates. Specify the filename(s) that has the updates and specify the style updates as well in your Readme.md file.<br>
*Upload your completed files to your Week 16 lab folder in GitHub and submit your link in Blackboard.<br><br>

<h4>There are quite a few things I've learned while working with ASP.Net Core MVC:</h4>
1. One thing I'm pretty good at is greating new pages on the site or views.  These are bascially the pages that everyone will see on the site. To create a new page you   can either copy an existing one by using copy, then paste, or you can right click on the folder (Home) > Add > New Items > and choose an option with .cshtml
2. Also, setting up a controller or class is pretty important.  A controller class is normally a class part of the Model View Controller (MVC) pattern. A controller     basically controls the flow of the data. It controls the data flow into model object and updates the view whenever data changes.  To create a new one you can again     right click on the Controllers folder > Add > New Item > Class. 
3. Another important piece of visual stuido is editing the modules area.  A model can help you visualize the world in which your system works, clarify users' needs,     define the architecture of your system, analyze the code, and ensure that your code meets the requirements.  In a few of the models I created, the models contained     the code necessary for the forms to work.  For example, my Customer.cs file contains all the code to validate the Support Form that we created last lab.

<h4>3 Things I would like to improve in my application would be:</h4>
1. I would like to clean up some of the backend functionality for it.  For example, the debugger or troubleshooter start program link says Lab3.  I've tried changing this a few times, but it always messes things up.  Along with that, in the right hand bar it says Lab9.  I've tried changing this a few times too, but It also seems to mess things up.  Then alson in the right hand ba it says solution 'Lab5' (1 of 1 project).  I would like to get these to match the current lab or solution that I'm working on.  I'm sure these are easy changes, I think that changing them requies you to update a few other spots.  I'll work on learning this.
2. Another thing I would like to imporve and I think this caued a problem throughout the labs was my version was using Framework 3.1, but should of been using framework 6.0.  I'll probably have to start from scratch to fix this.
3. Lastly, I would like to clean up the design of the site a bit.  Modify the css, add images, more pages, more text, to get it to finally look like a fully functional webiste.  For the lab today I'm going to make a few css changes, but ultimatly I would like it to get the appearance of a fully functional webiste.
<br>
<h4>3 style updates that I made to the site:</h4>
1. First, Let's start with something easy.  I wanted to change the color of the main banner that goes across the site.  It was originally a light blue and I changed it to a darker blue.  The spots I changed this in was in the bootstrap.css file.  I changed these two lines:<br>
 To:    --bs-primary: #083c89;<br>
 Was:   --bs-primary: #0d6efd;<br>
 To:    --bs-primary-rgb: 8, 60, 137;<br>
 Was:   --bs-primary-rgb: 13,110,253;<br>
2. Let's update the color of the Main h1 tag to somethign else.  I went with black color instead of blue.  To make the change I went into the bootstrap.css file and  looked for this line:<br>
   h1, .h1 {<br>
     font-size: 2.5rem;<br>
   }<br>
   I modified this like:<br>
     h1, .h1 {<br>
     font-size: 2.5rem;<br>
     color:#000000;<br>
   }<br>
3. The last change I made was I wanted to change the h4 on the Support page https://localhost:5001/Support/Support  "Please enter your information in the form below.".  I wanted it a different color along with some margin.  I found the class in the bootstrap.css file.<br>
     h4, .h4 {<br>
        font-size: 1.5rem;<br>
    }<br>
    h4, .h4 {<br>
        font-size: 1.5rem;<br>
        color: #083c89;<br>
        margin: 10px 0;<br>
    }<br>
    
4.  There's so many things I'd like to do with the site.  I hope I can keep working on it in my spare time.  Like I mentioned before, I would like to scrap this version and start with a completely new one.  I think that kind of practice is invaluable.


