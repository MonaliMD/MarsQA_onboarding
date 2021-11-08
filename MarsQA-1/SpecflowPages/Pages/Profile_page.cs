
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Specflow_task1.SpecflowPages.Pages
{
    class Profile_page
    {
        //public void selectProfilePage(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    IWebElement profileTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[1]/div/a[2]"));
        //    profileTab.Click();
        //}

        public void updateName(IWebDriver driver,string p0, string p1)
        {
            Thread.Sleep(2000);

            IWebElement title = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            Thread.Sleep(2000);
            title.Click();

            IWebElement firstName = driver.FindElement(By.Name("firstName"));
            firstName.Clear();
            firstName.SendKeys(p0);

            IWebElement lastName = driver.FindElement(By.Name("lastName"));
            lastName.Clear();
            lastName.SendKeys(p1);

            IWebElement saveButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            saveButton.Click();

        }
        public string getProfileName(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement updatedProfileName = driver.FindElement(By.ClassName("title"));
            return updatedProfileName.Text;
        }
        //public void addProfileDetails(IWebDriver driver)
        //{
        //    //Add availability
        //    IWebElement abailability = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        //    abailability.Click();

        //    IWebElement selectDropDown1 = driver.FindElement(By.Name("availabiltyType"));
        //    selectDropDown1.Click();

        //    IWebElement optionOne1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
        //    optionOne1.Click();

        //    //Add hours
        //    IWebElement hours = driver.FindElement(By.XPath("//*[@id='account - profile - section]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div"));
        //    hours.Click();

        //    IWebElement selectDropDown2 = driver.FindElement(By.Name("availabiltyHour"));
        //    selectDropDown2.Click();

        //    IWebElement optionOne2 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
        //    optionOne2.Click();

        //    //Add earn Target
        //    IWebElement earnTarget = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div"));
        //    earnTarget.Click();

        //    IWebElement selectDropDown3 = driver.FindElement(By.Name("availabiltyTarget"));
        //    selectDropDown3.Click();

        //    IWebElement optionOne3 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
        //    optionOne3.Click();


        //}

        //Assertions
        //public string getAvailability(IWebDriver driver)
        //{
        //    IWebElement availabilityValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
        //    return availabilityValue.Text;
        //}

        //public string getHours(IWebDriver driver)
        //{
        //    IWebElement hoursValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
        //    return hoursValue.Text;
        //}

        //public string getEarnTarget(IWebDriver driver)
        //{
        //    IWebElement earnTargetValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
        //    return earnTargetValue.Text;
        //}

    }
}
