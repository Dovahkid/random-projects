from random import *

choice = 0
guess = 0
rand_num = 0
choice2 = ''
rand_num2 = ''


def rang_choice():
    global choice
    global choice2
    choice = int(input("What range? 1 - ?: "))
    choice2 = str(choice)
    rand()


def rand():
    global rand_num
    global rand_num2
    rand_num = randint(1, choice)
    rand_num2 = str(rand_num)
    num_guess()


def num_guess():
    global guess
    guess = int(input("What is your guess for 1 - " + choice2 + "? "))
    guess_check()


def guess_check():
    if rand_num == guess:
        print("Correct!")
    else:
        print("Incorrect! The correct number was " + rand_num2)

rang_choice()

input()
