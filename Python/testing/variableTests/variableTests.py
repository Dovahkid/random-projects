sec_test_var = "Letters currently discovered: "
test_var = ""
rep = 4


def test():
    global test_var, rep, sec_test_var
    while rep > 0:
        test_var = str(input("Enter a string"))
        rep = rep - 1
        sec_test_var = sec_test_var + test_var

test()


print(sec_test_var)

input()
