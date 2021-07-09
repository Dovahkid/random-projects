# -------------------------------------------------------------------------------
# Name: Michael Gain
# Date: 8/30/2020
# Assignment: Exam 1 - Import Project1's date class, override the constructor, add new mutator method .setDateSep() and accessor method .dateSep() and override accessor .MDYYYY().
# Description: Inherits Project1's date class, with private data for year, month, day, a constructor that initializes those values, public methods to set the values, and public methods to return the date in various formats.
# -------------------------------------------------------------------------------

import dateformat_gain

class examDate(dateformat_gain.myDate):

    def __init__(self):
        self.__dateSep = ""

        super().__init__(1, 1, 1700)

    def setDateSep(self, dateSep):
        self.__dateSep = dateSep

    def getDateSep(self):
        return self.__dateSep

    def MDYYYY(self):
        return f"{self.getMonth()}{self.getDateSep()}{self.getDay()}{self.getDateSep()}{self.getYear()}"


if __name__ == "__main__":
    print("Instantiating object examToday, storing using .setMonth(6) .setDay(17) .setYear(2019) .setDateSep('-')")

    examToday = examDate()

    examToday.setMonth(6)
    examToday.setDay(17)
    examToday.setYear(2019)
    examToday.setDateSep('-')
    
    print(f"Showing date in format MM{examToday.getDateSep()}DD{examToday.getDateSep()}YYYY: {examToday.MDYYYY()}")

    print("End of Exam 1 part 2 by Michael Gain")
