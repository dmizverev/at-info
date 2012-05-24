using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace AutoTic.Tests.SimpleTestWatiN
{
    [Binding]
    public class Yandex_Search_Page_Steps
    {

        private static IE WebBrowser;

        [Given(@"Я на главной странице Яндекса")]
        public void GivenIAmOnTheGoogleHomePage()
        {
            WebBrowser = new IE();
            WebBrowser.GoTo(@"http://yandex.ru");
        }

        [Then(@"заголовок страницы поисковой выдачи должен содержать ""(.+?)""")]
        public void ThenTheSearchPageTitleShouldHaveTheWord(string expectedWord)
        {
            string pageTitle = WebBrowser.Title;
            StringAssert.Contains(pageTitle, expectedWord);
        }


        public void СпиМояРадостьУсни(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }
        
        [When(@"я ищу ""(.+?)""")]
        public void WhenISearchForAt_Info(string searchPhrase)
        {
            TextField txtSearchBox = WebBrowser.TextField("text");
            txtSearchBox.TypeText(searchPhrase);
            Button btnSearch = WebBrowser.Button(Find.By("tabindex", "20"));
            btnSearch.Click();

            СпиМояРадостьУсни(3000);

        }
    }
}
