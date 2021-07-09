from cImage import *
from tkinter import *

from tkinter import filedialog

def remove_red_eye(old_pixel):
    if old_pixel.getRed() >= old_pixel.getBlue() and old_pixel.getRed() >= old_pixel.getGreen() \
            and old_pixel.getBlue() <= 90 and old_pixel.getGreen() <= 90 \
            and old_pixel.getRed() >= 150 and old_pixel.getRed() >= 0:
        new_red = 0
    else:
        new_red = old_pixel.getRed()
    new_blue = old_pixel.getBlue()
    new_green = old_pixel.getGreen()
    new_pixel = Pixel(new_red, new_green, new_blue)
    return new_pixel

def browseFiles(): 
    filename = filedialog.askopenfilename(initialdir = "/", 
                                          title = "Select a File", 
                                          filetypes = (("GIFS", 
                                                        "*.gif*"), 
                                                       ("all files", 
                                                        "*.*"))) 
    
    return filename

filename = browseFiles()

image = FileImage(filename)
window = ImageWin('Red Eye Remover', image.width * 2, image.height)
image.draw(window)
image2 = EmptyImage(image.width, image.height)

for r in range(image.height):
    for c in range(image.width):
        pixel = image.getPixel(c, r)
        pixel2 = remove_red_eye(pixel)
        image2.setPixel(c, r, pixel2)

image2.setPosition(image.width + 1, 0)

image2.draw(window)

window.exitOnClick()