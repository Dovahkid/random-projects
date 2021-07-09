from random import *

rand_noun = randint(0, 5)
rand_verb = randint(0, 6)
rand_adv = randint(0, 4)
rand_prep = randint(0, 4)
rand_place = randint(0, 4)

noun = ["A man", "A woman", "A dog", "A cat", "A furry", "An alien"]
verb = ["walked", "jogged", "ran", "sprinted", "darted", "jumped", "was chased"]
adv = ["quickly", "slowly", "quietly", "loudly", "fast"]
prep = ["on", "down", "up", "across", "behind"]
place = ["the street.", "the boardwalk.", "the sidewalk.", "the field.", "the trail."]

print(noun[rand_noun], verb[rand_verb], adv[rand_adv], prep[rand_prep], place[rand_place])
input()
