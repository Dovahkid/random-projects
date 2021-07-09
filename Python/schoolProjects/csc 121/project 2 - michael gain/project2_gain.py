# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date: 9/13/2020
# Assignment: Project 2 - GUI application to calculate a car's gas mileage.
# Description: Loads a Qt Toolkit .ui file with the graphical interface, implements
# line edits, labels and push buttons to control input and processing.
# -------------------------------------------------------------------------------

import sys
from PyQt5.QtWidgets import QDialog, QApplication
from PyQt5.uic import loadUi

class MyForm(QDialog):
    
    def __init__(self):
        super().__init__()

        self.ui = loadUi('mpg_gain.ui', self)

        self.pushButtonExit.clicked.connect(self.exitMethod)
        self.pushButtonCalculate.clicked.connect(self.calcMPG)
        self.pushButtonClear.clicked.connect(self.clearMethod)

        self.show()


    def calcMPG(self):
        mpg = int(self.lineEditMiles.text()) / int(self.lineEditGallons.text())
        self.labelMPG.setText(f'{mpg}') 


    def clearMethod(self):
        self.lineEditGallons.setText('')
        self.lineEditMiles.setText('')
        self.labelMPG.setText('')
        self.lineEditGallons.setFocus()


    def exitMethod(self):
        QApplication.instance().quit()

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyForm()
    sys.exit( app.exec_() )
    print("End of Project 2 Michael Gain")
