# About

Mandatory project for my databases course.
A simple C# Windows Forms application with the ability to manage parcels, buildings, owners, and their relations.
Only written requirements were given, the finished database schemas had to be in third normal form.
Needs a MySQL server.
Development had to be rushed in order to finish on time due to outside reasons, I'm not entirely happy how it turned out project structure wise, but it works.
The code is in English, but the user interface and data sets are in Hungarian.

# Setup


1. Create the database

Start your local MySQL server

Create a database named `ingatlanok`with default collation `utf8_hungarian_ci`, or

Run this command:

CREATE DATABASE `ingatlanok` COLLATE utf8_hungarian_ci 


2. Import the data

Import dbExport/ingatlanok.sql into `ingatlanok` database


3. Create `ingatlanos` user account

Run this command:

GRANT USAGE ON *.* TO `ingatlanos`@`%` IDENTIFIED BY PASSWORD '*171684DE57FC1A1B32BA8EFB764078108B1F8E86';
GRANT SELECT, INSERT, UPDATE, DELETE ON `ingatlanok`.* TO `ingatlanos`@`%`; 


4. Startup

Build the solution ad run it. (After reviewing the code)

-----------------------------------------------------------

Login information:

Admin login:

1111111111	adminadmin


Other users:

0123456789	asdasdasd	(Gipsz Jakab)
1123456789	12345678	(Lakatos Brendon)
1112345678	12345678	(Laci (A vállalkozó))
1111234567	12345678	(Teszt Elek)