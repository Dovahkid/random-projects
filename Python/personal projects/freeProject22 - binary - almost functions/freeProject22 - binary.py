def alphabet(letter):
    letter_check = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                    'u', 'v', 'w', 'x', 'y', 'z', ' ']

    for ll in letter_check:
        if ll == letter:
            word_value.append(ord(ll))
        else:
            pass


def binary_math():
    binary_values = (128, 64, 32, 16, 8, 4, 2, 1)
    for len in word_value:
        print(len)


def main():
    global word_value
    xx = -1
    msg = input("Enter your msg. It is case sensitive!")
    word_value = list()
    for ii in msg:
        xx += 1
        for letter in msg[xx]:
            alphabet(letter)
    
    print(word_value)
    input()


main()
