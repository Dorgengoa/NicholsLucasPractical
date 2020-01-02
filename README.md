<h1>Student Fact Template Builder Documentation</h1>
<p>This application uses ASP.NET Web API to allow a user to build sa Student Fact Template.</p>
<p>It also makes use of several frameworks and libraries including:</p>
<ul>
  <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
  <li><a href='https://angular.io/'>Angular</a> and <a href='http://www.typescriptlang.org/'>TypeScript</a> for client-side code</li>
  <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
  <li><a href='https://docs.microsoft.com/en-us/ef/'>Entity Framework</a> for database interactions</li>
  <li><a href='https://joshclose.github.io/CsvHelper/'>CSVHelper</a> for creating relevant csv files</li>
</ul>

<h2>SQL script</h2>
<p>I'm not entirely sure what was meant by "SQL deployment script", and also had difficulty testing the script I did make due to all the how sql connections and databases are already intigrated into my computer. If for some reason it fails to create the databse, try running the program and creating a student fact template. Entity should create a database itself. I'm assuming it will crash without the table so running the create table query on the newly created database should do the trick.</p>

<h2>Some general notes regarding this project:</h2>
<p>The project doc said to use ASP.NET, however, for some reason I could only find ASP.NET Core when setting up Visual Studios. I'm assuming the difference is marginal and core is simply crossplatform.</p>
<p>I used an angular template to start the project. As such, there may be some unnecessary files.</p>
<p>I'm unsure if the format of the exported csv files matches the requirements for PIMS. I was unable to find documentation for this, so it simply exports the data in the order of appearance on the Student Fact Template documentation.</p>

<h2>Known issues:</h2>
<p>Validation is not perfect. The form will accept some invalid years but throw an exception when it tries to put it in the database.</p>
<p>It's not completely clear to me yet how exporting to browsers work. The get request kept returning errors, but when I refreshed the page, the file would download as expect. Instead of logging the "error" I just refresh the page and it functions fine.</p>

<h2>Areas of improvement:</h2>
<p>The app could do with more feedback to the user about the state of the submitted form. The validation is done client-side to give validation feedback, but no information is returned about the actual submission to the database.</p>
