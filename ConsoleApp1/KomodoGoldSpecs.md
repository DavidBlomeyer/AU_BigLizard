The .sin is set up so that all three assignment projects run from a single additional project (00_Komodo_Gold_Console).  
IF you want to test each project seperately, Main's can be enabled/disabled and Start-Up Project set as needed.  
In order to keep each project capable of running independantly, each project StartMenu '0' optional will close the console rather then return to the "Gold" Menu.

The only other major deviance from the general format of the assignment is that the Methods of the Program UI are instead in a UIRepo 
and the file structure is "daisy chained" to make that work.  The main point of this is allowing a better "right - left" workflow.

Beyond that, the POCO's are all public static objects to make testing easier (partially because of the file structure above).

As usual, each project contains a _spec.md that "restates the problem", contains 
a UI Diagram, Variable List, and a basic File Structure (mostly, because References can be the Devil).

__________________________________________________________________________________________________________________________________________________


UI Diagram

A. Hello - KomodoGoldStartMenu
	1. CafeStartMenu
	2. ClaimsStartMenu
	3. BadgesStartMenu


Var List

no :)


File Structure

00_Komodo_Gold_Console
	00_Program
		01_ProgramUI
			01_Komodo_Cafe
				01_MenuProgramUI - ui
					02_MenuUIRepo - methods
						04_MealRepo - methods
							03_MealPOCO - data(list)
			02_Komodo_Claims
				01_ClaimsProgramUI - ui
					02_ClaimsUIRepo - methods
						04_ClaimsRepo - methods
							03_ClaimsPOCO - data(queue)
			03_Komodo_Badging
				01_BadgesProgramUI - ui
					02_BadgesUIRepo - methods
						04_BadgesRepo - methods
							03_BadgesPOCO - data(dictionary)

		

