Feature: Login
	Check if login functionality works

@mytag
Scenario: Login user as Adminitrastor
	Given I navigate to the application
	And I click to login link
	And I enter username and password
	| UserName | Password |
	| admin    | password |
	And I click Login button
	Then I should see user logged into the application