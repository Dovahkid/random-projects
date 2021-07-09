# ------------------------------------------------------------- #
# Name: Michael Gain                                            #
# Date:   11/3/17                                               #
# Assignment:  Project 8 - Rotate 13 Encryption and Decryption  #
# Description:   Encrypt and Decrypt using the rotate 13 cipher #
# ------------------------------------------------------------- #

import random
from setup_messagebox import *

LETTERS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'

def main():
    Alt_myMessage = '''If a man is offered a fact which goes against his instincts, 
    he will scrutinize it closely, and unless the evidence is overwhelming, he 
    will refuse to believe it. If, on the other hand, he is offered something 
    which affords a reason for acting in accordance to his instincts, he will 
    accept it even on the slightest evidence. The origin of myths is explained 
    in this way. -Bertrand Russell'''
    
    # remove the Alt_ in front of myMessage to decrypt this encrypted message
    # *and* change the mode to decrypt
    myMessage = input("What is your msg: ")
    
    # create a key for this message
    myKey = 'NOPQRSTUVWXYZABCDEFGHIJKLM'
    # set the mode for encrypt or decrypt next
    myMode = 'decrypt' # set to 'encrypt' or 'decrypt'

    checkValidKey(myKey)

    if myMode == 'encrypt':
        translated = encryptMessage(myKey, myMessage)
    elif myMode == 'decrypt':
        translated = decryptMessage(myKey, myMessage)
    print('Using key %s' % (myKey))
    print('The {}ed message is:'.format(myMode))
    print(translated)
    messagebox.showinfo("MSG", translated)
    print()



def checkValidKey(key):
    keyList = list(key)
    lettersList = list(LETTERS)
    keyList.sort()
    lettersList.sort()
    if keyList != lettersList:
        print("There is an error in the key or symbol set!")
        quit()


def encryptMessage(key, message):
    return translateMessage(key, message, 'encrypt')


def decryptMessage(key, message):
    return translateMessage(key, message, 'decrypt')


def translateMessage(key, message, mode):
    translated = ''
    charsA = LETTERS
    charsB = key
    if mode == 'decrypt':
        # For decrypting, we can use the same code as encrypting. We
        # just need to swap where the key and LETTERS strings are used.
        charsA, charsB = charsB, charsA

    # loop through each symbol in the message
    for symbol in message:
        if symbol.upper() in charsA:
            # encrypt/decrypt the symbol
            symIndex = charsA.find(symbol.upper())
            if symbol.isupper():
                translated += charsB[symIndex].upper()
            else:
                translated += charsB[symIndex].lower()
        else:
            # symbol is not in LETTERS, just add it
            translated += symbol

    return translated


def getRandomKey():
    key = list(LETTERS)
    random.shuffle(key)
    return ''.join(key)

# allow this program to be imported to use functions
# or call the main() function if not being imported
if __name__ == '__main__':
    main()