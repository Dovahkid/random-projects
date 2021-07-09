# -------------------------------------
# algebra solver v.1
#
# Dec. 2017
# -------------------------------------

full_equation = ""
raw_equation = list("")

num = [""]
char = [""]

order = [""]

numbers = "0123456789"
characters = "/<>()*+-^"
letters = "abcdefghijklmnopqrstuvwxyz"

k = -1


def user_input():
    print("user input")
    global raw_equation
    raw_equation = list(input("Can only have 5 variables and 6 numbers"
                              "\n Please input your equation: "))


def equation_read():
    print("equation")
    global full_equation, num, char, k
    while True:
        k += 1
        for i in range(len(raw_equation)-1):
            print("in loop")
            if raw_equation[i] in numbers:
                if True:
                    if k-1 <= -1:
                        num[k] += str(numbers.find(raw_equation[i]))
                    else:
                        num[k - 1] += str(numbers.find(raw_equation[i]))
                else:
                    num[k] += numbers.find(raw_equation[i])
                if raw_equation[i-1] == "^":
                    num.pop(k)

            elif raw_equation[i] in characters:
                if characters.find(raw_equation[i]) == "^":
                    num[k-1] = num[k-1] ** raw_equation[i+1]

            elif raw_equation[i] in letters:
                letters.find(raw_equation[i])

            else:
                print("INVALID CHARACTER", raw_equation[1])
                break


def answer():
    pass


def main():
    user_input()
    equation_read()
    answer()

main()
