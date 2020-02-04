Feature: SearchResultsOnRight

@mytag
Scenario: Search Results On Right
	Given I have navigated to Bing page
	And I search for "star wars episode vi" in SearchInput on Bing
	When I click on the search SearchInput on the page Bing
	Then I should be navigate to Bing page and count 8 elements SearchResultsOnRight
