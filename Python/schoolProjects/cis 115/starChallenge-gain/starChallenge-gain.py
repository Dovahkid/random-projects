from turtle import *
wn = Screen()
michael = Turtle()

michael.fillcolor('yellow')
michael.begin_fill()
for i in range(5):
    michael.forward(200)
    michael.right(144)
michael.end_fill()
wn.exitonclick()