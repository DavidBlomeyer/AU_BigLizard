Challenge 1: Cafe
Komodo Cafe

Komodo cafe is getting a new menu. The manager wants to be able to create new menu items, delete menu items, and receive a list of all items on the cafe's menu. She needs a console app.

 
The Menu Items: - 

    A meal number, so customers can say "I'll have the #5"
    A meal name
    A description
    A list of ingredients,
    A price

 
Your Task: 

    Create a Menu Class with properties, constructors, and fields.
    Create a MenuRepository Class that has methods needed.
    Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.

 
Notes:

We don't need to be able to update items right now.

__________________________________________________________________________________________________________________________________________________


UI Diagram

A. Hello - ClaimsStartMenu()
    1. See Full Menu -
    2. See Single Menu Item - 
    3. Add a Menu Item - 
    4. Delete a Menu Item - 

    0. Exit



Var List (POCO MealContent- list)

int MealNumber
string MealName
string MealDesc
string[] MealIngre
double MealPrice



File Structure

01_Komodo_Cafe
    00_MenuProgram
        01_MenuProgramUI - ui
            02_MenuUIRepo - methods
                04_MealRepo - methods
                    03_MealPOCO - data(list)
01_Komodo_Cafe_Test
    Cafe_Test




    




 