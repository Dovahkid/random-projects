def checkPrime(val):
    if (val == 1 or val == 0):
        return False
    
    for i in range(2, int(pow(val,.5))+1, 1):
        if (val % i == 0):
            return False
    return True


if __name__ == "__main__":
    file = open("primes.txt", "w")
    for i in range(100000000000):
        if(checkPrime(i)):
            file.write(f"{i}\n")
