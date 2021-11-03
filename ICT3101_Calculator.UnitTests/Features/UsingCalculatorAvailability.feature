Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

@MTBF
Scenario: Calculating MTBF
Given I have a calculator
When I have entered "200" and "10" into the calculator and press MTBF
Then the availability result should be "210"

@Availability
Scenario: Calculating Availability
Given I have a calculator
When I have entered "200" and "210" into the calculator and press Availability
Then the availability result should be "95.2"

@Availability
Scenario: Calculating Availability with negative hours
Given I have a calculator
When I have entered "<value1>" and "<value2>" into the calculator and press Availability
Then Then the error '<value3>' should be raised
	Examples:
	|value1 |value2 |value3 |
	|-200	|10		|Value cannot be lesser or equals 0|
	|-10	|-200	|Value cannot be lesser or equals 0|


@MTBF
Scenario: Calculating MTBF with negative hours
Given I have a calculator
When I have entered "<value1>" and "<value2>" into the calculator and press MTBF
Then Then the error '<value3>' should be raised
	Examples:
	|value1 |value2 |value3 |
	|-200	|10		|Value cannot be lesser or equals 0|
	|-10	|-200	|Value cannot be lesser or equals 0|
