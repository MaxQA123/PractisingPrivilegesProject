﻿using PractisingPrivileges.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.Helpers
{
    public class SwitchingJScriptExecutorHelper
    {
        [AllureStep("OpenNewTab")]
        public SwitchingJScriptExecutorHelper OpenNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.open();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            return this;
        }

        [AllureStep("CloseNewTab")]
        public SwitchingJScriptExecutorHelper CloseNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.close();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.First());

            return this;
        }
    }

    public class ScrollingJScriptExecutorHelper
    {
        [AllureStep("ScrollToElement")]
        public static IWebElement ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

            return element;
        }

        [AllureStep("ScrollToDownWebPage")]
        public static void ScrollToDownWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }

        [AllureStep("ScrollToUpWebPage")]
        public static void ScrollToUpWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, -1000)");
        }
    }

    public class ButtonJScriptExecutorHelper
    {
        public static IWebElement ClickOnHiddenElement(IWebElement hiddenElement)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver.FindElement(By.XPath("//input[@placeholder= 'Name']"));
            js.ExecuteScript("arguments[0].click();", hiddenElement);

            return hiddenElement;
        }
    }
}
