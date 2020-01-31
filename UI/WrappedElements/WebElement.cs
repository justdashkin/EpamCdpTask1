using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace UI.WrappedElements
{
    public class WebElement
    {
        private readonly By _elementLocator;
        private IWebElement _element;
        public readonly string ElementName;

        public WebElement(By locator, string elementName)
        {
            _elementLocator = locator;
            this.ElementName = elementName;
        }

        public WebElement(IWebElement element, string elementName)
        {
            _element = element;
            this.ElementName = elementName;
        }

        protected IWebElement GetElement()
        {
            if (_element == null)
            {
                _element = Driver.Driver.GetDriver().FindElement(_elementLocator);
            }
            else
            {
                try
                {
                    bool isDisplayed = _element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    _element = Driver.Driver.GetDriver().FindElement(_elementLocator);
                }
            }
            Hover();
            return _element;
        }

        #region Actions

        public void Click()
        {
            GetElement().Click();
        }

        public void Hover()
        {
            Actions action = new Actions(Driver.Driver.GetDriver());
            action.MoveToElement(_element).Perform();
        }
        #endregion

        #region Verifications
        public bool IsPresent()
        {
            try
            {
                GetElement();
                return true;
            }
            catch (NoSuchElementException) { return false; }
        }
        #endregion
    }
}
