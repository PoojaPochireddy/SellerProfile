Feature: Languages

As a Seller user, I would like to update my Languages for my profile 
so that people looking for some Languages can look into my profile
Note: To Create Step definitions for newly added features, click on go to definition and copy the given code and paste in step definitions

Scenario:1-Add Language
	Given I logged into Seller Profile application
	When  I am on the User profile page
	Then  I Create '<languageName>','<languageLevel>'
	Then  I added and able to see Language '<languageName>','<languageLevel>'

Examples: 
	| LanguageName | LanguageLevel   |
	| Telugu       | Basic           |
	| English      | Conversational  |
	| Kannada      | Fluent          |
	| Hindi        | Native/Bilingual|

Scenario: 2-Edit Language
	Given I logged into the Seller Profile application
	When  I edit and update the Language 
	Then  I am able to see an Updated Language name '<languagename>'

Scenario: 3-Existing Language
	Given I logged into the Seller Profile application
	When  I will add the duplicate '<languageName>','<languagelevel>'
	And   I click on Add again
	Then  I am able to see the validation message

Scenario: 4-Delete Language 
	Given I logged into the Seller Profile application
	When  I delete the Language '<languageName>' 
	Then  I am unable to see the deleted Language

Scenario: 5-Cancel Language
	Given I logged into the Seller Profile application
	When  I ReAdd '<languageName>','<languagelevel>'
	Then  I click on cancel 
	Then  I am not able to see the '<languageName>'

Scenario: 6-Blank LanguageName
	Given I logged into the Seller Profile application
	When  I Add the '<languageName>'
	Then  I clicked on Add 
	Then  I am able to see the pop up validation message

Scenario: 7-Blank LanguageLevel
	Given I logged into the Seller Profile application
	When  I add only '<languagelevel>'
	Then   I clicked on AddButton
	Then  I am able to see the pop up validation message






	
