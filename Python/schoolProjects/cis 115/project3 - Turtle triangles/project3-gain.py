#-------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   8/22/17
# Assignment:  Project 3 - Equilateral Triangle
# Description:   Draw a triangle and fill it with my eye color.
#-------------------------------------------------------------------------------

from turtle import *
wn = Screen()
michael = Turtle()

brown = [0.8, 0.4, 0.0]
michael.fillcolor(brown)

michael.begin_fill()
for i in range(3):
    michael.forward(300)
    michael.left(120)
michael.penup()
michael.backward(301)
michael.pendown()
for i in range(3):
    michael.forward(300)
    michael.left(120)
michael.end_fill()

wn.exitonclick()

