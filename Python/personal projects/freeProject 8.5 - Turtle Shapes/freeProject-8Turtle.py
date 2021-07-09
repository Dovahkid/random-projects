from turtle import *
wn = Screen()
tur = Turtle()
tur.speed(300)


def square():
    for i in range(4):
        tur.shape('square')
        tur.forward(100)
        tur.left(90)
    tur.penup()
    tur.goto(-800, -800)
    tur.pendown()


def triangle():
    for i in range(3):
        tur.shape('triangle')
        tur.forward(100)
        tur.left(120)
    tur.penup()
    tur.goto(-800, -800)
    tur.pendown()


def circle():
    for i in range(180):
        tur.shape('circle')
        tur.forward(3)
        tur.left(2)
    tur.penup()
    tur.goto(-800, -800)
    tur.pendown()


def trapezoid():
    tur.forward(200)
    tur.left(135)
    tur.forward(100)
    tur.left(45)
    tur.forward(60)
    tur.left(45)
    tur.forward(100)
    tur.penup()
    tur.goto(-800, -800)
    tur.pendown()


x = int(input("1.) Square 2.) Triangle 3.) Circle 4.) Trapezoid: "))
if x == 1:
    square()
if x == 2:
    triangle()
if x == 3:
    circle()
if x == 4:
    trapezoid()


wn.exitonclick()
