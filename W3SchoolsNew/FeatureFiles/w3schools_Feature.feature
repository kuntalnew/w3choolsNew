Feature: w3schools_Feature
	

@mytag
Scenario: Try it yourself
	Given I am on the home page of w3schools
	When I click on the link learn html
	Then The website shoulod navigate to the html home screen
	When I click on the link Try it yourself
	Then the heading should be displayed as This is a Heading
