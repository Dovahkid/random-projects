from turtle import *
wn = Screen()
tur = Turtle()

color = ['red','orange','yellow','blue','purple']

for i in range(999):
    tur.pencolor(color[i % 5])
    tur.speed(i)
    tur.forward(i)
    tur.right(91)

wn.exitonclick()