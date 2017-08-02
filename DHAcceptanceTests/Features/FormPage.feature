Feature: Tests related to the form page

@P1
Scenario: REQ-UI-11 On the Form page, a form should be visible with one input box and one submit button
	Given the user is navigated to the site
	When the user clicks the Form button in the header
	Then one input box should be visible
		And one submit button should be visible

@P1
Scenario Outline: REQ-UI-12 On the Form page, if you type value; the input field and submit the form, you should get redirect to the Hello page, and the following text should appear: result
	Given the user is navigated to the site
	When the user clicks the Form button in the header
		And the user types the <value> into the input field
		And the user clicks the Go! button
	Then the user should be redirected to the Hello page
		And the <result> text should be displayed
	
	Examples: 
	| value   | result         |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |

@P3
Scenario: REQ-UI-06 When I click on the Form button, it should turn to active status
	Given the user is navigated to the site
	When the user clicks the Form button in the header
	Then the Form button should be active in the header
		And the Home button should not be active in the header 