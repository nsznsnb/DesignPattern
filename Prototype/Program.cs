
using Framework;
using Prototype;

var manager = new Manager();
var upen = new UnderlinePen('-');
var mbox = new MessageBox('*');
var sbox = new MessageBox('/');

manager.Register("strong message", upen);
manager.Register("warning box", mbox);
manager.Register("slash box", sbox);

IProduct p1 = manager.Create("strong message");
p1.Use("Hello, world.");

IProduct p2 = manager.Create("warning box");
p2.Use("Hello, world.");

IProduct p3 = manager.Create("slash box");
p3.Use("Hello, world");