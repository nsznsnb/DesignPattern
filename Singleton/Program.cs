using Singleton;
using System.Runtime.CompilerServices;

Console.WriteLine("Start.");
Task.Run(() => Run("A"));
Task.Run(() => Run("B"));
Task.Run(() => Run("C"));



Console.WriteLine("End.");

static void Run(string id)
{
    var obj = SingletonB.GetInstance();
    Console.WriteLine(id + ": obj = " + RuntimeHelpers.GetHashCode(obj));
}


//var obj1 = SingletonA.GetInstance();
//var obj2 = SingletonA.GetInstance();

//if (obj1.Equals(obj2))
//{
//    Console.WriteLine("obj1とobj2は同じインスタンスです。");
//}
//else
//{
//    Console.WriteLine("obj1とobj2は異なるインスタンスです。");

//}


//var ticketMaker = TicketMaker.GetInstance();
//Console.WriteLine("チケット番号：" +  ticketMaker.GetNextTicketNumber());
//Console.WriteLine("チケット番号：" + ticketMaker.GetNextTicketNumber());

//var ticketMaker2 = TicketMaker.GetInstance();
//Console.WriteLine("チケット番号：" + ticketMaker.GetNextTicketNumber());


//var alpha1 = Triple.GetInstance("ALPHA");
//var beta1 = Triple.GetInstance("BETA");
//var gamma1 = Triple.GetInstance("GAMMA");
//var alpha2 = Triple.GetInstance("ALPHA");
//var beta2 = Triple.GetInstance("BETA");
//var gamma2 = Triple.GetInstance("GAMMA");
//Console.WriteLine(alpha1.Equals(alpha2) ? $"alpha1 == alpha2({alpha1})" : "alpha1 != alpha2");
//Console.WriteLine(beta1.Equals(beta2) ? $"beta1 == beta2({beta1})" : "beta1 != beta2");
//Console.WriteLine(alpha1.Equals(alpha2) ? $"gamma1 == gamma2({gamma1})" : "gamma1 != gamma2");


