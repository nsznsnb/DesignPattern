using Adapter;

//IPrint p = new PrintBanner("Hello");
//p.PrintWeak();
//p.PrintStrong();

IFileIO f = new FileProperties();
try
{
    f.ReadFromFile("file.txt");
    f.SetValue("width", "1024"); 
    f.SetValue("height", "512");
    f.SetValue("depth", "32");
    f.WriteToFile("newfile.txt");
    Console.WriteLine("newfile.txt is created");

}
catch (IOException e)
{
    Console.WriteLine(e.StackTrace);
}