Feature: REQ-UI- 07 Error page tests

@P1
Scenario: When I click on the Error button, I should get a 404 HTTP response code
	Given the user is navigated to the site
	When the user clicks the Error button in the header
	Then the user should be navigated to Error page 404