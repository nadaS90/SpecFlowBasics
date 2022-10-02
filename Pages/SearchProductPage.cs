﻿using OpenQA.Selenium;



public class SearchProductPage
{
    public SearchProductPage(IWebDriver driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string SearchTextBoxID = "small-searchterms";
    public const String SearchBtnID = "button.button-1.search-box-button";
    public const String SearchDropDownResultID = "ui-id-1";
    public const String SearchResultID = "Apple MacBook Pro 13-inch";
    #endregion

/*
    IWebElement SearchTextBox => driver.FindElement(By.Id(SearchTextBoxID));
    IWebElement SearchBtn => driver.FindElement(By.CssSelector(SearchBtnID));

    IList<IWebElement> SearchDropDownResult => driver.FindElements(By.Id(SearchDropDownResultID));

    IWebElement SearchResult => driver.FindElement(By.LinkText(SearchResultID));



    public void ProductSearch(String productName)
    {
        SendTxt(SearchTextBox, productName);
        ClickBtn(SearchBtn);
    }

    public void productSearchWithAutoComplete(String searchAutoComplte)
    {
        SendTxt(SearchTextBox, searchAutoComplte);
        try
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        catch (Exception e)
        {
            throw  e;
        }
        SearchDropDownResult.GetItemByIndex(0).Click();
    }
*/
}