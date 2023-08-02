Feature: SkillsFeature

As a Seller user, I would like to update my skills for my profile 
so that people looking for some skills can look into my profile
Note: To Create Step defenitions for newly added features, click on go to definition and copy the given code and paste in step definitions

Scenario:1-Add Skills
	Given I logged into SellerProfile application
	When  I click on SkillsTab
	When  I Create the '<skillName>','<skillLevel>'
	Then  I added Skills.
	Then  I am able to see '<skillName>','<skillLevel>'

Examples: 
	| SkillName    | SkillLevel   |
	| SQL          | Beginner     |
	| Oracle       | Intermediate |
	| API          | Expert       |
	| Selenium     | Beginner     |
	| Data Analyst | Expert       |

Scenario: 2-Edit Skills
	Given I logged into the SellerProfile applictaion
	When  I edit the Skills
	And   I update the '<SkillName>'  
	Then  I am able to see the Updated Skill name '<SkillName>'

Scenario: 3-Existing Skill
	Given I log into the SellerProfile application
	When  I Recreate the duplicate '<SkillName>','<SkillLevel>'
	Then  I click on Add again
	Then  I am able to see validation message

Scenario: 4-Delete Skills 
	Given I logged into a SellerProfile application
	When  I delete the skills '<SkillName>' 
	Then  I am unable to see the deleted skill

Scenario: 5-Cancel Skill
	Given I logged into the SellerProfile application
	When  I click on SkillsTab
	And   I ReAdd the '<SkillName>','<SkillLevel>'
	And   I click on Cancel 
	Then  I am able to see the <SkillName> is not added

Scenario: 6-Invalid SkillName
	Given I logged in as a SellerProfile application	
	When  I Add the invalid '<SkillName>','<SkillLevel>'
	Then  I click on Add 
	Then  I am able to see the validation message

Scenario: 7-Invalid SkillLevel
	Given I logged in to SellerProfile application
	When  I donot Add the '<SkillLevel>'
	Then  I click on Add 
	Then  I am able to see the Popup message




	


	
	