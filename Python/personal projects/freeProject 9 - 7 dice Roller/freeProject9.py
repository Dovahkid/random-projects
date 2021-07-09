from random import *

whilex = 0

ranx = ''
x = ''
roll = "You rolled "

while whilex < 1:
    def dice_20():
        print(roll, randint(1, 20))


    def dice_10():
        print(roll, randint(1, 10))


    def dice_10_per():
        ranx = randint(0, 9) * 10

        print(roll, ranx, "%")


    def dice_12():
        print(roll, randint(1, 12), )


    def dice_8():
        print(roll, randint(1, 8))


    def dice_6():
        print(roll, randint(1, 6))

    def dice_4():
        print(roll, randint(1, 4))


    def dice_choice():
        global x
        print("")
        print("")
        print("")
        print("#-----> 7-dice roller <-----#")
        print("20.) 20 sided dice")
        print("12.) 12 sided dice")
        print("10.) 10 sided dice")
        print("10p.) 10 sided percentage dice")
        print("8.) 8 sided dice")
        print("6.) 6 sided dice")
        print("4.) 4 sided dice")
        print("end.) Quit")
        x = input("What dice would you like to roll?: ")
        if x == '20':
            dice_20()
        if x == '12':
            dice_12()
        if x == '10':
            dice_10()
        if x == '10p':
            dice_10_per()
        if x == '8':
            dice_8()
        if x == '6':
            dice_6()
        if x == '4':
            dice_4()
        if x == 'end':
            end()


    def end():
        exit()

    dice_choice()

    whilex = 0

input()
