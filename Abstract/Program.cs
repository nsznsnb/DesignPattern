using Abstract;

IDisplay d1 = new CharDisplay('H');
IDisplay d2 = new StringDisplay("Hello, World.");

d1.Display();
d2.Display();