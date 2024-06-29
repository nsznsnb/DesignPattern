
using Builder;

if (args.Length == 0)
{
    Usage();
    Console.ReadLine();
    return;
}

if (args[0] == "text")
{
    var textBuilder = new TextBuilder();
    var director = new Director(textBuilder);
    director.Construct();
    var result = textBuilder.GetTextResult();
    Console.WriteLine(result);
}
else if (args[0] == "html")
{
    var htmlBuilder = new HtmlBuilder();
    var director = new Director(htmlBuilder);
    director.Construct();
    string fileName = htmlBuilder.GetHTMLResult();
    Console.WriteLine("HTMLファイル" + fileName + "が作成されました。");
}
else if (args[0] == "md")
{
    var markdownBuilder = new MarkdownBuilder();    
    var director = new Director(markdownBuilder);
    director.Construct();
    var fileName = markdownBuilder.GetMarkdownResult();
    Console.WriteLine("Markdownファイル" + fileName + "が作成されました。");
}
else
{
    Usage();
    Console.ReadLine();
}

static void Usage()
{
    Console.WriteLine("Usage: コマンドライン引数「text」指定 　=>　テキストで文書作成 ");
    Console.WriteLine("Usage: コマンドライン引数「html」指定 　=>　HTMLファイルで文書作成 ");
    Console.WriteLine("Usage: コマンドライン引数「md」指定 　=>　Markdownファイルで文書作成 ");

}