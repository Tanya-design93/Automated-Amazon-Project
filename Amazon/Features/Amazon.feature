Feature: Amazon

Scenario: User searches for an Amazon item
	Given user navigates to Amazon.ca
	And user types shampoo in the search bar
	When the user preses the search button
	Then some results should appear