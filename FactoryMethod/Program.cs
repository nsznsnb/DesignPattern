using Framework;
using IDCard;

Factory factory = new IDCardFactory();
Product card1 = factory.Create("Tanaka Osamu");
Product card2 = factory.Create("Sato Susumu");

card1.Use();
card2.Use();


