#-------------------------------------------------------------------------------
# Written by: Michael Gain
# Date:   8/17/17
# Assignment:  Project 2 - Square
# Description:   Draw a square and fill it with my eye color.
#-------------------------------------------------------------------------------

from turtle import *
wn = Screen() # create a screen window
michael = Turtle() # create a turtle named michael
brown = [0.8, 0.4, 0.0]
michael.begin_fill()
michael.forward(300)
michael.left(90)
michael.forward(300)
michael.left(90)
michael.forward(300)
michael.left(90)
michael.forward(300)
michael.fillcolor(brown)
michael.end_fill()
wn.exitonclick() # close the screen window and free graphics memory