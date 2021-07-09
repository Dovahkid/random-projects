# savedata[0] = zone
# savedata[1] = lvl
# savedata[2] =
# savedata[3] = character name
# savedata[4] = character gender
# savedata[5] = weapon slot 1
# savedata[6] = weapon slot 2
# savedata[7] = spell slot 1
# savedata[8] = armor slot 1
# savedata[9] = armor slot 2
# savedata[10] = inventory slot 1
# savedata[11] = inventory slot 2
# savedata[12] = inventory slot 3
# savedata[13] = inventory slot 4
# savedata[14] = inventory slot 5
# savedata[15] =
# savedata[16] =
# savedata[17] = skill 1
# savedata[18] = skill 2
# savedata[19] = skill 3
# savedata[20] = skill 4
# savedata[21] = skill 5
# savedata[22] = skill 6
# savedata[23] = skill 7
# savedata[24] = skill 8
# savedata[25] = skill 9
# savedata[26] = battles won
# savedata[27] = death count
# savedata[28] = story choice 1
# savedata[29] = story choice 2
# savedata[30] = story choice 3
# savedata[31] = story choice 4
# savedata[32] = story choice 5

# 92,561,040 possible combinations of the save file

save = open("save.txt", "r")
savedata = save.readline().strip()
tempsave = list(savedata)


lvl = 0
hp = 0
ap = 0
mg = 0

inv1 = 0
inv2 = 0
inv3 = 0
inv4 = 0
inv5 = 0


def editref_testing():
    global save, savedata
    save = open("save.txt", "w+")  # opens the document for writing
    # opening a document for writing will clear all contents of the file
    # Ensure that tempsave is written to before clearing the document

    # the value that needs to be changed must be changed with these 3 lines
    tempsave[10] = "1"
    tempsave[11] = "2"
    tempsave[12] = "3"
    tempsave[13] = "4"
    tempsave[14] = "5"
    jointempsave = ''.join(tempsave)
    save.write(jointempsave)

    # reopen the document again with a read so it wont be cleared and will be updated
    save = open("save.txt", "r")
    savedata = save.readline()
    print(savedata)
    # The print is only to show that it is properly writing


def mainmenu():
    print("\n-----> Press any button to start <-----")
    input()


def stats_calc():
    global lvl, hp, ap, mg
    lvl = int(savedata[1])
    hp = 100 + (lvl * 10)
    ap = 50 + (lvl * 10)
    mg = 25 + (lvl * 10)
    print(lvl)
    print(hp)
    print(ap)
    print(mg)


def inv_check():
    # savedata[10] = inventory slot 1
    # savedata[11] = inventory slot 2
    # savedata[12] = inventory slot 3
    # savedata[13] = inventory slot 4
    # savedata[14] = inventory slot 5

    global inv1, inv2, inv3, inv4, inv5
    for i in range(10):
        if tempsave[10] == str(i):
            inv1 = i
            print(tempsave[10], i, inv1)
        else:
            continue
    for i in range(10):
        if tempsave[11] == str(i):
            inv2 = i
            print(tempsave[11], i, inv2)
        else:
            continue
    for i in range(10):
        if tempsave[12] == str(i):
            inv3 = i
            print(tempsave[12], i, inv3)
        else:
            continue
    for i in range(10):
        if tempsave[13] == str(i):
            inv4 = i
            print(tempsave[13], i, inv4)
        else:
            continue
    for i in range(10):
        if tempsave[14] == str(i):
            inv5 = i
            print(tempsave[14], i, inv5)
        else:
            continue


def mainloop():
    editref_testing()
    # mainmenu()
    stats_calc()
    inv_check()

mainloop()

save.close()
