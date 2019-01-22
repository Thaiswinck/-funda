Feature: Search between values
	To avoid failures
	As a quality analyst
	I want to search on the site between differents combinations of values


Background: 
Given I have data mass for sale and for rent 
	And I have entered on the Funda homepage

#For Sale#
Scenario: For Sale - Default From value
	Given I select the navigation item For Sale
	Then I have a dropdown field called From with default value ' € 0'


Scenario: For Sale - Default To value
	Given I select the navigation item For Sale
	Then I have a dropdown field called To with default value 'No limit'


Scenario: For Sale - List of From values
	Given I select the navigation item For Sale
	When I click on the dropdown fiel called From
	Then I have on the dropdown field called From the options
	| Options     |
	| Other       |
	| € 0         |
	| € 50,000    |
	| € 75,000    |
	| € 100,000   |
	| € 125,000   |
	| € 150,000   |
	| € 175,000   |
	| € 200,000   |
	| € 225,000   |
	| € 250,000   |
	| € 275,000   |
	| € 300,000   |
	| € 325,000   |
	| € 350,000   |
	| € 375,000   |
	| € 400,000   |
	| € 450,000   |
	| € 500,000   |
	| € 550,000   |
	| € 600,000   |
	| € 650,000   |
	| € 700,000   |
	| € 750,000   |
	| € 800,000   |
	| € 900,000   |
	| € 1,000,000 |
	| € 1,250,000 |
	| € 1,500,000 |
	| € 2,000,000 |

	Scenario: For Sale - List of To values
	Given I select the navigation item For Sale
	When I click on the dropdown fiel called To
	Then I have on the dropdown fiel called To the options
	| Options     |
	| Other       |
	| € 50,000    |
	| € 75,000    |
	| € 100,000   |
	| € 125,000   |
	| € 150,000   |
	| € 175,000   |
	| € 200,000   |
	| € 225,000   |
	| € 250,000   |
	| € 275,000   |
	| € 300,000   |
	| € 325,000   |
	| € 350,000   |
	| € 375,000   |
	| € 400,000   |
	| € 450,000   |
	| € 500,000   |
	| € 550,000   |
	| € 600,000   |
	| € 650,000   |
	| € 700,000   |
	| € 750,000   |
	| € 800,000   |
	| € 900,000   |
	| € 1,000,000 |
	| € 1,250,000 |
	| € 1,500,000 |
	| € 2,000,000 |
	| No limit    |

Scenario: For Sale - Find places between two values
	Given I select the navigation item For Sale
	And I fill the field Location with value '<Place>'
	And I select the field From with value '<From>'
	And I select the field To with value '<To>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <From> <To> <Place>
	| From | To       | Place     |
	| 50   | 100      | Amsterdam |
	| 0    | No limit | Amsterdam |
	| 50   | No Limit | Amsterdam |
	| 0    | 100      | Amsterdam |

Scenario: For Sale - Find places between other values
	Given I select the navigation item For Sale
	And I fill the field Location with value '<Place>'
	Then I select the field From with Other value
	And  I fill the field From with the value '<FromOtherValue>'
	And I select the field To with Other value
	And I fill the field To with the value '<ToOtherValue>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <FromOtherValue> <ToOtherValue> <Place>
	| Place     | FromOtherValue | ToOtherValue    |
	| Amsterdam | 20             | 1000000         |


#For rent#
Scenario: For Rent - Default From value 
	Given I select the navigation item For Rent
	Then I have a dropdown field called From with default value '€ 0'

Scenario: For Rent - Default To value
	Given I select the navigation item For Rent
	Then I have a dropdown field called To with default value 'No limit'

Scenario: For Rent - List of From values
	Given I select the navigation item For Rent
	When I click on the dropdown fiel called From
	Then I have on the dropdown field called From the options
	| Options     |
	| Other       |
	| € 0         |
	| € 50,000    |
	| € 75,000    |
	| € 100,000   |
	| € 125,000   |
	| € 150,000   |
	| € 175,000   |
	| € 200,000   |
	| € 225,000   |
	| € 250,000   |
	| € 275,000   |
	| € 300,000   |
	| € 325,000   |
	| € 350,000   |
	| € 375,000   |
	| € 400,000   |
	| € 450,000   |
	| € 500,000   |
	| € 550,000   |
	| € 600,000   |
	| € 650,000   |
	| € 700,000   |
	| € 750,000   |
	| € 800,000   |
	| € 900,000   |
	| € 1,000,000 |
	| € 1,250,000 |
	| € 1,500,000 |
	| € 2,000,000 |

	Scenario: For Rent - List of To values
	Given I select the navigation item For Rent
	When I click on the dropdown field called To
	Then I have on the dropdown field called To the options
	| Options     |
	| Other       |
	| € 50,000    |
	| € 75,000    |
	| € 100,000   |
	| € 125,000   |
	| € 150,000   |
	| € 175,000   |
	| € 200,000   |
	| € 225,000   |
	| € 250,000   |
	| € 275,000   |
	| € 300,000   |
	| € 325,000   |
	| € 350,000   |
	| € 375,000   |
	| € 400,000   |
	| € 450,000   |
	| € 500,000   |
	| € 550,000   |
	| € 600,000   |
	| € 650,000   |
	| € 700,000   |
	| € 750,000   |
	| € 800,000   |
	| € 900,000   |
	| € 1,000,000 |
	| € 1,250,000 |
	| € 1,500,000 |
	| € 2,000,000 |
	| No limit    |


Scenario: For Rent - Find places between two values
	Given I select the navigation item For Rent
	And I fill the field Location with value '<Place>'
	And I select the field From with value '<From>'
	And I select the field To with value '<To>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <From> <To> <Place>

	| From | To    | Place     |
	| 50   | 100      | Amsterdam |
	| 0    | No limit | Amsterdam |
	| 50   | No Limit | Amsterdam |
	| 0    | 100      | Amsterdam |

Scenario: For Rent - Find places between other values
	Given I select the navigation item For Rent
	And I fill the field Location with value '<Place>'
	Then I select the field From with Other value
	And  I fill the field From with the value '<FromOtherValue>'
	And I select the field To with Other value
	And I fill the field To with the value '<ToOtherValue>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <FromOtherValue> <ToOtherValue> <Place>
	| Place     | FromOtherValue | ToOtherValue |
	| Amsterdam | 20             | 1000000         |

