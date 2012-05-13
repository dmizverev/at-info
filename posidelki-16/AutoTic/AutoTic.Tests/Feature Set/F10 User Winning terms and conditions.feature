Feature: F10 User Winning terms and conditions

	If three icons of same type appear in a row either vertically or horizantally or diagonally, 
	the user of that icon will be declared winner by the system. 

Background: 
	Given New Game. The PlayerX is 'Human' and PlayerO is 'Human'
	And the Game Statistics is cleared

@mytag
Scenario: Crosses move first and win when 3 icons appear in a row diagonally
	Given Crosses start the game
	And The game situation is the following:
	| A | B | C |
	|   | O | X |
	|   | X | O |
	|   |   |   |
	When Crosses make a move to cell 'A3'
	Then Crosses Wins Cound should be '1'


