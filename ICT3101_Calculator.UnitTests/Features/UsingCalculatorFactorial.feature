Feature: UsingCalculatorFactorial
	Simple calculator for performing factorial claculation

@factorial
Scenario: Factorial with zero
	Given I have a calculator
	When I have entered "5" into the calculator
	Then the result should be 120

@factorial
Scenario: Factorial with positive number
	Given I have a calculator
	When I have entered "0" into the calculator
	Then the result should be 1

@factorial
Scenario: Factorial with negative number
	Given I have a calculator
	When I have entered "-1" into the calculator
	Then the error 'Please do not enter negative values' should be raised
