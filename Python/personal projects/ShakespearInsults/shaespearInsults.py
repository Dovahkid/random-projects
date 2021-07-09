from random import *

file = open("insults.txt", "w")

count = 0

randomA = 0
randomB = 0
randomC = 0

columnA = ["bawdy", "brazen", "churlish", "distempered", "fitful", "gnarling", "greasy", "grizzled", "haughty",
           "hideous", "jaded", "knavish", "lewd", "peevish", "pernicious", "prating", "purpled", "queasy", "rank",
           "reeky", "roynish", "saucy", "scottish", "unmuzzled", "vacant", "waggish", "wanton", "wenching",
           "whoreson", "yeasty"]

columnB = ["bunch-backed", "clay-brained", "dog-hearted", "evil-eyed", "eye-offending", "fat-kidney", "heavy-headed",
           "horn-mad", "ill-breeding", "ill-composed", "ill-nurtured", "iron-witted", "lean-witted", "lily-livered",
           "mad-bread", "motley-minded", "muddy-mettled", "onion-eyed", "pale-hearted", "paper-faced",
           "pinch-spotted", "raw-boned", "rug-headed", "rump-fed", "shag-eared", "shag-eared", "shilled-gorged",
           "sour-faced", "weak-hinged", "white-livered"]

columnC = ["canker-blossom", "clotpole", "crutch", "cutpurse", "dogfish", "egg-shell", "gull-catcher", "hedge-pig",
           "hempseed", "jack-a-nape", "malkin", "malignancy", "malt-worm", "manikin", "minimus", "miscreant",
           "moldwarp", "nut-hook", "pantaloon", "rabbit-sucker", "rampallion", "remnant", "rudesby", "ruffian",
           "scantling", "scullion", "snipe", "waterfly", "whipster", "younker"]


def gen():
    global randomA, randomB, randomC, count
    count += 1
    randomA = randint(0, 29)
    randomB = randint(0, 29)
    randomC = randint(0, 29)
    print(columnA[randomA], columnB[randomB], columnC[randomC])
    insult = str(count) + ". " + columnA[randomA] + " " + columnB[randomB] + " " + columnC[randomC] + "\n"
    file.write(insult)


num = int(input("Number of insults: "))

for i in range(num):
    gen()


file.close()

input()
