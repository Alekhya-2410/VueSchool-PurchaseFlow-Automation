Feature: Verifying the pricing work flow on Vuebundle

A short summary of the feature

Scenario: Verifying the pricing work flow on Vuebundle
	Given a user launches the Vuebundle application to purchase bundles
	When user is on home page and navigates to build your own Vue bundle
	And user adds the multiple bundles into cart and click on review order
	Then user verifies the total amount and unlocked additional discount in the review order


Scenario: Verifying the pricing work flow on Vuebundle with South Africa discount
	Given a user launches the Vuebundle application to purchase bundles
	When user navigates to we support developers from South Africa and click on activate twenty percent discount
	And user is on home page and navigates to build your own Vue bundle
	And user adds the multiple bundles into cart and click on review order
	Then user verifies the total amount and unlocked additional discount in the review order
	

Examples:
	| Scenario |
	| 1        |










