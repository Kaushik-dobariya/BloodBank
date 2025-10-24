/* Welcome to the FUSA bloodbank queries.  
   Remember, execute one query at a time to ensure proper functionality. */

--1. CRUDE PART --
--Create (Insert Data) not applicable cause we have an UI to do that--
/* INSERT INTO dbo.tbl_donors (Column1, Column2, ...)
VALUES (Value1, Value2, ...);

INSERT INTO dbo.tbl_users (Column1, Column2, ...)
VALUES (Value1, Value2, ...); */

--Read (Retrieve Data)-- --Read (Retrieve Data)-- --Read (Retrieve Data)-- --Read (Retrieve Data)--
/*Retrieve/show all the data from tables*/
SELECT * FROM dbo.tbl_donors;
SELECT * FROM dbo.tbl_users;

/*Retrive specific columns*/
SELECT donor_id, first_name, last_name FROM dbo.tbl_donors;
SELECT user_id, username, password FROM dbo.tbl_users;

/*Filter data with conditions*/
SELECT * FROM dbo.tbl_donors WHERE donor_id = '24'; --manualy data entered--
SELECT * FROM dbo.tbl_users WHERE user_id > 2025; --contains possible data entered--

/*Sort the data*/
SELECT * FROM dbo.tbl_donors ORDER BY donor_id ASC; -- ASCENDING
SELECT * FROM dbo.tbl_users ORDER BY user_id DESC; -- DESCENDING


--Update (***) not applicable cause we have an UI to do that--
/* UPDATE dbo.tbl_donors
SET Column1 = 'NewValue', Column2 = 'NewValue2'
WHERE ColumnName = 'Condition';

UPDATE dbo.tbl_users
SET Column1 = 'NewValue'
WHERE ColumnName = 'Condition'; */

--Delete (***) not applicable cause we have an UI to do that--
/* DELETE FROM dbo.tbl_donors WHERE ColumnName = 'Condition';
DELETE FROM dbo.tbl_users WHERE ColumnName = 'Condition'; */

/*DELETE FROM dbo.tbl_users WHERE user_id = '3';*/

--Delete all records (WARNING: DANGEROUS query, do not execute, I repeat DO NOT EXECUTE! pero cute ako, MEOW)--
/* DELETE FROM dbo.tbl_donors;
DELETE FROM dbo.tbl_users; */

--2.--/*ADVANCE QUERY*/
--count records--
SELECT COUNT(*) AS TotalDonors FROM dbo.tbl_donors;
SELECT COUNT(*) AS TotalUsers FROM dbo.tbl_users;

--find unique values--
SELECT DISTINCT donor_id FROM dbo.tbl_donors;
SELECT DISTINCT user_id FROM dbo.tbl_users;

--aggregate functions for SUM, AVERAGE, MINIMUM AND MAXIMUM--
/*SELECT SUM(donor_id) AS Total FROM dbo.tbl_donors;*/ --NOT APPLICABLE--
SELECT AVG(user_id) AS Average FROM dbo.tbl_users;
SELECT MIN(first_name) AS Minimum, MAX(blood_group) AS Maximum FROM dbo.tbl_donors; --SORT FROM SPECIFIC VALUE/DATA--


--joining tables--
/*inner join*/
SELECT u.*, d.*
FROM dbo.tbl_users u
INNER JOIN dbo.tbl_donors d ON u.user_id = d.donor_id;

/*left join*/
SELECT u.*, d.*
FROM dbo.tbl_users u
LEFT JOIN dbo.tbl_donors d ON u.user_id = d.donor_id;

/*Filtering with Wildcards*/
SELECT * FROM dbo.tbl_donors WHERE last_name LIKE 'D%'; -- Starts with A (can change from B to Z)--
/*SELECT * FROM dbo.tbl_users WHERE  last_name LIKE '%Z'; -- Ends with Z
SELECT * FROM dbo.tbl_donors WHERE ColumnName LIKE '%Middle%'; -- Contains "Middle"*/

--3.--/*TABLE MGMT like how the FUSASIS develop its TBL*/
EXEC sp_help 'dbo.tbl_donors';
EXEC sp_help 'dbo.tbl_users';


