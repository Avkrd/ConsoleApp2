Feature: EntityFrameWorkBank
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Input data into the database through the console
	Given I have entered first
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
