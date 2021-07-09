# Name:                  imageViewer_gain.py
# Purpose:               Project 5 Implement File Dialog, and Color Dialogs
# Author:                Michael Gain


import sys

from PyQt5.QtWidgets import QMainWindow,  QApplication,  QFileDialog, QColorDialog, QMessageBox
from PyQt5.QtGui import QPixmap, QPalette
from PyQt5.uic import loadUi
import pathlib

class MyForm(QMainWindow):
    def __init__(self):
        super().__init__()
        self.ui = loadUi('imageViewer_gain.ui', self)
        
        self.ui.action_Open.triggered.connect(self.displayMethod)
    
        self.ui.actionE_xit.triggered.connect(self.exitMethod)
        
        self.ui.actionMenu_Color.triggered.connect(self.menuColorMethod)
        
        self.ui.actionBackground_Color.triggered.connect(self.menuBackgroundMethod)
        self.show()


    def displayMethod(self):
        fName = QFileDialog.getOpenFileName(parent=self, \
            caption="Select File to Open", \
            filter="Image Files (*.png *.bmp *.jpg *.gif);; All files (*.*)")
        path = fName[0]
        pixmap = QPixmap(path)

        self.labelImage.setPixmap(pixmap)


    def menuColorMethod(self):
        initial_color = self.ui.menubar.palette().color(QPalette.Foreground)
        color = QColorDialog.getColor( initial_color, self, "Pick A Color for the Menubar"  )
        if color.isValid():
            pal = self.ui.menubar.palette()
            pal.setColor( self.ui.menubar.foregroundRole(), color )            
            self.ui.menubar.setPalette( pal )
            

    def menuBackgroundMethod(self):
        initial_color = self.ui.frameColor.palette().color(QPalette.Background)
        color = QColorDialog.getColor( initial_color, self, "Pick A Color for the Frame"  )
        if color.isValid():
            pal = self.ui.frameColor.palette()
            pal.setColor( self.ui.frameColor.backgroundRole(), color )            
            self.ui.frameColor.setPalette( pal )
            self.ui.frameColor.setAutoFillBackground(True)

            
    def exitMethod(self):
        quitBox = QMessageBox
        question = quitBox.question(self,'', "Really Exit?", quitBox.Yes | quitBox.No)

        if question == quitBox.Yes:
            QApplication.instance().quit()

if __name__=="__main__":    
    app = QApplication(sys.argv)
    w = MyForm()
    sys.exit(app.exec_())  

