from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.desired_capabilities import DesiredCapabilities
 
# This is the only code you need to edit in your existing scripts.
# The command_executor tells the test to run on Sauce, while the desired_capabilities
# parameter tells us which browsers and OS to spin up.
desired_cap = {
    'platform': "Mac OS X 10.9",
    'browserName': "chrome",
    'version': "31",
}
driver = webdriver.Remote(
   command_executor='http://claudiamarquez:03e669cf-8fe4-46b7-a1ac-59a63b96420a@ondemand.saucelabs.com:80/wd/hub',
   desired_capabilities=desired_cap)
 
# This is your test logic. You can add multiple tests here.
+driver.implicitly_wait(10)
 +driver.get("http://www.google.com")
 +if not "Google" in driver.title:
 +    raise Exception("Unable to load google page!")
 +elem = driver.find_element_by_name("q")
 +elem.send_keys("Sauce Labs")
 +elem.submit()
driver.quit()