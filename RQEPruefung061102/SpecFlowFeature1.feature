Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Hexint
	Given the number is "affe"
	When you convert it from hex to int
	Then the result should be 45054
	
	Scenario: octint
	Given the number is 11147
	When you convert it from oct to int
	Then the result should be 4711

	Scenario: binint
	Given the number is 1100
	When you convert it from bin to int
	Then the result should be 12