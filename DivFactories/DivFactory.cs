using Factory;

namespace DivFactories
{
    public class DivFactory : Factory.Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new DivLink(caption, url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new DivPage(title, author);
        }

        public override Tray CreateTray(string caption)
        {
            return new DivTray(caption);
        }
    }
}
