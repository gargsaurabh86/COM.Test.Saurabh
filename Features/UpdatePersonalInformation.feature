Feature: UpdatePersonalInformation
	Update personal information first name in Myaccount

@mytag
Scenario: User able to update first name successfully
	Given I am on your personal information page
	And I enter new valid first name
	And I enter current and new password
	When I save it
	Then Personal information updated successfully message is displayed