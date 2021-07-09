def notLambda(x):
    return x * x

high_ord_func = lambda x, func: x + func(x)


y = 2

print(f"{high_ord_func(2, lambda x: x * x) = }")

print(f"{high_ord_func(y, notLambda) = }")
