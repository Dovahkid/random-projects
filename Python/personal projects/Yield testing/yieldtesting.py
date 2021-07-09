def nats(n):
    yield n
    yield from nats(n+1)


def sieve(s):
    n = next(s)
    yield n
    yield from sieve( i for i in s if i % n !=0)


def primeGen(n = nats(2)):
    gen = sieve(n)
    for i in gen:
        print(i)


def generator3():
    for i in range(10, 20):
        yield i

def generator2():
    for i in range(10):
        yield i

def generator():
    yield from generator2()
    yield from generator3()


if __name__ == "__main__":
    # n = nats(2)
    # primeGen(n)
    primeGen()
    # g = generator()
    # for i in g:
    #     print(i)