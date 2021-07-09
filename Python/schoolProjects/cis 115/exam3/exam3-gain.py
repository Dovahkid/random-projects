# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   9/21/17
# Assignment:  Module 3 Exam Part 2
# Description:   Automate the Pizza Ordering Process.
# -------------------------------------------------------------------------------
from setup_messagebox import *
pizza_size = ""
num_of_pizzas = 0
order_total = "Your order total is: "
total = 0
price = 0

print("Let me help you order a pizza by Michael Gain")


def getinput():
    global pizza_size, num_of_pizzas
    pizza_size = input("What is the size of pizza you want?: (a, b, c, d) ")
    num_of_pizzas = int(input("How many pizzas do you want?: "))


def process():
    global total, price
    if pizza_size == "a":
        total = 7.99 * num_of_pizzas

    elif pizza_size == "b":
        total = 14.99 * num_of_pizzas

    elif pizza_size == "c":
        total = 18.99 * num_of_pizzas

    else:
        total = 22.99 * num_of_pizzas


def output():
    global order_total
    order_total += "$" + str(total)
    messagebox.showinfo("Total", order_total)


def main():
    getinput()
    process()
    output()


main()
