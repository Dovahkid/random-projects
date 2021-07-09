def gen_board(num):
    print()
    for i in range(num):
        print('x' * num)


if __name__ == "__main__":
    for i in range(10):
        gen_board(i)
