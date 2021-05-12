Feature: Validate the Loan EMI calculation


Background: 
Given Navigate to 'https://emicalculator.net/'
And Home page is appearing


Scenario: Loan EMI Validation
	When Laon amount is '75' Lakhs
	And Interest rate is '12.5%'
	And loan tenure is '15' years
	Then calculated loan EMI is '92,349'
	And Just checking the example

@smokeTest
Scenario: Printing the multiple lines on the notepad
Given Notepad is open
When Data is provided in the table
| Scenario No | Name     | Address       | City      | Phone      |
| 1           | Prashant | Rayasandra-99 | Bangalore | 9019601750 |
| 2           | Nishant  | Munger-01     | Munger    | 8896554404 |
| 3           | Richa    | Sheikhpura    | Bangalore | 8012445505 |
Then writes data in the notepad

	
	@smoketest
	Scenario Outline: Use scenario outline to print the multipe items.
	Given Notepad is open
	When the name of the person is "<Name>"
	When the address is "<Address>"
	When the city is "<City>"
	And the phone is "<Phone>"
	
	Examples: 
	| Test Case | Scenario No | Name     | Address       | City      | Phone      |
	| 1         | 1           | Prashant | Rayasandra-99 | Bangalore | 9019601750 |
	| 2         | 2           | Nishant  | Munger-01	 | Munger     | 8896554404 |
	| 3         | 3           | Richa    | Sheikhpura    | Bangalore | 8012445505 |
	




	

