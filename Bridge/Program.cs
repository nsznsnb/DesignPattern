using Bridge;

var d1 = new Display(new StringDisplayImpl("Hello, Japan."));
var d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
var d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe"));
var d4 = new RandomDisplay(new StringDisplayImpl("Hello, ABC"));
var d5 = new Display(new FileDisplayImpl("test.txt"));
var d6 = new IncreaseDisplay(new CharDisplayImpl('<', '*', '>'),1);
var d7 = new IncreaseDisplay(new CharDisplayImpl('|', '#', '-'),2);


d1.DDisplay();
d2.DDisplay();
d3.DDisplay();
d3.MultiDisplay(5);
d4.RRandomDisplay(10);
d5.DDisplay();
d6.IIncreaseDisplay(4);
d7.IIncreaseDisplay(6);