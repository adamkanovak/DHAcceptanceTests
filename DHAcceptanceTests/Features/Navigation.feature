Feature: Navigation features

@P1
Scenario: REQ-UI-03 When I click on the Home button, I should get navigated to the Home page (from the home page)
	Given the user is navigated to the site
	When the user clicks the Home button in the header
	Then the user should be navigated to the Home page

@P1
Scenario: REQ-UI-03 When I click on the Home button, I should get navigated to the Home page (from the form page)
	Given the user is navigated to the site
	When the user clicks the Form button in the header
		And the user clicks the Home button in the header
	Then the user should be navigated to the Home page

@P1
Scenario: REQ-UI-05 When I click on the Form button, I should get navigated to the Form page (from the home page)
	Given the user is navigated to the site
	When the user clicks the Form button in the header
	Then the user should be navigated to the Form page

@P1
Scenario: REQ-UI-08 When I click on the UI Testing button, I should get navigated to the Home page (from the home page)
	Given the user is navigated to the site
	When the user clicks the UITestingButton button in the header
	Then the user should be navigated to the Home page

@P1
Scenario:REQ-UI-08 When I click on the UI Testing button, I should get navigated to the Home page (from the form page)
	Given the user is navigated to the site
	When the user clicks the Form button in the header
		And the user clicks the UITestingButton button in the header
	Then the user should be navigated to the Home page