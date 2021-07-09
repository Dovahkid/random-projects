import sys
from PyQt5.QtWidgets import *
from PyQt5.QtCore import pyqtSlot
from PyQt5.QtGui import QIcon
from PyQt5.uic import loadUi

from webscraper import webscraper
from LoginInfo import LoginInfo

class App(QMainWindow):

    def __init__(self):
        super().__init__()
        
        self.ui = loadUi("LoginGui.ui", self)

        self.pushButtonStart.clicked.connect(self.__start)

        self.pushButtonSetLogin.clicked.connect(self.__set_login_info)

        self.show()


    def __start(self):
        process = webscraper()
        process.run_task()

    def __set_login_info(self):
        loginInfo = LoginInfo()
        
        username = self.lineEditUsername.text()
        password = self.lineEditPassword.text()
        email = self.lineEditEmail.text()
        firstname = self.lineEditFirstName.text()
        lastname = self.lineEditLastName.text()

        loginInfo.setEmail(email)
        loginInfo.setFirstName(firstname)
        loginInfo.setlastName(lastname)
        loginInfo.setUsername(username)
        loginInfo.setPassword(password)

        self.statusBar().showMessage('Success updating info!')



if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = App()
    sys.exit(app.exec_())
