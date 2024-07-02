
using Decorator;

var b1 = new StringDisplay("Hello, world.");
var b2 = new UpDownBorder(b1, '-');
var b3 = new FullBorder(b2);

b1.Show();
b2.Show();
b3.Show();

var b4 = new SideBorder(
            new UpDownBorder(
                new FullBorder(
                    new SideBorder(
                        new FullBorder(
                            new StringDisplay("Hello, world.")
                        ),
                        '*'
                    )
                ),
                '|'
            ),
            '/'
        );
b4.Show();

var md = new MultiStringDisplay();
md.Add("Hi!");
md.Add("Good morning!");
md.Add("Good night!");
md.Show();

var d1 = new SideBorder(md, '#');
d1.Show();

var d2 = new FullBorder(md);
d2.Show();