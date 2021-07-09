# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   5/1/17
# Assignment:  Project 9 - Pizza Ordering using three synchronized lists.
# Description:   Calculate Pizza order total using Python Lists - no if/elif/else required unless error handling.
# -------------------------------------------------------------------------------
'''
from setup_messagebox import *

menu = ["a", "b", "c", "d"]
sizes = ['small', 'medium', 'large', 'extra large']
prices = [7.99, 14.99, 18.99, 22.99]

choice = input("a. small ($7.99) \nb. medium ($14.99) \nc. large ($18.99) \nd. extra-large ($22.99)\n--> ")
while choice not in menu:
    print("INVALID PIZZA SIZE: TRY AGAIN")
    choice = input("a. small ($7.99) \nb. medium ($14.99) \nc. large ($18.99) \nd. extra-large ($22.99)\n--> ")
print("\nOk, that is", sizes[menu.index(choice)], "that is", prices[menu.index(choice)])

num = input("\nHow many pizzas do you want: ")
while num in "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+-={}\|[]<>,./?~`":
    print("INVALID PIZZA AMOUNT: TRY AGAIN")
    num = input("\nHow many pizzas do you want: ")
total = 'Your total is $' + str(prices[menu.index(choice)] * int(num))

messagebox.showinfo("Total", total)

print("End of Project 9 by Michael Gain")
'''


'''
from setup_messagebox import *

menu = ["a", "b", "c", "d"]
sizes = ['small', 'medium', 'large', 'extra large']
prices = [7.99, 14.99, 18.99, 22.99]

choice = input("a. small ($7.99) \nb. medium ($14.99) \nc. large ($18.99) \nd. extra-large ($22.99)\n--> ")
print("\nOk, that is", sizes[menu.index(choice)], "that is", prices[menu.index(choice)])
num = input("\nHow many pizzas do you want: ")
total = 'Your total is $' + str(prices[menu.index(choice)] * int(num))
messagebox.showinfo("Total", total)
'''


from setup_messagebox import *

menu = ["a", "b", "c", "d"]
sizes = ['small', 'medium', 'large', 'extra large']
prices = [7.99, 14.99, 18.99, 22.99]

choice = input("a. small ($7.99) b. medium ($14.99) c. large ($18.99) d. extra-large ($22.99) ")
index = menu.index(choice)
print("Ok, that is", sizes[index], "that is", prices[index])
num = int(input("How many pizzas do you want: "))
total = "Your total is " + str(prices[index] * num)
messagebox.showinfo("Total", total)
