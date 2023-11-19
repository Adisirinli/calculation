using System.Security.Cryptography.X509Certificates;

DateTime now = DateTime.Now;
Console.WriteLine("hazirki vaxt.." + now);

Console.WriteLine("ili daxil edin");
int year = int.Parse(Console.ReadLine());

while (true)
{
    if (year == now.Year)
    {
        Console.WriteLine("duzgun daxil etdiniz");
        break;

    }
    else
    {

        Console.WriteLine("sef daxil etdiniz...");
       
        year = int.Parse(Console.ReadLine());

    }
}