import os

word = ""
word_length = 0
letter_guess = ''
tries = 6
dis_letters = "The currently discovered letters: "

stopped = False

def gameBoard():
    global stopped, tries
    while not stopped:
        tries -= 1
        if tries == 5:
            print("\n    O  \n"
                  "   /|\  \n"
                  "   / \ ")
        elif tries == 4:
            print("\n    O  \n"
                  "   /|\  \n"
                  "   /  ")
        elif tries == 3:
            print("\n    O  \n"
                  "   /|\  \n"
                  "       ")
        elif tries == 2:
            print("\n    O  \n"
                  "   /|  \n"
                  "    ")
        elif tries == 1:
            print("\n    O  \n"
                  "       \n"
                  "      ")
        else:
            print("\n    |  \n"
                  "    |  \n"
                  "    O ")
        if tries < 0:
            stopped = True
        else:
            stopped = False



gameBoard()