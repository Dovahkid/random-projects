def is_even(num):
    if num % 2 == 0:
        return True
    return False


if __name__ == "__main__":

    for i in range(10):
        print(is_even(i))
