# Secure password keeper
# Michael Gain 2018

username_create = ''
password_create = ''
username_login = ''
password_login = ''
login_success = ''
login_attempts = ''


def main():
    while True:  # Choice loop

        # Choice input
        choice = input("1.) Create a profile \n"
                       "2.) Login to a profile \n"
                       "--> ")

        # Choice 1: create profile
        if choice == "1":
            profile_create()
            break

        # Choice 2: login to profile
        elif choice == "2":
            profile_login()
            password_read_or_write()
            break

        # Choice 3: You're dumb
        else:
            print("That's not an option! You dumb dumb! Now I see why you can't manage your passwords yourself!")


# function handling profile creation
def profile_create():  # for creating a user account

    # sub-function for creating a username & password
    def user_new_user():
        global username_create, password_create

        # username input
        username_create = input("Enter your username:\n"
                                "-> ")
        while True:  # loop to ensure password is same

            # password input
            password_create = input("Enter your password:\n"
                                    "-> ")
            # password check input
            password_create_check = input("Enter your password again:\n"
                                          "-> ")

            # checks if password and verification are the same
            if password_create == password_create_check:
                break
            else:
                print("Passwords do not match! Please enter again!\n")

    # for storing user login info
    # 1. create a file 2. encode user info 3. store user info in file
            # user file name is encoded username
            # to open, encode user name add .txt to the end and open that file
    ### MAKE SURE YOU CANT OVERWITE ANOTHER PROFILE

    # encodes password
    def encoded_pass_user(password_enc, username_enc):
        enc_pass = password_enc
        return username_enc + "\n" + enc_pass

    # writes username and password to file
    def user_pass_write():
        new_user_file = open(username_create + ".txt", 'w')
        new_user_file.write(encoded_pass_user(password_create, username_create))

    user_new_user()
    user_pass_write()

    # prevent program from immediately closing
    pause_close = input("The program will now close. To login click any key and relaunch the program.")


# Function for logging into a user account
def profile_login():

    # sub-function for logging username check
    def user_login():
        global username_login
        while True:  # User name input and check loop

            # asks for user name input
            username_login = input("Please enter your user name:\n"
                                   "-> ")

            # checks user name
            try:
                try_to_open = open(username_login + ".txt", 'r')
            except:
                print("Username not found! Try again!")
            else:
                try_to_open.close()
                break

    # sub-function for logging password check
    def pass_login():
        global password_login, login_success, login_attempts
        login_attempts = 3
        while True:  # password input and check loop
            while login_success != 1 and login_attempts != 0:

                # Password input
                password_login = input("Please enter your password:\n"
                                       "-> ")

                # retrieves password
                read_pass = open(username_login + ".txt", "r")
                password_read = read_pass.readlines()[1]

                # Check password accuracy
                if password_read == password_login:
                    print("Success! Logging in...")
                    login_success = 1
                else:
                    login_attempts -= 1
                    print("Incorrect password! Try again. Remaining attempts ", login_attempts)
                    if login_attempts == 0:
                        print("You failed to enter the correct password too many times! Please try again later. "
                              "\nPlease close the program.")
                    else:
                        pass

    user_login()
    pass_login()


def password_read_or_write():
    pass


def read_password_entries():
    pass


def new_password_entry():  # For creating a new entry to store a password in a user account
    pass


main()


