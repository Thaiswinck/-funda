Feature: Search by Ray
	To avoid failures
	As a quality analyst
	I want to search on the site by differents Ray options

Background:

Given I have data mass for Sale, for rent, newly built and recreation
And I have entered on the Funda homepage

#For Sale#
Scenario: For Sale - Default Ray values
	Given I select the navigation item For Sale
	Then I have a dropdown field called Ray with default value ' ' 

Scenario: For Sale - List of Ray values
	Given I select the navigation item For Sale
	When I click on the dropdown fiel called ' '
	Then I have on the dropdown field called Ray the options
	| Options |
	| + 0 km  |
	| + 1 km  |
	| + 2 km  |
	| + 5 km  |
	| + 10 km |
	| + 15 km |

Scenario: For Sale - Find places for ray
	Given I select the navigation item For Sale
	And I fill the field Location with value '<Place>'
	And I select the field Ray with value ' '
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place> <Ray>

#For Rent#
Scenario: For Rent - Default Ray values
	Given I select the navigation item For Rent
	Then I have a dropdown field called '<>' with default value '<>' 

Scenario: For Rent - List of Ray values
	Given I select the navigation item For Rent
	When I click on the dropdown fiel called ' '
	Then I have the options '<Options>' on the dropdown field called ' '
	| Options |
	| + 0 km  |
	| + 1 km  |
	| + 2 km  |
	| + 5 km  |
	| + 10 km |
	| + 15 km |

Scenario: For Rent - Find places for ray
	Given I select the navigation item For Rent
	And I fill the field Location with value '<Place>'
	And I select the field Ray with value '<Ray>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place> <Ray>
	| Ray | Place     |
	| 0   | Amsterdam |
	| 1   | Amsterdam |
	| 5   | Amsterdam |
	| 15  | Amsterdam |
	
#Newly Built#
Scenario: Newly Built - Default Ray values
	Given I select the navigation item Newly Built
	Then I have a dropdown field called Newly Built with default value ' ' 

Scenario: Newly Built - List of Ray values
	Given I select the navigation item Newly Built
	When I click on the dropdown fiel called ' '
	Then I have on the dropdown field called Ray the options
	| Options |
	| + 0 km  |
	| + 1 km  |
	| + 2 km  |
	| + 5 km  |
	| + 10 km |
	| + 15 km |

Scenario: Newly Built - Find places for ray
	Given I select the navigation item Newly Built
	And I fill the field Location with value '<Place>'
	And I select the field Ray with value '<Ray>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place> <Ray>
	| Ray | Place     |
	| 0   | Amsterdam |
	| 1   | Amsterdam |
	| 5   | Amsterdam |
	| 15  | Amsterdam |

#Recreation#
Scenario: Recreation - Default Ray values
	Given I select the navigation item Recreation
	Then I have a dropdown field called Ray with default value '<>' 

Scenario: Recreation - List of Ray values
	Given I select the navigation item Recreation
	When I click on the dropdown fiel called ' '
	Then I have on the dropdown field called Ray the options
	| Options |
	| + 0 km  |
	| + 1 km  |
	| + 2 km  |
	| + 5 km  |
	| + 10 km |
	| + 15 km |

Scenario: Recreation - Find places for ray
	Given I select the navigation item Recreation
	And I fill the field Location with value '<Place>'
	And I select the field Ray with value '<Ray>'
	When I click on the button Search
	Then I should go to the page ''
	And I should see the same amount of results as DB <Place> <Ray>
	| Ray | Place     |
	| 0   | Amsterdam |
	| 1   | Amsterdam |
	| 5   | Amsterdam |
	| 15  | Amsterdam |



