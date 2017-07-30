@P1
Feature: REQ-UI- 07 Error page tests

Scenario: The error button should navigate to Error page 404
	Given the user is navigated to the site
	When the user clicks the Error button in the header
	Then the user should be navigated to Error page 404