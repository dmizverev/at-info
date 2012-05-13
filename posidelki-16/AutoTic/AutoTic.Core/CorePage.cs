using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using WatiN.Core;

namespace AutoTic.Core
{
    public abstract class CorePage
    {

        public IE Bro { get { return WebBrowser.Instance; } }

        public abstract void Show();
        public abstract bool Exists();
        
        // Returns the element object by provided string
        public TElement GetPageElementByDescription<TElement>(string expectedDescription)
        {
            string WatinDescriptionAttribute = "WatiN.Core.DescriptionAttribute";

            TElement result = default(TElement);
            foreach (PropertyInfo info in this.GetType().GetProperties())
            {
                if (info.CanRead)
                {
                    var customAttributesData = info.GetCustomAttributesData();
                    string attrDescription = null;

                    foreach (var attr in customAttributesData)
                    {
                        string attributeFullName = attr.Constructor.DeclaringType.ToString();
                        if (attributeFullName == WatinDescriptionAttribute)
                        {
                            attrDescription = (string)attr.ConstructorArguments[0].Value;
                            break;
                        }
                    }

                    if (attrDescription != null && attrDescription == expectedDescription)
                    {
                        object o = info.GetValue(this, null);
                        result = (TElement)o;
                        break;
                    }
                }
            }
            return result;
        }


        public Button GetButton(string elementDescription)
        {
            Button element = GetPageElementByDescription<Button>(elementDescription);
            if (element == null)
            {
                string error = String.Format("Element was not found: Description: {0}\n PageClass:{1}",
                                              elementDescription, this.GetType().ToString());
                throw new ArgumentException(error);
            }
            return element;
        }


        public TextField GetTextField(string elementDescription)
        {
            TextField element = GetPageElementByDescription<TextField>(elementDescription);
            if (element == null)
            {
                string error = String.Format("Element was not found: Description: {0}\n PageClass:{1}",
                                              elementDescription, this.GetType().ToString());
                throw new ArgumentException(error);
            }
            return element;
        }
        public Span GetSpan(string elementDescription)
        {
            Span element = GetPageElementByDescription<Span>(elementDescription);
            if (element == null)
            {
                string error = String.Format("Element was not found: Description: {0}\n PageClass: {1}",
                                              elementDescription, this.GetType().ToString());
                throw new ArgumentException(error);
            }
            return element;
        }
        public Link GetLink(string elementDescription)
        {
            Link element = GetPageElementByDescription<Link>(elementDescription);
            if (element == null)
            {
                string error = String.Format("Element was not found: Description: {0}\n PageClass:{1}",
                                              elementDescription, this.GetType().ToString());
                throw new ArgumentException(error);
            }
            return element;
        }
    }
}
