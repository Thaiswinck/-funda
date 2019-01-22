Feature: Enable options on the Navigation block
	To avoid failures
	As a quality analyst
	I want to check all the enabled fields on the navigation block

Background: 
Given I have entered on the Funda homepage
And I have never visited the Funda website before

#For Sale#
Scenario: For Sale - enable fields
	Given I select the navigation item For Sale
	Then I see an autocomplete field to write the Location by city neighborhood or address
	And I see a dropdown field to select the ray
	And I see a dropdown field to select the price From
	And I see a dropdown field to select the price To
	And I see a button Search
	But I do not see the label with the Last Search
	And I do not see a dropdown field to select the Country

#For Rent#
Scenario: For Rent - enable fields
	Given I select the navigation item For Rent
	Then I see an autocomplete field to write the Location by city neighborhood or address
	And I see a dropdown field to select the ray
	And I see a dropdown field to select the price From
	And I see a dropdown field to select the price To
	And I see a button Search
	And I see the Last Search label with the default text ' '
	But I do not see a dropdown field to select the Country


#Newly Built#
Scenario: Newly Built - enable fields
	Given I select the navigation item Newly Built
	Then I see an autocomplete field to write the Location by city neighborhood or address
	And I see a dropdown field to select the ray
	And I see a button Search
	And I see the Last Search label with the default text ' '
	But I do not see a dropdown field to select the price From
	And I do not see a dropdown field to select the price To
	But I do not see a dropdown field to select the Country


#Recreation#
Scenario: Recreation - enable fields
	Given I select the navigation item Recretion
	Then I see an autocomplete field to write the Location by city neighborhood or address
	And I see a dropdown field to select the ray
	And I see a button Search
	But I do not see a dropdown field to select the price From
	And I do not see a dropdown field to select the price To
	And I do not see the label with the Last Search
	And I do not see a dropdown field to select the Country


#Europe#
Scenario: Europe - enable fields
	Given I select the navigation item Europe
	Then I have an dropdown field to select the Country
	And I have a dropdown field to select the ray
	And I have a button Search
	But I do not see a dropdown field to select the price From
	And I do not see a dropdown field to select the price To
	And I do not see the label with the Last Search
	And I do not see an autocomplete field to write the Location
