from turtle import *

wn = Screen()
tur = Turtle()

tur.speed(300)

tur.penup()
tur.goto(-300,0)
tur.pendown()

# M
tur.left(90)
tur.forward(100)
tur.right(135)
tur.forward(50)
tur.left(90)
tur.forward(50)
tur.right(135)
tur.forward(100)

tur.penup()
tur.left(90)
tur.forward(25)
tur.pendown()

# I
tur.forward(100)
tur.left(180)
tur.forward(50)
tur.right(90)
tur.forward(100)
tur.left(90)
tur.forward(50)
tur.right(180)
tur.forward(100)

tur.penup()
tur.forward(25)
tur.pendown()

# C
tur.forward(90)
tur.left(180)
tur.forward(90)
tur.left(90)
tur.forward(100)
tur.left(90)
tur.forward(90)

tur.penup()
tur.forward(25)
tur.pendown()

# H
tur.left(90)
tur.forward(100)
tur.right(180)
tur.forward(50)
tur.left(90)
tur.forward(100)
tur.left(90)
tur.forward(50)
tur.left(180)
tur.forward(100)

tur.penup()
tur.left(90)
tur.forward(25)
tur.pendown()

# A
tur.left(75)
tur.forward(100)
tur.right(150)
tur.forward(100)
tur.penup()
tur.setpos(175, 50)
tur.left(75)
tur.pendown()
tur.forward(30)

wn.exitonclick()
