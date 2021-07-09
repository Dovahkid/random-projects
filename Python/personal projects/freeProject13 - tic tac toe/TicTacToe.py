spaces = ["1", "2", "3", "4", "5", "6", "7", "8", "9"]
spc = ""
spc_Int = 0
repeatX = 0
repeatO = 0
repeatGame = 0
cur_check = ""


def board():
    print("\n", spaces[0], " | ", spaces[1], " | ", spaces[2], "\n",
          "--------------", "\n",
          spaces[3], " | ", spaces[4], " | ", spaces[5], "\n",
          "--------------", "\n",
          spaces[6], " | ", spaces[7], " | ", spaces[8], "\n")


def win_check():
    if spaces[0] == cur_check and spaces[1] == cur_check and spaces[2] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[3] == cur_check and spaces[4] == cur_check and spaces[5] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[6] == cur_check and spaces[7] == cur_check and spaces[8] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
            board()
        else:
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[0] == cur_check and spaces[3] == cur_check and spaces[6] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[1] == cur_check and spaces[4] == cur_check and spaces[7] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[2] == cur_check and spaces[5] == cur_check and spaces[8] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[0] == cur_check and spaces[4] == cur_check and spaces[8] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    elif spaces[2] == cur_check and spaces[4] == cur_check and spaces[6] == cur_check:
        if cur_check == "X":
            board()
            print("Player 1 wins!")
            input()
            exit()
        else:
            board()
            print("Player 2 wins!")
            input()
            exit()
    else:
        print()

while repeatGame < 9:
    repeatX = 0
    repeatO = 0
    while repeatX < 1:
        board()
        spc = input("Player 1: What space would you like to fill?: ")
        if spc == "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9":
            spc_Int = int(spc)
            spaces[spc_Int - 1] = "X"
            repeatGame += 1
            cur_check = "X"
            win_check()
            repeatX = 1
            break
        else:
            print("That is not an option!")
            repeatX = 0

    if repeatGame < 9:
        while repeatO < 1:
            board()
            spc = input("Player 2: What space would you like to fill?: ")
            if spc == "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9":
                spc_Int = int(spc)
                spaces[spc_Int - 1] = "O"
                repeatGame += 1
                repeatO = 1
                cur_check = "O"
                win_check()
                break
            else:
                print("That is not an option!")
                repeatO = 0
    else:
        win_check()


print("No one wins!")
input()
