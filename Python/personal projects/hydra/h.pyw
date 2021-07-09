import sys
import os
from PyQt5.QtGui import QKeySequence
from PyQt5.QtWidgets import QApplication, QWidget, QShortcut

class App(QWidget):

    def __init__(self):
        super().__init__()
        self.title = 'Hydra'
        self.left = 100
        self.top = 100
        self.width = 640
        self.height = 480
        self.shortcut = QShortcut(QKeySequence("Ctrl+X"), self)
        self.shortcut.activated.connect(self.on_shortcut)
        self.initUI()
        
    def initUI(self):
        self.setWindowTitle(self.title)
        self.setGeometry(self.left, self.top, self.width, self.height)
        self.show()

    def on_shortcut(self):
        self.close()

    def closeEvent(self, event):
        os.system("h.pyw")
    
if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = App()
    sys.exit(app.exec_())