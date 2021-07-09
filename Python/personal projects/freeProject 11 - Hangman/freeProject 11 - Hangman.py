import os

word = ""
word_length = 0

letter_guess = ''
word_guess = ""
dis_letter = []
wrong_guesses = ""

tries = 5
cor_count = 0

os.system('title = Hangman')


def discovered_letters():
    global dis_letter

    for i in range(word_length):
        if letter_guess is word[i]:
            dis_letter.append(letter_guess)


def hangman():
    if tries == 5:
        print("  o  ")
        print(" /|\ ")
        print(" / \\")
    if tries == 4:
        print("  o  ")
        print(" /|\ ")
        print(" /   ")
    if tries == 3:
        print("  o  ")
        print(" /|\ ")
        print("     ")
    if tries == 2:
        print("  o  ")
        print("  |  ")
        print("     ")
    if tries == 1:
        print("  o  ")
        print("     ")
        print("     ")
    if tries == 0:
        print("  |  ")
        print("  |  ")
        print("  O  ")


def start():
    global word, word_length, letter_guess, word_guess, tries, cor_count, wrong_guesses

    letter_guess = ''
    word_guess = ""
    wrong_guesses = ""
    dis_letter = []
    tries = 5
    cor_count = 0
    
    clear()
    word = input("What word would you like to use for the game?: ")
    word_length = len(word)

    clear()
    game()


def lose_end():
    clear()
    print("You lost!")
    print("The word is", word)
    print("1.) Play Again")
    print("2.) Quit")
    play_again = input("Play again?: ")
    if play_again == "1":
        start()
    else:
        exit()


def win_end():
    clear()
    print("Correct! The word was", word, "!")
    print("1.) Play Again")
    print("2.) Quit")
    play_again = input("Play again?: ")
    if play_again == "1":
        start()
    else:
        exit()


def clear():
    os.system('cls')


def game():
    global tries, word_guess, letter_guess, cor_count, wrong_guesses
    while tries > 0:
        print("Wrong letters: ", wrong_guesses)
        print("You have ", tries, " tries left.")
        print("")
        hangman()
        print("")
        print("The word has", word_length, "characters.")
        print("The currently discovered letters are: ", dis_letter)
        print("")
        print("1.) guess word")
        print("2.) guess letter")
        game_option = input("What is your choice?: ")
        if game_option == "1":
            clear()
            word_guess = input("What is your word guess?: ")
            if word_guess == word:
                win_end()
            else:
                clear()
                print("That is incorrect!")
                tries -= 1
                game()
        else:
            clear()
            letter_guess = input("What is your guess for a letter?: ")
            if letter_guess in word:
                clear()
                print(letter_guess, "is in the word!")
                cor_count = cor_count + 1
                discovered_letters()
                if cor_count == len(word):
                    win_end()
                else:
                    game()
            else:
                clear()
                print(letter_guess, "is not in the word!")
                wrong_guesses += letter_guess
                tries -= 1
    if tries == 0:
        clear()
        hangman()
        lose_end()

start()
