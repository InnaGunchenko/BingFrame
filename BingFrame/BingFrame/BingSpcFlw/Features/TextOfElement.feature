Feature: TextOfElementFeature

@mytag
Scenario: Check element text
	Given I have navigated to Bing page
	Then I search element FooterList on Bing and check the text of the element
	| LinkName            |
	| Privacy and Cookies |
	| Legal               |
	| Advertise           |
	| About our ads       |
	| Help                |
	| Feedback            |