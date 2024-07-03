using Visitor;

Console.WriteLine("Making root entries...");

var rootDir = new DDirectory("root");
var binDir = new DDirectory("bin");
var tmpDir = new DDirectory("tmp");
var usrDir = new DDirectory("usr");
rootDir.Add(usrDir);
rootDir.Add(binDir);
rootDir.Add(tmpDir);
binDir.Add(new FFile("vi",10000));
binDir.Add(new FFile("latex", 20000));
rootDir.Accept(new ListVisitor());
Console.WriteLine();

var yuki = new DDirectory("yuki");
var hanako = new DDirectory("hanako");
var tomura = new DDirectory("tomura");
usrDir.Add(yuki);
usrDir.Add(hanako);
usrDir.Add(tomura);
yuki.Add(new FFile("diary.html", 100));
yuki.Add(new FFile("Compsite.cs", 200));
hanako.Add(new FFile("memo.text", 300));
hanako.Add(new FFile("index.html", 350));
tomura.Add(new FFile("game.doc", 400));
tomura.Add(new FFile("junk.mail", 500));
rootDir.Accept(new ListVisitor());

var ffv = new FileFindVisitor(".html");
rootDir.Accept(ffv);

Console.WriteLine("HTML files are:");
foreach (var f in ffv.GetFoundFiles())
{
    Console.WriteLine(f);
}

Console.WriteLine(rootDir.GetSize());

