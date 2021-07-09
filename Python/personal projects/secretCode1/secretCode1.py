enc_dec = input("What message would you like encode or decode?: ")
letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n","o", "p", "q", "r", "s", "t", "u", "v",
           "w", "x", "y", "z", " "]
code_letters = ["z", "y", "x", "w", "v", "u", "t", "s", "r", "q", "p", "o", "n", "m","l", "k", "j", "i", "h", "g", "f",
                "e", "d", "c", "b", "a", " "]
for loop in range(len(enc_dec)):
    for loop2 in range(27):
        if enc_dec[0 + loop] == letters[loop2 - 1]:
            print(code_letters[loop2 - 1], end="")
input()
