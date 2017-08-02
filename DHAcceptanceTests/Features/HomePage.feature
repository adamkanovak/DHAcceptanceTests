﻿Feature: HomePage related UI element checks

@P3
Scenario: REQ-UI-09 The following text should be visible on the Home page in <h1> tag "Welcome to the Docler Holding QA Department"
	Given the user is navigated to the site
	When the user is on the Home page
	Then the "Welcome to the Docler Holding QA Department" text should be displayed in h1 tag

@P3
Scenario: REQ-UI-10 The following text should be visible on the Home page in <p> "This site is dedicated to perform some exercises and demonstrate automated web testing"
	Given the user is navigated to the site
	When the user is on the Home page
	Then the "This site is dedicated to perform some exercises and demonstrate automated web testing." text should be displayed in p tag