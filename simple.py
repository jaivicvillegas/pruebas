from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.desired_capabilities import DesiredCapabilities
 
# This is the only code you need to edit in your existing scripts.
# The command_executor tells the test to run on Sauce, while the desired_capabilities
# parameter tells us which browsers and OS to spin up.
desired_cap = {
    'platform': "Windows 10",
    'browserName': "chrome",
    'version': "59",
}
driver = webdriver.Remote(
   command_executor='http://claudiamarquez:03e669cf-8fe4-46b7-a1ac-59a63b96420a@ondemand.saucelabs.com:80/wd/hub',
   desired_capabilities=desired_cap)
 
# This is your test logic. You can add multiple tests here.
driver.implicitly_wait(100)
driver.get("https://www.esika.com/pe/")
if not "Home" in driver.title:
    raise Exception("Unable to load Home page!")
elem = driver.find_element_by_name("text")
elem.send_keys("corrector")
elem.submit()
 
# This is where you tell Sauce Labs to stop running tests on your behalf.
# It's important so that you aren't billed after your test finishes.
driver.quit()