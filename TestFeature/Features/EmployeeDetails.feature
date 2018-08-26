Feature: Employee Details
	As an employee 
	I would like to enter my timesheets accurately

@chrome
Scenario Outline: Employee Details validation
	Given I open employee details application
	When I enter values to my time sheet <details>
	And I select submit button
	Then the application validates my inputs <verify>
	Examples:
	| details                | verify |
	| John;abd;3;2;2;2;2;1;3 | Rate   |
	| ;10;3;2;2;2;2;1;3      | Name   |


