from turtle import *
wn = Screen()
tur = Turtle()
tur.speed(1000)

color = ['red', 'purple', 'blue', 'yellow', 'orange']

for i in range(100):
    tur.pensize(2)
    tur.pencolor(color[i % 5])
    tur.forward(i)
    #tur.left(i)
    tur.left(91)
tur.penup()
tur.setpos(-90,-75)
tur.pendown()
for x in range(100):
    tur.pensize(2)
    tur.pencolor(color[x % 5])
    tur.forward(x)
    #tur.left(i)
    tur.left(91)

wn.exitonclick()