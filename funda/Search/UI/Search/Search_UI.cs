using OpenQA.Selenium;

namespace Search.UI
{
    public static class Search_UI
    {
        /*Menus*/
        public static readonly By MNU_sale = By.LinkText("For sale");

        public static readonly By MNU_rent = By.LinkText("For rent");

        public static readonly By MNU_newlyBuilt = By.LinkText("Newly built");

        public static readonly By MNU_recreation = By.LinkText("Recreation");

        public static readonly By MNU_europe = By.LinkText("Europe");
        
        /*Inputs*/
        public static readonly By TXT_location = By.Id("autocomplete-input");

        public static readonly By TXT_location_Options = By.XPath("//ul[@id = 'autocomplete-list']/li/span");

        public static readonly By TXT_from = By.XPath("//div/input[@name = 'filter_HuurprijsVan']");

        public static readonly By TXT_to = By.XPath("//div/input[@name = 'filter_HuurprijsTot']");

        /*DropDownList*/
        public static readonly By DDL_ray = By.Id("Straal");

        public static readonly By DDL_from = By.XPath("//label[text() = 'From']/ancestor-or-self::div[@class = 'range-filter-selector__preset']/div/select");

       
        public static readonly By DDL_from_Selected = By.XPath("//label[text() = 'From']/ancestor-or-self::div[@class = 'range-filter-selector__preset']/div/select/option[@selected = '']");

         public static readonly By DDL_from_Options = By.XPath("//label[text() = 'From']/ancestor-or-self::div[@class = 'range-filter-selector__preset']/div/select/option");

        public static readonly By DDL_to = By.XPath("//label[text() = 'To']/ancestor-or-self::div[@class = 'range-filter-selector__preset']/div/select");

        public static readonly By DDL_To_Selected = By.XPath("//label[text() = 'To']/ancestor-or-self::div[@class = 'range-filter-selector__preset']/div/select/option[@selected = '']");

         public static readonly By DDL_to_Options = By.XPath("//label[text() = 'To']/ancestor-or-self::div[@class = 'range-filter-selector__preset']/div/select/option");

        /*Button*/
        public static readonly By BTN_search = By.Id("//button[text() = 'Search']");

        /*Label*/
        public static readonly By LBL_lastSearch = By.Id("//div[@class = 'search-block__last-query']/span");

        /*Label*/
        public static readonly By LBL_lastSearch_result = By.Id("//div[@class = 'search-block__last-query']/a");

        /*Label*/
        //VER concatenação
        public static readonly By LBL_lastSearch_result_sugestion = By.Id("//div[normalize-space(@class)='search-block__last-query']");





    }
   
}
