# Michael Gain
# Project 7
# 11/8/2020

import sys
from PyQt5 import QtSql
from PyQt5.QtSql import QSqlQuery, QSqlRelationalDelegate
from PyQt5.QtWidgets import QDialog,  QApplication, QDataWidgetMapper, QMessageBox
from PyQt5.uic import loadUi
import sqlite3

class MyForm(QDialog):
    def __init__(self):
        super().__init__()
        self.ui = loadUi('veh_maint_gain.ui', self)
       
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
           
        self.model = QtSql.QSqlRelationalTableModel() 
        self.delrow = -1
       
        # Set up the model.
        self.setupModel()

        # Set up the mapper.
        self.mapper = QDataWidgetMapper(self)
        self.mapper.setModel(self.model)

        self.mapper.setItemDelegate(QSqlRelationalDelegate())

        self.mapper.addMapping(self.ui.lineEditNumber, self.model.fieldIndex("maint_num"))
        self.mapper.addMapping(self.ui.dateEditMaintDate, self.model.fieldIndex("maint_date"))
        self.mapper.addMapping(self.ui.lineEditMi, self.model.fieldIndex("maint_mi"))
        self.mapper.addMapping(self.ui.lineEditMaintBy, self.model.fieldIndex("maint_by"))
        self.mapper.addMapping(self.ui.plainTextEditDesc, self.model.fieldIndex("maint_desc"))
        self.mapper.addMapping(self.ui.lineEditCost, self.model.fieldIndex("maint_cost"))
        self.mapper.addMapping(self.ui.lineEditNxDate, self.model.fieldIndex("maint_nxdate"))
        self.mapper.addMapping(self.ui.lineEditNxMi, self.model.fieldIndex("maint_nxmi"))

        self.mapper.addMapping(self.ui.comboBoxVehicle, self.vehicle_index)

        # Connect navigation buttons.
        self.pushButtonPrevious.clicked.connect(self.mapper.toPrevious)
        self.pushButtonNext.clicked.connect(self.mapper.toNext)
        self.mapper.currentIndexChanged.connect(self.updateButtons)
       
        # Connect record editing buttons and exit button
        self.ui.pushButtonAdd.clicked.connect(self.addrow)
        self.ui.pushButtonDelete.clicked.connect(self.deleterow)
        self.ui.pushButtonExit.clicked.connect( self.exitMethod)

        self.mapper.toFirst()

        self.show()
 
    def setupModel(self):
        self.model.setTable('maintenance')
        self.model.setEditStrategy(QtSql.QSqlTableModel.OnFieldChange)

        self.vehicle_index = self.model.fieldIndex("maint_vin")
        self.model.setRelation(self.vehicle_index, QtSql.QSqlRelation("vehicles", "veh_vin", "veh_name"))

        self.model.select()

        self.relModel = self.model.relationModel(self.vehicle_index)
        self.ui.comboBoxVehicle.setModel(self.relModel)
        self.ui.comboBoxVehicle.setModelColumn(self.relModel.fieldIndex("veh_name"))

    def updateButtons(self, row):
        self.ui.pushButtonPrevious.setEnabled(row > 0)
        self.ui.pushButtonNext.setEnabled(row < self.model.rowCount() - 1)
    
    def addrow(self):
        row = self.model.rowCount() # this is one more than the zero-based index so it adds a new row
        self.model.insertRow(row)
        self.mapper.setCurrentIndex(row)
        self.mapper.submit()

    def deleterow(self):
        self.model.removeRow( self.mapper.currentIndex() )
   
    def exitMethod(self):
        self.conn.close()
        print("End of Project 7 by Michael Gain")
        QApplication.instance().quit()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    w = MyForm()
    #window.show()
    sys.exit(app.exec_())