from turtle import *

wn = Screen()
tur = Turtle()

tur.speed(100)

color = ['red', 'orange', 'yellow', 'green', 'blue', 'purple']
color2 = ['green', 'blue', 'purple','red', 'orange', 'yellow']

tur.pensize(3)
for x in range(999):
    tur.penup()
    tur.goto(0,-518)
    tur.pendown()
    for i in range(52):
        tur.pencolor(color[i % 6])
        tur.forward(100)
        tur.left(90)
        tur.forward(10)
        tur.left(90)
        tur.forward(100)
        tur.right(90)
        tur.forward(10)
        tur.right(90)
    tur.penup()
    tur.goto(0,-518)
    tur.pendown()
    for y in range(52):
        tur.pencolor(color2[y % 6])
        tur.forward(100)
        tur.left(90)
        tur.forward(10)
        tur.left(90)
        tur.forward(100)
        tur.right(90)
        tur.forward(10)
        tur.right(90)
wn.exitonclick()