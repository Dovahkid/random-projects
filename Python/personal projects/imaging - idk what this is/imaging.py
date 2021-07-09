from cImage import *

win = ImageWin("Image", 300, 300)

drawing = EmptyImage(300, 300)

Dpixel = Pixel(255, 0, 0)

for i in range(300):
    drawing.setPixel(i, i, Dpixel)

drawing.draw(win)

win.exitonclick()
drawing.save("test.gif")


'''
# import the cImage.py library -- must be in same folder as this program
from cImage import *

# create an empty image window
ImWin = ImageWin("Example 1",  300,  300)

# create an empty image to draw on (larger than grid shown
# to allow students to see the single red pixel
empty_image = EmptyImage(300,  300)

# create a red Pixel
redPixel = Pixel(255, 0, 0)

# draw the single pixel at location
for i in range(300):
    empty_image.setPixel(i, i,  redPixel)
    empty_image.setPixel(151, 150,  redPixel)
    empty_image.setPixel(152, 150,  redPixel)
    empty_image.setPixel(150, 149,  redPixel)
    empty_image.setPixel(151, 149,  redPixel)
    empty_image.setPixel(152, 149,  redPixel)
    empty_image.setPixel(150, 148,  redPixel)
    empty_image.setPixel(151, 148,  redPixel)
    empty_image.setPixel(152, 148,  redPixel)



# draw the image created in the image window
empty_image.draw(ImWin)

# keep the window open until click with mouse inside
# then free up the image window memory
ImWin.exitOnClick()

# save a copy of our image!
empty_image.save("example1.gif")
'''