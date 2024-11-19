﻿# Database_Converter
A minimized version of SQL Server Managment Studio where key  is to export database tables to .JSON, .XML, .TXT files.
Additionally, you can import .JSON, .XML, .TXT files to the system and they would upload to the database.
Other feature is to being able to directly send the table information from one database to another: MsSQL > MongoDB, MongoDB > SQLite.

Dev note: This is by no means a perfect system and there might be bugs and issues that I have not seen when creating yet.
To prevent this, most of the core functionalities have try/catch.

# How to setup
There is a setup file provided in the repository.

# Prerequisites
Only requirement would be is to have information in either files (.json, .xml, .txt) or in databases: MsSQL, SQLite, MongoDB.
I used: MongoDBCompass, SQL Server Managment Studio, SQLite during testing. 
For MsSQL specifically you must have login information. There is no Windows Authentication login feature.
