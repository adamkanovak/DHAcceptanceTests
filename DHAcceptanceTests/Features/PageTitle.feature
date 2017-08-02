Feature: PageTitle, company logo tests for all pages

@P2 @failing
Scenario Outline: REQ-UI-01 The Title should be "UI Testing Site" on every site
	Given the user is navigated to the site
	When the user clicks the <Header> button in the header
	Then the page title should be UI Testing Site
		And the company logo should be displayed
	
	Examples: 
	| Header |
	| Home   |
	| Form   |
	| Error  |

@P2 @failing
Scenario Outline: REQ-UI-02 The Company Logo should be visible on every site
	Given the user is navigated to the site
	When the user clicks the <Header> button in the header
	Then the company logo should be displayed
	
	Examples: 
	| Header |
	| Home   |
	| Form   |
	| Error  |
