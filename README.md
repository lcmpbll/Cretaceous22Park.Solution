# _Cretaceous Park Api_

#### By _Liam Campbell_



#### _A C# based API That lists animals found in Cretaceous Park_

## Table of Contents

[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

## Technologies Used

* _C#_
* _.NET_
* _Swagger_
* _XML_
* _SQL Workbench_
* _Entity Framework_
* _MVC_


---
## Description
_This API lists the qualities of the animals found in Cretaceous Park. The returned list can be curated by:_
* _Gender_
* _Name_
* _Species_
* _Age_




---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/lcmpbll/Cretaceous22Park
<li>Open a shell program and navigate to your desktop.
<li>Clone the repository for this project using the "git clone" command and including the copied URL.
<li>While still in the shell program, navigate to the root directory of the newly created file named "CretaceousPark.Solution".
<li>From the root directory, navigate to the "CretaceousPark" directory.
<li>Move onto "SQL Workbench" instructions below to re-create database necessary to run this project.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "CretaceousPark" directory of the project*  
   <pre>CretaceousPark.Solution
   └── CretaceousPark
    └── appsetting.json</pre>
<li> Insert the following code** : <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=cretaceous_park;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>Once "appsettings.json" file has been created, navigate back to SQL Workbench.


</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>CretaceousPark.Solution
   └── <strong>CretaceousPark</strong></pre>

Run `$ dotnet restore` in the console.<br>
Run `$ dotnet database update` in the console.<br>
Run `$ dotnet run` in the console
* _To view more information view localhost:[yourlocalhost]/index.html_
* _Additional information in JSon can also be viewed at https://localhost:[yourlocalhost]/swagger/v1/swagger.json
</details>

<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* Any known bugs

## License

_Feel free to reach out via [Github](github.com.lcmpbll) to provide feedback on this project or to view my other projects._

[Copyright](/LICENSE) (c) _07-28-2022_ _Liam Campbell_
