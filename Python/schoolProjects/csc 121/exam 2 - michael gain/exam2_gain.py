# Michael Gain
# Exam 2 Gains Car Wash
# 9/13/2020

import sys
from PyQt5.QtWidgets import QDialog, QApplication
from PyQt5.uic import loadUi

class MyForm(QDialog):
    
    def __init__(self):
        super().__init__()

        self.ui = loadUi('exam2_gain.ui', self)

        self.radioButtonCarMiniVan.clicked.connect(self.calcTotal)
        self.radioButtonPickupTruck.clicked.connect(self.calcTotal)
        self.radioButtonSUVVan.clicked.connect(self.calcTotal)
        self.checkBoxTurtleWax.clicked.connect(self.calcTotal)
        self.checkBoxCarpet.clicked.connect(self.calcTotal)
        self.checkBoxRainX.clicked.connect(self.calcTotal)

        self.checkBoxRainX.setEnabled(False)

        self.show()


    def calcTotal(self):
        total = 0.0

        if self.radioButtonCarMiniVan.isChecked():
            total += 12.0
        if self.radioButtonPickupTruck.isChecked():
            total += 18.0
        if self.radioButtonSUVVan.isChecked():
            total += 22.0
        if self.checkBoxTurtleWax.isChecked():
            total += 4.0
        if self.checkBoxCarpet.isChecked():
            total += 8.0
        if self.checkBoxRainX.isChecked():
            total += 2.0
        
        self.labelTotal.setText(f'${total}')
            

    def exitMethod(self):
        QApplication.instance().quit()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyForm()
    sys.exit( app.exec_() )
    print("End of Exam 2 Michael Gain")
