// See https://aka.ms/new-console-template for more information
using SMSApp;

StudentBL sBLobj = new StudentBL();
sBLobj.AcceptStudDetails();

int t1; //Total
float p1; //Percentage
sBLobj.CalcResult(out t1 , out p1);
System.Console.WriteLine("Total: {0}", t1);
System.Console.WriteLine("Percentage: {0}", p1);

// System.Console.WriteLine($"Total {sBLobj.CalcTotal()}");
// System.Console.WriteLine($"Percentage {sBLobj.CalcAvg()}");