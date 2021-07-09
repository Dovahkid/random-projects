# Project 4
# Michael Gain
# 10/4/2020

import sys
from PyQt5.QtWidgets import QDialog, QInputDialog, QApplication
from PyQt5.uic import loadUi
from PyQt5.QtGui import QIcon, QPixmap
from PyQt5 import QtCore
from random import randint
from time import sleep
import pathlib

class MyForm(QDialog):
    def __init__(self):
        super().__init__()
        self.ui = loadUi("dice_gain.ui", self)

        self.pushButtonRoll.clicked.connect(self.rollMethod)
        self.pushButtonExit.clicked.connect(self.exitMethod)

        self.dice = {
            1 : "Die1.BMP",
            2 : "Die2.BMP",
            3 : "Die3.BMP",
            4 : "Die4.BMP",
            5 : "Die5.BMP",
            6 : "Die6.BMP"
        }

        timerLCD = QtCore.QTimer(self)
        timerLCD.timeout.connect(self.showLCD)
        timerLCD.start(1000)

        self.showLCD()

        self.show()


    def showLCD(self):
        time = QtCore.QTime.currentTime()
        text = time.toString('hh:mm:ss')
        self.lcdNumber.display(text)


    def displayMethod(self, label):
        num = randint(1,6)
        path = self.PathBuilder(self.dice[num])
        pixmap = QPixmap(path)

        label.setPixmap(pixmap)


    def rollMethod(self):
        
        for i in range(1,7):
            self.displayMethod(self.labelDie1)
            self.displayMethod(self.labelDie2)
            
            sleep(.08)

            self.repaint()


    def PathBuilder(self, p):
        return pathlib.Path(f"./dice/{p}").as_posix()


    def exitMethod(self):
        print("Michael Gain end of Project 4")
        QApplication.instance().quit()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyForm()
    sys.exit(app.exec_())
