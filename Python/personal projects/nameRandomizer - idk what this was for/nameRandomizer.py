import random
how_Many = 0
names = []
group_Size = 0


def getinfo():
    global how_Many, names, group_Size

    how_Many = int(input("How many people need to be randomized?: "))
    repeat_counter = how_Many
    group_Size = int(input("How many people need to be in a group?: "))

    while repeat_counter > 0:
        names.append(str(input("What names need to be randomized?: ")))
        repeat_counter -= 1
        print(names)


def randomizer():
    random.shuffle(names)


def group_assign():
    pass


def main():
    getinfo()
    randomizer()
    group_assign()
    print(names)


main()
input()
