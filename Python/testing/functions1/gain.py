def say_hello():
    print("hello 1")
    print("Welcome to Python functions 1")
    return 0


def say_hello2():
    print("hello 2")
    print("Welcome to Python functions 2")
    return 0


def say_hello3():
    print("hello 3")
    return 0 # Wont run following lines after
    print("Welcome to Python functions 3")


def main():
    print(say_hello()) # Prints return also
    say_hello2()
    say_hello3()

print(main)
main()
input()
