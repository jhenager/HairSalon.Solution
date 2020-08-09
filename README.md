**<h1 align = "center"> Hair Salon**

**<h3 align="center">Helping salon owners keep track of their clients and stylists**

**ABOUT**

</p>

_This Hair salon application is designed to help salon owners keep track of their clients and which stylists they prefer to see.  This app utilizes razor c# asp.net core mvc with entity framework using the CRUD naming convention._


## **REQUIREMENTS**

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)

## **SETUP**


copy this url to clone this project to your local system:
```html
https://github.com/jhenager/HairSalon.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link.

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd HairSalon
```

Then, install the necessary packages with the following command
```js 
dotnet restore 
```

Finally, you can start the program with this command.
```js 
dotnet run 
```
## **Setting up the database**
<br>
Next we will need to setup our MySql database for the application to work.
<br>
One method is to directly import the 'james_henager.sql' file included in the repo to MySQL workbench.
<br>
The other option is to open MySql Workbench and select "Create a new Sql Tab for Executing Queries" at the very top left of the page. Then paste this information onto the page:
<br>

```
CREATE DATABASE `james_henager` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;

USE DATABASE 'james_henager';

CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `ClientName` varchar(255) NOT NULL,
  `StylistId` int(11) DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistName` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```
#### **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._


<br>

<br>

## **PROTECTING YOUR DATA**

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: Add the following to your .gitignore file (this protects your sensitive data). 
**DO NOT PROCEED UNTIL YOU DO!**


```
node_modules/
.DS_store
dist/
appsettings.json
bin/
obj/
```

#### Step 3: **To commit your .gitignore file enter the following commands**

```js
git add .gitignore
```
```js
git commit -m "protect data"
```


## **QUESTIONS AND CONCERNS**

_Questions, comments and concerns can be directed to James Henager (jameschenager@gmail.com)_

<br>

## **Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>
