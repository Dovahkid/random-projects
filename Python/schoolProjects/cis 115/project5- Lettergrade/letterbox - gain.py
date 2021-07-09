# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   9/12/17
# Assignment:  Project 5 - Letter Grade
# Description:   Evaluate a numeric grade entered by the user and display
#                        the correct letter grade inside a messagebox.
# -------------------------------------------------------------------------------
from setup_messagebox import *
invalid = 0

letter_grade = "Your letter grade is: "

while invalid == 0:
    invalid = 0
    grade = float(input("What is your grade?"))
    if grade < 0:
        print("That is not a valid grade!")
        invalid = 0
    else:
        invalid = 1
        break
if grade >= 90:
    if grade > 100:
        letter_grade += "A+"
    else:
        letter_grade += "A"
elif grade < 90 and grade >= 80:
    letter_grade += "B"
elif grade < 80 and grade >= 70:
    letter_grade += "C"
elif grade < 70 and grade >= 60:
    letter_grade += "D"
else:
    letter_grade += "F"

messagebox.showinfo("Letter Grade Result", letter_grade)
