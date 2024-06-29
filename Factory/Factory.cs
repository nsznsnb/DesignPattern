using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;
            try
            {
                Assembly assembly = Assembly.LoadFrom(className.Split('.')[0]);
                Type type = assembly.GetType(className);
                factory = (Factory)Activator.CreateInstance(type);
                return factory;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);

        public Page CreateYahooPage()
        {
            var link = CreateLink("Yahoo!", "https://www.yahoo.com/");
            var page = CreatePage("Yahoo!", "Yahoo!");
            page.Add(link);
            return page;
        }
    }
}
