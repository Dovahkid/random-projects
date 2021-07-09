# Michael Gain 9/20/17 math 3 Linear programming calculator
import os
fats = 0
carbs = 0
protein = 0
weight = 0
feasible = True

run = True

def getinput():
    x = int(input("How many bars?: "))
    y = int(input("How many cartons?: "))
    math(x, y)


def math(b, c):
    global fats, carbs, protein, weight
    fats = (5 * b) + (6 * c)
    carbs = (40 * b) + (25 * c)
    protein = (8 * b) + (15 * c)
    weight = (270 * b) + (300 * c)
    req()


def req():
    global feasible
    if fats >= 61 and protein >= 103 and carbs >= 350:
        feasible = True
    else:
        feasible = False
    ans()


def ans():
    print("\n Fats: ", fats, "\n",
          "Proteins: ", protein, "\n",
          "Carbs: ", carbs, "\n",
          "Weight: ", weight, "\n",
          "feasible: ", feasible)


while run:
    os.system("CLS")
    getinput()
    run2 = int(input("\nWould you like to quit?: (1 - Run  , 2 - Quit) "))
    if run2 == 1:
        run = True
    else:
        run = False
