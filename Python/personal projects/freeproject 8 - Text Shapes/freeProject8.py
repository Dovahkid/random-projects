print("1. Square")
print("2. Trapezoid")
print("3. Both")
x = int(input("Answer: "))


def my_square():
    print(" _____")
    print("|     |")
    print("|     |")
    print("|_____|")


def my_trapezoid():
    print("")
    print("   _____  ")
    print("  /     \\")
    print(" /       \\")
    print("/_________\\")


if x == 1:
    my_square()
if x == 2:
    my_trapezoid()
if x == 3:
    my_square()
    my_trapezoid()
	
input()
