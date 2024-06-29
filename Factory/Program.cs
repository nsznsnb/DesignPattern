using Factory;

if (args.Length != 2)
{
    Console.WriteLine("Usage: コマンドライン引数に出力ファイル名とFactoryクラス名を指定してください。 ");
    Console.WriteLine("Example 1: list.html Listfactories.ListFactory");
    Console.WriteLine("Example 2: list.html Divfactories.DivFactory");

    return;
}

string fileName = args[0];  
string className = args[1];

var factory = Factory.Factory.GetFactory(className);

var blog1 = factory.CreateLink("Blog 1", "https://example.com/blog1");
var blog2 = factory.CreateLink("Blog 2", "https://example.com/blog2");
var blog3 = factory.CreateLink("Blog 3", "https://example.com/blog3");

var blogTray = factory.CreateTray("Blog Site");
blogTray.Add(blog1);
blogTray.Add(blog2);
blogTray.Add(blog3);


var news1 = factory.CreateLink("News 1", "https://example.com/new1");
var news2 = factory.CreateLink("News 2", "https://example.com/new2");
var news3 = factory.CreateTray("News 3");
news3.Add(factory.CreateLink("News 3 (US)", "https://example.com/news3us"));
news3.Add(factory.CreateLink("News 3 (Japan)", "https://example.com/news3jp"));

var newsTray = factory.CreateTray("News Site");
newsTray.Add(news1);
newsTray.Add(news2);
newsTray.Add(news3);

var page = factory.CreatePage("Blog and News", "Tanaka Satoru");
page.Add(blogTray);
page.Add(newsTray);

page.Output(fileName);