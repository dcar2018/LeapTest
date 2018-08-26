Feature: SalaryCalculate
	As an employee 
	I would like to know my pay for the week

@firefox
Scenario Outline: Salary details 
	Given I enter my time sheet <details>
	When I select submit button
	Then the application accepts the values successfully
	And I can see my salary details and <verify>
	Examples:
	| details                 | verify                           |
	| John;20;2;2;2;2;2;1;3   | Name=John;Hours=14;Salary=350    |
	| Mary;20.5;2;2;2;2;2;1;3 | Name=Mary;Hours=14;Salary=358.75 |

