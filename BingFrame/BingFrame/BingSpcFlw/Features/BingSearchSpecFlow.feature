Feature: BingSearchSpecFlow

	Scenario: Bing Search - SpecFlow
	Given I have navigated to Bing page
	When I search for "SpecFlow" in SearchInput on Bing
	And select "SpecFlow" from SerachResultSpecFlow on Bing
	Then I am presented with the "SpecFlow - Binding Business Requirements to .NET Code" homepage Bing