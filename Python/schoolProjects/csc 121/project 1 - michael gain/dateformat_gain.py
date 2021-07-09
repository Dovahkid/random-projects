'''
Michael Gain
8/19/2020
Assignment: Project 1 - Creating a date class with private data, and public methods and properties.
Description: Defines a date class, with private data for year, month, day, a constructor that can set those values, public methods to set the values, and public methods to return the date in various formats.
'''
import sys

class myDate():
    def __init__ (self, month, day, year):
        self.__month = month
        self.__day = day
        self.__year = year


    def setMonth(self, m):
        try:
            month = int(m)
            if(month not in range(1, 13)):
                raise Exception("Invalid month value. Must from 1-12")
        except Exception as ex:
            sys.exit(ex)
        else:
            self.__month = m
        

    def setDay(self, d):
        try:
            day = int(d)
            if(day not in range(1, 32)):
                raise Exception("Invalid day value. Day must be from 1-31")
        except Exception as ex:
            sys.exit(ex)
        else:
            self.__day = d


    def setYear(self, y):
        try:
            year = int(y)
            if(year <= 1700):
                raise Exception("Invalid year value. Day must be greater than or equal to 1700")
        except Exception as ex:
            sys.exit(ex)
        else:
            self.__year = y


    def getMonth(self):
        return self.__month
    

    def getDay(self):
        return self.__day


    def getYear(self):
        return self.__year


    def MDYYYY(self):
        return "{}/{}/{}".format(self.__month, self.__day, self.__year)
    

    def MDY(self):
        return "{}/{}/{}".format(self.__month, self.__day, str(self.__year)[-2:])


    def YMD(self):
        return "{}/{}/{}".format(self.__year, self.__month, self.__day)



if __name__ == "__main__":
    print("\nInstantiates a myDate object with values (4, 1, 2019). Demonstrates changing values through mutators and viewing values with accessors.")

    today = myDate(4, 1, 2019)

    print("\nDate set Month: 6 Day: 17 Year: 2019")

    today.setYear(2019)
    today.setMonth(6)
    today.setDay(17)
    print(f"MDYYYY: {today.MDYYYY()}")

    today.setYear(2021)
    today.setMonth(7)
    today.setDay(19)

    print("\nNew date: Month: 7 Day: 19 Year:2021")

    print(f"MDY: {today.MDY()}")
    print(f"MDY: {today.YMD()}")

    print("\n\nEnd of Date Formatting Project, Original Work of: Michael Gain")
    input()
