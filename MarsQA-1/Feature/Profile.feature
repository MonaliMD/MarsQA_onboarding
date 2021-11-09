Feature: Profile
	As a seller I would like to add my all details in my profile 
	So that others can my fully completed profile


@mnameUpdate
Scenario: Test 01 Update my First Name and Last Name Successfully
	Given I am in my Profile page
	When Seller enter '<First Name>' and '<Last Name>' 
	Then Name sold be displayed ad "Ann Johns"
Examples: 
	| First Name | Last Name |
	| Ann | Johns |

@nameUpdate
Scenario: Test 02 Error should be pop up when frist name not entered
	Given I am in my Profile page
	When Seller enter First Name as "Mark" and empty the last name feild
	Then Error pop up should be displayed as First name and last name are required
Examples: 
	| First Name | 
	| Mark | 

#@nameUpdate
#Scenario: Test 03 Error should be pop up when last name not entered
#	Given I am in my Profile page
#	When Seller enter Last Name as "Johns" and empty the first name feild
#	Then Error pop up should be displayed as "First name and last name are required"
#
#@nameUpdate
#Scenario: Test 03 Error should be pop up when last name and first name not entered
#	Given I am in my Profile page
#	When Seller enter First Name and Last Name as empty feilds
#	Then Error pop up should be displayed as "First name and last name are required"
#
#@availability
#Scenario: Test 04 Add seller availability type succcessfully
#	Given I am in my Profile page
#	When Seller select "part time" as availability
#	Then Pop up massage displayed as "Availability updated"
#
#@availability
#Scenario: Test 05 Add seller availability type succcessfully
#	Given I am in my Profile page
#	When Seller select "full time" as availability
#	Then Pop up massage displayed as "Availability updated"
#
#@hours
#Scenario: Test 06 Add seller hours type succcessfully
#	Given I am in my Profile page
#	When Seller select "Less than 30hours a week" as hours
#	Then Pop up massage displayed as "Availability updated"
#
#@hours
#Scenario: Test 07 Add seller hours type succcessfully
#	Given I am in my Profile page
#	When Seller select "More than 30hours a week" as hours
#	Then Pop up massage displayed as "Availability updated"
#
#@hours
#Scenario: Test 08 Add seller hours type succcessfully
#	Given I am in my Profile page
#	When Seller select "As needed" as hours
#	Then Pop up massage displayed as "Availability updated"
#
#@earnTarget
#Scenario: Test 09 Add seller earn target succcessfully
#	Given I am in my Profile page
#	When Seller select "Less than $500 per month" as earn target
#	Then Pop up massage displayed as "Availability updated"
#
#@earnTarget
#Scenario: Test 10 Add seller earn target succcessfully
#	Given I am in my Profile page
#	When Seller select "Between $500 and $1000 per month" as earn target
#	Then Pop up massage displayed as "Availability updated"
#
#@earnTarget
#Scenario: Test 11 Add seller earn target succcessfully
#	Given I am in my Profile page
#	When Seller select "More than $1000 per month" as earn target
#	Then Pop up massage displayed as "Availability updated"

 

@Languages @add
Scenario: Test 12 Add a languages succcessfully
	Given I am in my Profile page
	When Seller add language as "English" and choose level as fluent
	Then Pop up massage displayed as English has been added to your languages

#@Languages @add_same_language
#Scenario: Test 13 Error message when add same languge agian
#	Given I am in my Profile page
#	When Seller add language as "English" and choose level as fluent
#	Then Pop up massage displayed as Duplicated data

#@Languages @Edit
#Scenario: Test 14 Edit languages succcessfully
#	Given I am in my Profile page
#	When Seller edit his langauge as "Maori" intead of English
#	Then Pop up massage displayed as Maori has been updated to your languages
#
#@Languages @Delete
#Scenario: Test 15 Delete languages succcessfully
#	Given I am in my Profile page
#	When Seller delete his Maori language from the list
#	Then Pop up massage displayed as Maori has been deleted from your languages
#
#@Skills @add
#Scenario: Test 16 Add skills succcessfully
#	Given I am in my Profile page
#	When Seller click on skills tab
#	And Seller add his skill as "Testing" 
#	And Seller select level as intermediate
#	Then Pop up massage displayed as Testing has been updated to your skills
#
#@Languages @add_same_language
#Scenario: Test 17 Error message when add same skill agian
#	Given I am in my Profile page
#	When Seller click on skills tab
#	And Seller add language as "Testing"
#	And Seller choose level as intermediate
#	Then Pop up massage displayed as This skill is already exist in your skill list.
#
#@Skills @edit
#Scenario: Test 18 Edit skills succcessfully
#	Given I am in my Profile page
#	When Seller click on skills tab
#	And Seller edit his skill as "Developmnet" instead of Testing 
#	Then Pop up massage displayed as Development has been updated to your skills
#
#
#@Skills @Delete
#Scenario: Test 19 Edit skills succcessfully
#	Given I am in my Profile page
#	When Seller click on skills tab
#	And Seller delete his skill Developmnet from the list
#	Then Pop up massage displayed as Development has been deleted
#
#@Education @Add
#Scenario: Test 20 Add education with all valid data
#	Given I am in my Profile page
#	When Seller click on education tab
#	And Seller add his education university as "SLIIT"
#	And Seller select country as Sri Lanka and title as Associate
#	And Seller add degree as "Information Technology"
#	And Seller select education year as 2016
#	Then Pop up massage displayed as Education has been added
#
#@Education @Edit
#Scenario: Test 20 Edit education data
#	Given I am in my Profile page
#	When Seller click on education tab
#	And Seller edit his education university as "NIBM"
#	Then Pop up massage displayed as Education as been updated
#
#@Education @Edit
#Scenario: Test 20 delete education details
#	Given I am in my Profile page
#	When Seller click on education tab
#	And Seller delete his education raw with university as NIBM
#	Then Pop up massage displayed as Education entry successfully removed