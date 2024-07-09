Feature: Amazon

Scenario: User searches for an Amazon item
	And user types shampoo in the search bar
	When the user preses the search button
	Then some results should appear


Scenario: User adds item to the cart
	And user types shampoo in the search bar
	When the user preses the search button
	And a user scrolls down to the needed item
	And the user clicks on the item
	When the user clicks the "Add to Cart" button
	Then the item should be added to the cart


	Scenario: User seaching for another item
	And clicks on the home button on the home tab
	When the user clicks on the vacuums
	And a user clicks on the carpet option
	And clicks on the first item that appears
	Then the item should be a vacuum 


	Scenario: User creating a wish list
	And the clicks on the Account&Lists button
	And the user clicks on the Lists
	When the user clicks on the Create a List
	And the user changes the list name on Home Decor
	And the user clicks on the Create LIst button 
	Then the new list appears