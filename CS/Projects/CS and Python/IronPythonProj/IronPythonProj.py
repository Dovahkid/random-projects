import sys
from System.Collections.Generic import *

class TestClass(object):
    testVar = sys.argv[1]

    def TestMethod(self):
        #return List[str]([testVar]) #This shows you can use .NET types in python
        return TestClass.testVar + " I went through Python!"