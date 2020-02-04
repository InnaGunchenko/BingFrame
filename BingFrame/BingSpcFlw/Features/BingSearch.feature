Feature: BingSearchFeature

@mytag
Scenario: Bing should search and count result search
	Given I have navigated to Bing page
	And  I have navigated to page Bing on the element SearchInput and entered
	| SearchString         |
	| star wars episode vi |
	When I click on the search SearchInput on the page Bing
	Then I should be navigate to Bing page and count 10 elements SearchResultsOnRight