# Exam 2 
# Michael Gain
# 9/26/2020

import sys
from PyQt5.QtWidgets import QDialog, QInputDialog, QApplication
from PyQt5.uic import loadUi
from PyQt5.QtGui import QIcon, QPixmap
import pathlib

class MyForm(QDialog):
    def __init__(self):
        super().__init__()
        self.ui = loadUi("exam3_gain.ui", self)

        self.ui.comboBoxState.currentIndexChanged.connect(self.flagInfo)

        self.states = {
            "AK": {
                "file": "ak_fi.gif", 
                "year": "1927", 
                "description": "7 Stars to form the Big Dipper and 1 star to represent the North Star."
                },
            "AZ": {
                "file": "az_fi.gif", 
                "year": "1917", 
                "description": "Copper Star, Red and Yellow Stripes, Blue bottom half."
                },
            "NC": {
                "file": "nc_fi.gif", 
                "year": "1885", 
                "description": "Star, glit scroll, NC, red and white stripes, blue union."
                },
            "NY": {
                "file": "ny_fi.gif", 
                "year": "1778", 
                "description": "Excelsior, Ladies of justice, Eagle"},
            "FL": {
                "file": "fl_fi.gif", 
                "year": "1868", 
                "description":"Red X, Gold seal with person flowers palm tree boat sunshine and water."
                }
        }

        self.flagInfo()

        self.show()


    def PathBuilder(self, p):
        return pathlib.Path(f"./flags/{p}").as_posix()


    def flagInfo(self):
        self.state = self.comboBoxState.currentText() # Gets state from dropdown box

        path = self.PathBuilder(self.states[self.state]["file"]) # Creates the path to be passed to the QPixmap
        self.flagPixmap = QPixmap(path) # This makes the QPixmap that can then be displayed in the label
        self.labelImage.setPixmap(self.flagPixmap) # Updates label
        
        self.labelYearAdopted.setText(self.states[self.state]["year"])
        self.labelMajorItems.setText(self.states[self.state]["description"])


    def exitMethod(self):
        QApplication.instance().quit()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyForm()
    print("Michael Gain end of Exam 3")
    sys.exit(app.exec_())
