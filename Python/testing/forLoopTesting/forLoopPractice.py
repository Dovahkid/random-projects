print("\n\n Adding 1")
add = 0
for i in range(1, 100, 2):
    print(i, end=" ")
    add +=i
print("\n", add)

add2 = 0

print("\n\n Adding 2")
for x in range(1, 200, 2):
    print(x, end=" ")
    add2 +=x
print("\n", (add2 / 50))


def average(n):
    print("\n\n Average of numbers")
    nn = 0
    for n in range(1, n+1):
        nn += n
    print("\n", (nn / n))

average(10)


def factorial(f):
    print("\n\n Factorial")
    ff = 1
    print(f)
    for f in range(1, f+1):
        ff *= f
        #print(f)
    print("\n", ff)

factorial(52)

input()
