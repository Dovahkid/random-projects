mmport os
file = open("SelfWriting.py", "r")
file2 = file.read()
file3 = list(file2)


def test():
    print(file3)


def fileEdit():
    global file5, file4
    file4 = open("SelfWriting.py", "w")
    file3[0] = "m"
    file11 = ''.join(file3)
    file5 = file4.write(file11)


def openFile():
    while True:
        os.system("python SelfWriting.py")
        break


def run():
    test()
    # openFile()
    fileEdit()
    # openFile()
    file.close()
    file4.close()


run()

file11 = open("SelfWriting.py", "r")
test()
