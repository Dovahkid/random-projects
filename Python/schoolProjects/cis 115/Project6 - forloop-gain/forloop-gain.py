#-------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   10/5/17
# Assignment:  Project 6 - For Loop
# Description:   Print the odd numbers counting down from 23 
#                       down to -23 inclusive.  No if statement must be used.
#-------------------------------------------------------------------------------

pos = int(input("Enter a positive number: "))
count = 0
while (pos % 2) == 0 and count == 0:
    count += 1
    for x in range(pos - 1, (-1 * pos) - 1, -2):
        print("\n", x)
while (pos % 2) != 0 and count == 0:
    count += 1
    for x in range(pos, (-1 * pos) - 1, -2):
        print("\n", x)

print("End of Project 6 by Michael Gain")
input()
