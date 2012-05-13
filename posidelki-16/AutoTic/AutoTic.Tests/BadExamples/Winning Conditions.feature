Feature: Winning Conditions
	If three icons of same type appear in a row either vertically or horizantally or diagonally, 
	the user of that icon will be declared winner by the system. 


@mytag
Scenario: Crosses move first and win when 3 icons appear in a row diagonally
	Given I am on the page 'http://ostermiller.org/calc/tictactoe.html'
	And I have Started new Game ‘Human’ vs ‘Human’
	
	And I have pressed the Button 'c9'
	And I have pressed the Button 'c8'
	And I have pressed the Button 'c5'
	And I have pressed the Button 'c6'

	When I press the Button 'c3'

	Then the Player X Won count should be '1'
