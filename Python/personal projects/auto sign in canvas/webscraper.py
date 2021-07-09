import LoginInfo

from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from selenium.common.exceptions import TimeoutException

class webscraper():

    def __init__(self):
        self.loginInfo = LoginInfo.LoginInfo()

        self.userName = self.loginInfo.getUsername()
        self.password = self.loginInfo.getPassword()
        self.email = self.loginInfo.getEmail()
        self.lastName = self.loginInfo.getlastName()
        self.firstName = self.loginInfo.getFirstName()
        self.delay = 4

    
    def run_task(self):
        self.open_browser()
        self.gmail_login()
        self.cabarrus_login()
        self.confirm_identity_button()
        self.fill_out_attendance()

        self.browser.close()

        
    def open_browser(self):

        self.browser = webdriver.Chrome()
        self.browser.get('https://docs.google.com/forms/d/e/1FAIpQLSeocxO0AA7f05PWiAPKDYt2RC-AfBFPm5QOgFX9-Th7JIm0uA/viewform')


    def gmail_login(self):
        try:
            myElem = WebDriverWait(self.browser, self.delay).until(EC.presence_of_element_located((By.ID, 'identifierId')))
            print("Page is ready!")
        except TimeoutException:
            print("Loading took too much time!")

        gmailBoxInput = self.browser.find_element_by_id("identifierId")
        gmailBoxInput.send_keys(self.email)

        gmailBoxInput.send_keys(Keys.RETURN)


    def cabarrus_login(self):
        try:
            myElem = WebDriverWait(self.browser, self.delay).until(EC.presence_of_element_located((By.ID, 'userNameInput')))
            print("Page is ready!")
        except TimeoutException:
            print("Loading took too much time!")

        userNameBox = self.browser.find_element_by_id('userNameInput')
        passwordBox = self.browser.find_element_by_id('passwordInput')
        submitButton = self.browser.find_element_by_id('submitButton')

        userNameBox.send_keys(self.userName)
        passwordBox.send_keys(self.password)

        submitButton.click()


    def confirm_identity_button(self):
        try:
            myElem = WebDriverWait(self.browser, self.delay).until(EC.presence_of_element_located((By.CLASS_NAME, 'VfPpkd-LgbsSe')))
            print("Page is ready!")
        except TimeoutException:
            print("Loading took too much time!")

        googleConfirmButton = self.browser.find_elements_by_class_name('VfPpkd-LgbsSe')
        
        for btn in googleConfirmButton:
            if btn.text == "Continue":
                btn.click()


    def fill_out_attendance(self):
        try:
            myElem = WebDriverWait(self.browser, self.delay).until(EC.presence_of_element_located((By.CLASS_NAME, 'exportInput')))
            print("Page is ready!")
        except TimeoutException:
            print("Loading took too much time!")

        nameBoxes = self.browser.find_elements_by_class_name('exportInput')

        nameBoxes[0].send_keys(self.lastName)
        nameBoxes[1].send_keys(self.firstName)

        presentButton = self.browser.find_element_by_class_name('appsMaterialWizToggleRadiogroupElContainer')
        presentButton.click()

        submitButton = self.browser.find_element_by_class_name('appsMaterialWizButtonPaperbuttonContent')
        submitButton.click()

        input()

    
if __name__ == "__main__":
    scrapper = webscraper()
    scrapper.run_task()
    
