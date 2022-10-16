
For this lab you will debug the Tip Calculator app that is provided for you in the TipCalculatorWk7 folder. 
- In your Readme.md file in your Week 7 lab folder, list and identify all errors that you find. <br>
- Specify which file had the errors and what the error was and state what you did to fix the error.<br>
- Use the Error List window to find and correct any syntax errors that display when you try to run the app. Be sure to write down the errors as you encounter them. You can put comments in your code to help you keep track of the errors.<br>
- Use the Internal Server Error page and its stack trace to find and correct any unhandled exceptions that occur when you run the app.<br>
- Set a breakpoint in the model class and step through its code to find the error that leads to the app calculating an incorrect tip amount.<br>
- Use the Developer Tools (as shown below) to find and correct the CSS issue that prevents the label elements from displaying with the expected width.<br>
Submit the link to your corrected TipCalculatorWk7 project files.<br>

Attempting to run the app gives you build errors pop up.  In the Errors list I get these errors:

- CS1002 ;expected , **File** TipCalculator.cs
<br>To fix the TipCalculator.cs, I add a semicolon here.  return tip; <br>
- CS0161 'HomeController.Index()':not all code paths return a value, **File** HomeController.cs
- CS0103 The name 'Viewbag' does not exist in the current context,   **File** HomeController.cs
<br>To fix this you needed to change Viewbag to ViewBag.  Names are case sensitive. ViewBag.TwentyFive = 0;<br>
- "widht" is not a known CSS property name. **File** site.css
