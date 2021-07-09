count = 0
pos = int(input("Enter a positive number: "))
#while (pos % 2) == 0:
 #   pos -= 1
  #  break
for x in range((pos + pos % 2) -1, (-1 * pos) - 1, -2):
    count += 1
    print("\n", x)
print("Count:", count)
input()