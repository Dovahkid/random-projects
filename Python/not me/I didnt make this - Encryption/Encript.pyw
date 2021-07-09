from tkinter import messagebox
import tkinter.simpledialog
import tkinter
output = ""
encode1 = "abcdefghijklmnopqrstuvwxyz"
encode2 = "BCDEFGHIJKLMNOPQRSTUVWXYZA"
decode1 = encode1
decode2 = encode2
choice = True
txt = ''


def encode():
    global output
    for i in range(len(txt)):
        for x in range(len(encode1)):
            if txt[0 + i] == encode1[x - 1]:
                output += encode2[x - 1]
    messagebox.showinfo("The output", output)
    file = open("encoded.txt","w")
    file.write(output)
    file.close()
    end()

def decode():
    global output
    for i in range(len(txt)):
        for x in range(len(encode1)):
            if txt[0 + i] == decode1[x - 1]:
                output += decode2[x - 1]
    messagebox.showinfo("The output", output)
    file = open("decoded.txt", "w")
    file.write(output)
    file.close()
    end()


def mainEncode():
    global txt
    txt = tkinter.simpledialog.askstring("Enter Text", "Enter the text you would like to encode")
    encode()


def mainDecode():
    global txt
    txt = tkinter.simpledialog.askstring("Enter Text", "Enter the text you would like to decode")
    decode()


def getinfo():
    global choice
    choice = messagebox.askyesno("What to do?", "Would you like to encode?")
    if choice:
        mainEncode()
    else:
        choice = messagebox.askyesno("What to do?", "Would you like to decode?")
        if choice:
            mainDecode()
def end():
    global output
    cont = messagebox.askyesno("Would you like to continue?", "Would you like to continue?")
    if cont:
        getinfo()
        output = "0"


getinfo()

