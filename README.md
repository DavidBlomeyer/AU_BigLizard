# AU_BigLizard

The .sin is set up so that all three assignment projects run from a single additional project (00_Komodo_Gold_Console).  IF you want to test each project seperately, Main's can be enabled/disabled and Start-Up Project set as needed.  In order to keep each project capable of running independantly, each project StartMenu '0' optional will close the console rather then return to the "Gold Menu".

The only other major deviance from the general format of the assignment is that the Methods of the Program UI are instead in a UIRepo and the file structure is "daisy chained" to make that work.  The main point of this is allowing a better "right - left" workflow.

Beyond that, the POCO's are all public static objects to make testing easier (partially because of the file structure above).

As usual, each project contains a '_spec.md' that "restates the problem", contains a UI Diagram, Variable List, and a basic File Structure (mostly, because References can be the Devil).

