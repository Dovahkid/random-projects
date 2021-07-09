from turtle import *

wn = Screen()
tur = Turtle()
tur.speed(300)

for i in range(1, 360, 1):
    hour = i/28
    tur.setheading(-i + 90)
    tur.penup()
    tur.forward(100)
    if i % 28 == 0:
        tur.pencolor('black')
        tur.write(int(hour))
    tur.backward(100)
    tur.pendown()
tur.setheading(90)

wn.exitonclick()