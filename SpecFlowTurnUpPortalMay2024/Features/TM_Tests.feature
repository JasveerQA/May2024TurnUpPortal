Feature: TurnUp Portal
This feature file contains tests for create, edit and delete TM record scenarios


Scenario: Verify user is able to create a TM record
	Given user logs into turnup portal
	And user navigates to the home page
	When user creates a TM record
	Then new TM record should be created successfully


	