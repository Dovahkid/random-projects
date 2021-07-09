# Exam 4
# Michael Gain
# 10/11/2020

import sys
from PyQt5.QtWidgets import QDialog, QInputDialog, QApplication
from PyQt5.uic import loadUi
from PyQt5 import QtCore


class MyForm(QDialog):
    def __init__(self):
        super().__init__()
        self.ui = loadUi("exam4_gain.ui", self)

        self.calendarWidget.selectionChanged.connect(self.convertMethod)
        self.pushButtonConvert.clicked.connect(self.convertMethod)

        self.pushButtonExit.clicked.connect(self.exitMethod)

        self.convertMethod()
        self.show()


    def convertMethod(self):
        date = self.calendarWidget.selectedDate().toJulianDay()
        self.labelJulianDate.setText(f"{date:,}")
        

    def exitMethod(self):
        print("Michael Gain end of Exam 4")
        QApplication.instance().quit()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyForm()
    sys.exit(app.exec_())
