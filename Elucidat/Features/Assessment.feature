Feature: Assessment
	
@Assessment_01
Scenario: End to End Lab health & safety Assessment
    Given User is on Assessment page
	When User Click on Start button
	And User Click on Go button
	And User Click on Goggles
	And User Click on Lab coat
	And User Click on Steel toe cap shoes
	And User Click on Submit button
	And User Click on You as you are close to the spillage
    And User Click on Submit button2
	And User Click on Set up a causion sign in the affected area
    And User Click on Submitthree button
	And user click on On top of a cabinet and drop on unsafe
	And user click on Shelving below eye level and drop on safe
	And user click on In front of a window and drop on unsafe
	And user click on Next to a heat source and drop on unsafe
    And user click on Inside a metal cabinet and drop on safe
    And User Click on Submitfour button
	And  User Click on Go buttontwo
    And user click on Identify hazard and drop as first 
	And user click on make a record of your findings and drop as second 
    And user click on Submitfive button 
	And user click on PPE and drop as first
	And User Click on Submitsix button
	And user Click on Not allowed for Stud earrings
	And user Click on Not allowed for loose clothing
	And user Click on allowed for long hair tied back
    And user Click on Not allowed for sandles
	And user Click on Not allowed for necklase
	And user Click on Not allowed for contact lenses
	And User Click on Submitseven button
	And User Click on Yes- even near misses need to be reported
	And User Click on Submiteight button
	And user click on See results button
	Then should display score
	And also should display Pass or fail
