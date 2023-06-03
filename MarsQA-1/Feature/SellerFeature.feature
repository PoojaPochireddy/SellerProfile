Feature: SellerFeature

As a Seller user, I would like to update my skills for my profile 
so that people looking for some skills can look into my profile
Note: To Create Step defenitions for newly added features, click on go to definition and copy the given code and paste in step definitions

Scenario: 1 User adds Skills to the profile
	Given User is logged into SellerProfile application
	When User adds new Skill
	Then Newly added Skill is displayed in the Skills list on user profile


Scenario: 2 User edits newly added skill
	Given User is logged into SellerProfile application 
	When User edits newly added Skill
	Then Skill is edited successfully 

Scenario: 3 User deletes newly added skill 
	Given User is logged into SellerProfile application 
	When User deletes newly added Skill
	Then Language is deleted successfully