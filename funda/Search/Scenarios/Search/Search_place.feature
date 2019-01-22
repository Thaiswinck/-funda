Feature: Search by places
	To avoid failures
	As a quality analyst
	I want to search on the site for differents places for Sale, for rent, in newly built, recreation and all Europe


Background: 
Given I have a complet data mass
And I have entered on the Funda homepage

#For Sale
Scenario: For Sale - Find places in differents locations
	Given I select the navigation item For Sale
	And I fill the field Location with value '<Place>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place>
	| Place   |
	| Bussum  |
	| Germaan |

Scenario: For Sale - Last search
	Given I select the navigation item For Sale
	And I fill the field Location with value ' '
	And I click on the button Search
	When I back on the Funda homepage
	Then I have a field called ' ' with the value ' '

#For Rent#
Scenario: For Rent - Find places in differents locations
	Given I select the navigation item For Rent
	And I fill the field Location with value '<Place>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place>
	| Place   |
	| Bussum  |
	| Germaan |

Scenario: For Rent - Last search
	Given I select the navigation item For Rent
	And I fill the field Location with value ' '
	And I click on the button Search
	When I back on the Funda homepage
	Then I have a field called ' ' with the value ' '

#Newly Built#
Scenario: Newly Built - Find places in differents locations
	Given I select the navigation item Newly Built
	And I fill the field Location with value '<Place>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place>
	| Place   |
	| Bussum  |
	| Germaan |

Scenario: Newly Built - Last search
	Given I select the navigation item Newly Built
	And I fill the field Location with value ' '
	And I click on the button Search
	When I back on the Funda homepage
	Then I have a field called ' ' with the value ' '

#Recreation#
Scenario: Recreation - Find places in differents locations
	Given I select the navigation item Recreation
	And I fill the field Location with value '<Place>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place>
	| Place   |
	| Bussum  |
	| Germaan |

Scenario: Recreation - Last search
	Given I select the navigation item Recreation
	And I fill the field Location with value ' '
	And I click on the button Search
	When I back on the Funda homepage
	Then I have a field called ' ' with the value ' '

#Europe#
Scenario: Europe - Find places in differents countries
	Given I select the navigation item Europe
	And I fill the field Location with value '<Country>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place>
	| Country  |
	| Bulgaria |
	| Belgium  |
	| France   |

Scenario: Europe - Last search
	Given I select the navigation item Europe
	And I fill the field Location with value ' '
	And I click on the button Search
	When I back on the Funda homepage
	Then I have a field called ' ' with the value ' '









