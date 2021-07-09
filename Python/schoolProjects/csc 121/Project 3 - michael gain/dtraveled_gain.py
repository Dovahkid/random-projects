# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date: 9/20/2020
# Assignment: Project 3 - GUI application to calculate distance traveled at speed and number of hours.
# Description: Loads a Qt Toolkit .ui file with the graphical interface, implements
# lListWidget and push buttons to control input and processing.
# -------------------------------------------------------------------------------

import sys
from PyQt5.QtWidgets import QDialog, QInputDialog, QApplication
from PyQt5.uic import loadUi

class MyForm(QDialog):

    def __init__(self):
        super().__init__()
        self.ui = loadUi('dtraveled_gain.ui', self)

        self.pushButtonCalc.clicked.connect(self.calcMethod)
        self.pushButtonExit.clicked.connect(self.exitMethod)

        self.__Mph = tuple()
        self.__Hours = tuple()

        self.show()


    def calcMethod(self):
        self.__Mph = QInputDialog.getInt(self, "Enter MPH", "MPH:", 60, 0, 100, 1)
        self.__Hours = QInputDialog.getInt(self, "Enter Hours", "Hours Traveled:", 0, 0, 100, 1)
        
        self.listWidgetOut.addItem(f"Vehicle Speed: {self.__Mph[0]} MPH")
        self.listWidgetOut.addItem(f"Hours Traveled: {self.__Hours[0]} Hours")
        self.listWidgetOut.addItem(f"Hours\tDistance Traveled")

        for i in range(1, self.__Hours[0] + 1):
            self.listWidgetOut.addItem(f"{i}\t{i * self.__Mph[0]}")
        self.listWidgetOut.addItem(f"Total Distance: {self.__Mph[0] * self.__Hours[0]}")


    def exitMethod(self):
        QApplication.instance().quit()

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyForm()
    print("End of Distance Traveled Project 3 Michael Gain")
    sys.exit(app.exec_())
    