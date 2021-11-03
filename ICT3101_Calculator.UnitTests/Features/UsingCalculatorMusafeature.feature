Feature: UsingCalculatorMusafeature

Calculating the failure intensity and the number of expected failures using MUSA log model 

@MUSA

Scenario: calculate failure intensity using MUSA Log model
Given I have a calculator 
When I enter the failure intensity decay "0.02" and and the initial failure intensity "10" and the average number of failures "50"
Then the result of failure intensity is "3.68"


Scenario: calculate the number of expected failures using MUSA Log model
Given I have a calculator 
When I enter the failure intensity decay "0.02" and and the initial failure intensity "10" and the average number of failures "50" and the number of cpu Hours "10"
Then the result of expected failure is "55"
