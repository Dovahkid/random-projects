from turtle import *
wn = Screen()
tur = Turtle()
tur.speed(300)

tur.penup()
tur.setpos(-50,0)
tur.pendown()
tur.pensize(2)

y = 1.87

tur.begin_fill()
for i in range(5):
    tur.fillcolor('yellow')
    tur.pencolor('black')
    tur.forward(200)
    tur.right(144)
tur.end_fill()


tur.pencolor('black')
tur.penup()
tur.goto(49,74)
tur.pendown()
for x in range(360):
    tur.forward(y)
    tur.right(1)
tur.write(y * 360) #this is a mostly accurate way to find the circumference of a circle

wn.exitonclick()