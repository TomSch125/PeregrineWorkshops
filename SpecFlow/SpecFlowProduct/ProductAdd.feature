Feature: ProductCreate
	In order to sell a new product
	As a store manager
	I want to add a new product to the system

@tag1
Scenario: Product Added Successfully
	Given I am on the add product screen
		And I enter a product name of lemonaid
		And I enter a price of 3.50
		And I enter a desciption of "1 Litre Bottle"
	When I sumbit my product
	Then I should see the new product in the list of products
