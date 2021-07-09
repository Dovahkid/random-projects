#-------------------------------------------------------------------------------
# Name:        setup_messagebox.py
# Purpose:     A module to simplify using the messagebox function.
#              This will import the proper modules for PYTHON 2 and 3
#
# Author:      Ken.Clifton
#
# Created:     13/09/2015
# Copyright:   (c) Ken Clifton 2015
#-------------------------------------------------------------------------------
import sys  # used to get Python version
python_version = sys.version_info.major  # get major version, i.e. 2 or 3
if python_version >= 3:
	import tkinter    # note on Python 2 this was: import Tkinter
	from tkinter import messagebox  # note on Python 2 this was: import tkMessageBox
	# MUST HAVE main window for this to work inside an editor such as LightTable
	window = tkinter.Tk()
else:
	import Tkinter   # module name in Python 2x
	import tkMessageBox as messagebox # module name in Python 2x
	window = Tkinter.Tk()  # setup main window for Python 2x

window.attributes("-topmost", True)
window.option_add("*Dialog.msg.wrapLength", "10i") # set messagebox length/width to 10 inches
window.wm_withdraw()  # hide the parent window

# Center the messagebox in the screen
window.geometry("1x1+"+str(window.winfo_screenwidth()//2)+"+"+str(window.winfo_screenheight()//2))