﻿using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowBasics.Helpers;

namespace SpecFlowBasics.Common_Locators;

public class CommonLocators : PageBase
{
    public CommonLocators(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string RegisterLinkID = "Register";
    public const String LoginLinkID = "a.ico-login";
    public const string AddProductWishListID = "add-to-wishlist-button-4";
    public const string PopSucessMsgID = "p.content";
    public const string CloseMsgID = "span.close";
    public const string CompareProductsID = "div.compare-products";
    public const string AddToCartID = "add-to-cart-button-4";
    public const String WishLisBtnID = "add-to-wishlist-button-18";
    public const String WishListLinkID = "a[href=\"/wishlist\"]";
    public const String ChangeCurancyID = "customerCurrency";
    public const String ResultMsgID = "div.result";
    public const String CurrencyID = "div.prices";
    public const String LogOutID = "a.ico-logout";




    #endregion


    IWebElement RegisterLink => driver.FindElement(By.LinkText(RegisterLinkID));
    IWebElement LoginLink => driver.FindElement(By.CssSelector(LoginLinkID));
    public IWebElement AddProductWishListBtn => driver.FindElement(By.Id(AddProductWishListID));
    public IWebElement PopSucessMsg => driver.FindElement(By.CssSelector(PopSucessMsgID));
    public IWebElement CloseMsgBtn => driver.FindElement(By.CssSelector(CloseMsgID));
    IWebElement CompareProductsBtn => driver.FindElement(By.CssSelector(CompareProductsID));
    IWebElement AddToCartBtn => driver.FindElement(By.Id(AddToCartID));
    IWebElement WishListLink => driver.FindElement(By.CssSelector(WishListLinkID));
    IWebElement WishListBtn => driver.FindElement(By.Id(WishLisBtnID));
    IWebElement ChangeCurrency => driver.FindElement(By.Id(ChangeCurancyID));
    public IWebElement ResultMsg => driver.FindElement(By.CssSelector(ResultMsgID));
    public IList<IWebElement> Currency => driver.FindElements(By.CssSelector(CurrencyID));
    public IWebElement LogOutLink => driver.FindElement(By.CssSelector(LogOutID));










    public void ClickRegisterLink()
    {
        ClickBtn(RegisterLink);
    }

    public void ClickLoginPage()
    {
        ClickBtn(LoginLink);
    }

    public void UsedAddProductWishList()
    {
        ClickBtn(AddProductWishListBtn);
    }

    public void ClosePopUpMsg()
    {
        ClickBtn(CloseMsgBtn);
    }
    public void UserAddProductToCompare()
    {
        ClickBtn(CompareProductsBtn);
    }

    public void UserAddProductToCart()
    {
        ClickBtn(AddToCartBtn);
    }

    public void UserNavigateToWishListPage()
    {
        ClickBtn(WishListLink);
    }

    public void ClickWishListBtn()
    {
        ClickBtn(WishListBtn);
    }
    public void ClickChangeCurrency()
    {
        Select = new SelectElement(ChangeCurrency);
    }
    public void UserChooserEuro()
    {
        Select.SelectByText("Euro");
    }

    public void ClickAddCart()
    {
        ClickBtn(AddToCartBtn);
    }

    public void UserLogOut()
    {
        ClickBtn(LogOutLink);
    }

}