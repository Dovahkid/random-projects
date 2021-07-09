import json
import pathlib

class LoginInfo():

    def __init__(self):
        self.__info = {}

        self.__loadValues()

        
    def __loadValues(self):
        if not pathlib.Path('login.json').is_file():
            self.__create_file()
        
        if self.__is_file_empty():
            self.__create_file()

        path = pathlib.Path("login.json")
        with path.open(mode='r') as loginfile:
            self.__info = json.load(loginfile)


    def __is_file_empty(self):
        with open('login.json', 'r') as loginFile:
            if not loginFile.read(1):
                return True
            return False


    def __create_file(self):
        with open('login.json', 'w') as loginFile:
            self.__info['login'] = {
                'username': 'blank', 
                'password': 'blank', 
                'email': 'blank', 
                'last_name': 'blank', 
                'first_name': 'blank'}

            if self.__is_file_empty():
                json.dump(self.__info, loginFile)


    def setUsername(self, username):
        self.__info['login']['username'] = username

        with open('login.json', 'w') as loginFile:
            json.dump(self.__info, loginFile)


    def setPassword(self, password):
        self.__info['login']['password'] = password

        with open('login.json', 'w') as loginFile:
            json.dump(self.__info, loginFile)


    def setEmail(self, email):
        self.__info['login']['email'] = email

        with open('login.json', 'w') as loginFile:
            json.dump(self.__info, loginFile)


    def setFirstName(self, name):
        self.__info['login']['first_name'] = name

        with open('login.json', 'w') as loginFile:
            json.dump(self.__info, loginFile)


    def setlastName(self, name):
        self.__info['login']['last_name'] = name

        with open('login.json', 'w') as loginFile:
            json.dump(self.__info, loginFile)


    def getUsername(self):
        return self.__info['login']['username']


    def getPassword(self):
        return self.__info['login']['password']


    def getEmail(self):
        return self.__info['login']['email']


    def getFirstName(self):
        return self.__info['login']['first_name']


    def getlastName(self):
        return self.__info['login']['last_name']


if __name__ == "__main__":

    loginInfo = LoginInfo()
