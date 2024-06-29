using Composite;

Console.WriteLine("Making root entries...");
var rootdir = new DDirectory("root");
var bindir = new DDirectory("bin");
var tmpdir = new DDirectory("tmp");
var usrdir = new DDirectory("usr");
rootdir.Add(bindir);
rootdir.Add(tmpdir);
rootdir.Add(usrdir);
bindir.Add(new FFile("vi", 10000));
bindir.Add(new FFile("latext", 20000));
rootdir.PrintList();
Console.WriteLine();

Console.WriteLine("Making user entries...");
DDirectory user1 = new DDirectory("user1");
DDirectory user2 = new DDirectory("user2");
DDirectory user3 = new DDirectory("user3");
usrdir.Add(user1);
usrdir.Add(user2);
usrdir.Add(user3);
user1.Add(new FFile("diary.html", 100));
user1.Add(new FFile("composite.cs", 200));
user2.Add(new FFile("memo.text", 300));
user3.Add(new FFile("game.doc", 400));
user3.Add(new FFile("junk.mail", 500));
rootdir.PrintList();

Console.WriteLine("user1 = " + user1.GetFullPath());

