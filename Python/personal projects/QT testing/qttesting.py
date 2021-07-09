import sys

from PyQt5.QtWidgets import QDialog, QApplication
from PyQt5.uic import loadUi

class MyForm(QDialog):
    def __init__(self):
        super().__init__()
       
        self.ui = loadUi('qttesting.ui', self)
       
        self.show()

    def exitMethod(self):
        QApplication.instance().quit()

        
if __name__=="__main__":   
    app = QApplication(sys.argv)
    w = MyForm()
    sys.exit( app.exec_() )  
