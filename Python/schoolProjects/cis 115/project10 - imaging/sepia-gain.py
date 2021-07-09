# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   11/21/17
# Assignment:  Project 10 - Convert a photo to sepia tone.
# Description: Read a photo, display it, then convert the photo to sepia tone
#              and show the converted photo next to the original.
# -------------------------------------------------------------------------------

from cImage import *

# Here we define a method that will take a pixel
# and return a pixel that is "flipped" as far as RGB is concerned
def make_sepia_pixel(old_pixel):
    global new_pixel
    currentred = old_pixel.getRed()
    currentgreen = old_pixel.getGreen()
    currentblue = old_pixel.getBlue()
    new_red = int((currentred * 0.393 + currentgreen * 0.769 + currentblue * 0.189) // 3)
    new_green = int((currentred * 0.349 + currentgreen * 0.686 + currentblue * 0.168) // 3)
    new_blue = int((currentred * 0.272 + currentgreen * 0.534 + currentblue * 0.131) // 3)

    new_pixel = Pixel(new_red, new_green, new_blue)
    return new_pixel

# Open an image
# old_image = FileImage('uss-nc-small.gif')
old_image = FileImage('uss-nc-small.gif')

# Open a window that is twice the size of the original image
image_window = ImageWin("Image Processing", old_image.width * 2, old_image.height)

# Draw the image on the window
old_image.draw(image_window)

# Create a new, blank image
new_image = EmptyImage(old_image.width, old_image.height)

# For each pixel in the original image...
for row in range(old_image.height):
    for col in range(old_image.width):
        # ... get that pixel ...
        old_pixel = old_image.getPixel(col, row)
        # ... flip the pixel ...
        new_pixel = make_sepia_pixel(old_pixel)
        # ... and put that pixel in the new image
        new_image.setPixel(col, row, new_pixel)

# Make sure to put the new image over to the side the right number of pixels
new_image.setPosition(old_image.width + 1, 0)

# Draw the new image
new_image.draw(image_window)

# Wait for a user to click the window to close the image
image_window.exitOnClick()

print( "End of Project 10 by Michael Gain")
