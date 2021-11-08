Feature: Profile
	As a seller I would like to add my all details in my profile 
	So that others can my fully completed profile

#Name update
@mytag
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
#
# 
#@Languages
#Scenario: Test 05 Add language succcessfully
#	Given I am in my Profile page
#	And Seller select "Language" tab
#	When Seller select "More than $1000 per month" as earn target
#	Then Pop up massage displayed as "Availability updated"