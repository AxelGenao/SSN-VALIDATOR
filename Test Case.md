Test Cases
Scenario 1: Valid input
Test Id: TC01
Design By: Axel Genao
Review By: Lorenzo Solano

Variables
@ssn = xxx-xxxxxxx-xx

Step #	Description	Expected Result	Actual Result	State
1	Insert @ssn	Message "Valid Social Security Number" Message "Valid Social Security Number"	pass
Scenario 2: Invalid input, bad format

Test Id: TC02
Design By: Axel Genao
Review By: Lorenzo Solano

Variables
@ssn = xxx-xxxxxxx-xx

Step #	Description	Expected Result	Actual Result	State
1	Insert @ssn	Message "The Social Security number must be in the format"	Message "The Social Security number must be in the format"	
