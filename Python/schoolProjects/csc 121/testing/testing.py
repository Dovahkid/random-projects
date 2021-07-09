import sys
from PyQt5.QtWidgets import QMainWindow, QApplication, QAction, QFileDialog
class MyForm(QMainWindow):

    def saveFileDialog(self):
        options = QFileDialog.Options()
        options |= QFileDialog.DontUseNativeDialog
        fileName, _ = QFileDialog.getSaveFileName(self,"QFileDialog.getSaveFileName()","","All Files (*);;Text Files (*.txt)", options=options)
        print(_)