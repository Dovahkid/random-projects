#---------------------------------------------
#
#   Michael Gain
#   Exam 6 Part 2
#
#---------------------------------------------
import sys
from PyQt5 import QtCore,  QtSql
from PyQt5.QtWidgets import QDialog, QApplication, QMessageBox
from PyQt5.uic import loadUi

class MyForm(QDialog):
    def __init__(self):
        super().__init__()
        
        self.ui = loadUi('veh_vehicles_gain.ui', self)
        
        self.conn = QtSql.QSqlDatabase.addDatabase('QSQLITE')
        self.conn.setDatabaseName('veh_log.db')
        if not self.conn.open():
            QMessageBox.critical(None, "Cannot open database",
                "Unable to establish a database connection.\n"
                "This example needs SQLite support. Please read the Qt SQL "
                "driver documentation for information how to build it.\n\n"
                "Click Cancel to exit.",
                QMessageBox.Cancel)
            QApplication.instance().quit()
            
        self.model = QtSql.QSqlTableModel()

        self.delrow = -1
        self.initializeModel()
        
        self.view1 = self.createView()
        self.view1.clicked.connect(self.findrow)
        
        self.ui.pushButtonAdd.clicked.connect(self.addrow)
        self.ui.pushButtonDel.clicked.connect(self.deleterow)
        self.ui.pushButtonExit.clicked.connect( self.exitMethod)
        self.show()

    def initializeModel(self):
        self.model.setTable('vehicles')
        self.model.setEditStrategy(QtSql.QSqlTableModel.OnFieldChange)
        self.model.select()
        self.model.setHeaderData(0, QtCore.Qt.Horizontal, "VEH_VIN")
        self.model.setHeaderData(1, QtCore.Qt.Horizontal, "VEH_NAME")
        self.model.setHeaderData(2, QtCore.Qt.Horizontal, "VEH_MAKE")
        self.model.setHeaderData(3, QtCore.Qt.Horizontal, "VEH_YEAR")
        self.model.setHeaderData(4, QtCore.Qt.Horizontal, "VEH_TAG")
        self.model.setHeaderData(5, QtCore.Qt.Horizontal, "VEH_PURCH_MI")
        self.model.setHeaderData(6, QtCore.Qt.Horizontal, "VEH_PURCH_DATE")
        self.model.setHeaderData(7, QtCore.Qt.Horizontal, "VEH_NUM_DOORS")
        self.model.setHeaderData(8, QtCore.Qt.Horizontal, "VEH_ENG_SIZE")

    def createView(self):
        view = self.ui.tableView
        view.setModel(self.model)
        view.setColumnWidth(1, 450)
        return view

    def addrow(self):
        print(self.model.rowCount())
        ret = self.model.insertRows(self.model.rowCount(), 1)
        print(ret)

    def findrow(self, i):
        self.delrow = i.row()

    def deleterow(self):
        self.model.removeRow( self.view1.currentIndex().row()) 
        
    def exitMethod(self):
        self.conn.close()
        print("End Of Exam 6 by Michael Gain")
        QApplication.instance().quit()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    w = MyForm()
    sys.exit(app.exec_())

