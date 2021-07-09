def fizzbuzz():

    rules = {
        3: "fizz",
        5: "buzz"
    }
    for num in range(1, 101):
        output = ""

        for i in rules:
            if num % i == 0:
                output += rules[i]
        print(f'{output if not output == "" else num}')


def fizzbuzz_2():
    for i in range(1, 101):
        print("fizz"*(i % 3 < 1) + "buzz"*(i % 5 < 1) or i)


if __name__ == "__main__":

    fizzbuzz()

    print("Method 2: This version does not have as easy expandability") 
    fizzbuzz_2()
    
    input()
