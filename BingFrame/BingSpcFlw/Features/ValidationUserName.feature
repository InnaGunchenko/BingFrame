Feature: ValidationUserNameFeature

	Scenario Outline: Check validation name
	Given I have navigated to Bing page
	And I click SignIn on Bing
	When I enter login details in UserInput and click Next on Bing for <userName>
    Then I can see the validation error message on ErrorMessage on Bing

	Examples:
	| userName	|
	| gooines	|
	| bing		|