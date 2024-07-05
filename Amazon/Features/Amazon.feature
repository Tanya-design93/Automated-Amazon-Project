Feature: Amazon

Scenario: User searches for an Amazon item
	Given user navigates to Amazon.ca
	And user types shampoo in the search bar
	When the user preses the search button
	Then some results should appear


Scenario: User adds item to the cart
	Given user navigates to Amazon.ca
	And user types shampoo in the search bar
	When the user preses the search button
	And a user scrolls down to the needed item
	And the user clicks on the item
	When the user clicks the "Add to Cart" button
	Then the item should be added to the cart


	Scenario: User seaching for another item
	Given user navigates to Amazon.ca
	And clicks on the home button on the home tab
	When the user clicks on the vacuums
	And a user clicks on the carpet option
	Then the item should be a vacuum 