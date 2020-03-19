Feature: AddNumbersFrom Excel

Scenario: Add numbers from Excel
	When I get numbers from "Excel"
	And I calculate their sum
	Then I verify the sum is 17

Scenario: Add numbers from DB
	When I get numbers from "DB"
	And I calculate their sum
	Then I verify the sum is 17

Scenario: Add numbers from Parameters
	When I add "10" and "7"
	And I calculate their sum
	Then I verify the sum is 17
