Feature: Navigation features

@P1
Scenario: Home button navigation REQ-UI-03 from the home page
	Given the user is navigated to the site
	When the user clicks the Home button in the header
	Then the user should be navigated to the Home page

@P1
Scenario: Home button navigation REQ-UI-03 from the form page
	Given the user is navigated to the site
	When the user clicks the Form button in the header
		And the user clicks the Home button in the header
	Then the user should be navigated to the Home page
