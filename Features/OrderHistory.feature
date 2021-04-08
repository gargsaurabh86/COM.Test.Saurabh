Feature: OrderHistory
	Simple calculator for adding two numbers

@mytag
Scenario: Place order for T-shirt and verify order details
	Given I add Tshirt to the cart
	And I place order successfully
	When I navigate to order history page
	And I view last order details
	Then order details should contain 'T-shirt' order