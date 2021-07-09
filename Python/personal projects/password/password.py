username = "MGain"
password = "3356"
custom_user = ""
custom_pass = ""
login_Create = 2
tries = 5
stop = 0
guess = ""
guess2 = ""


def login_create():
    global login_Create
    login_Create = int(input("Do you want to login or create an account?:\n"
                             "  1.) Login\n"
                             "  2.) Create an account\n"
                             "----> "))


def create_an_account():
    global custom_pass, custom_user
    print("::Account Creation::")
    custom_user = input("What is your username?: ")
    custom_pass = input("What is your password:? ")


def passwordd():
    global tries, stop, guess, guess2
    if login_Create == 2:
        while tries > 0 and stop == 0:
            guess = input("Enter your username: ")
            if guess == custom_user:
                guess2 = input("Enter your password: ")
                if guess2 == custom_pass:
                    print("Welcome! Please wait...")
                    stop = 1
                else:
                    tries -= 1
                    print("Incorrect! You have", tries, "tries left.")
            else:
                tries -= 1
                print("Incorrect! You have", tries, "tries left.")
    else:
        while tries > 0 and stop == 0:
            guess = input("What is your username?: ")
            if guess == username:
                guess2 = input("Enter your password: ")
                if guess2 == password:
                    print("Welcome! Please wait...")
                    stop = 1
                else:
                    tries -= 1
                    print("Incorrect! You have", tries, "tries left.")
            else:
                tries -= 1
                print("Incorrect! You have", tries, "tries left.")


def triess():
    if tries == 0:
        print("You are locked out! Too many incorrect guesses!")
        input()
    else:
        print("")
        input()


def main():
    rep = 0
    while rep == 0:
        login_create()
        if login_Create == 1:
            passwordd()
            triess()
            rep = 1
        elif login_Create == 2:
            create_an_account()
            passwordd()
            input()
            rep = 1
        else:
            print("Not a choice!")
            rep = 0

main()
