using System;

class MainClass {
  public static void Main (string[] args) {
    
    decimal fee;
    double hours;
    decimal total = 0M;


Console.Write("Enter number of hours");
hours = Convert.ToDouble(Console.ReadLine());

while(hours > 0.0)
{
fee = CalculateCharges(hours);
total = total + fee;
System.Console.WriteLine("Current Charges : ${0} Total Recepits: ${1}\n",fee, total);
Console.Write("Enter number of hours ( a negative or zero to quit) : ");
hours = Convert.ToDouble(Console.ReadLine());
}
}
public static decimal CalculateCharges(double hours)
{
decimal charge = 2M;

if(hours <= 3)
charge = 2M;

else
{
charge=charge+((System.Convert.ToDecimal(hours)-3)*System.Convert.ToDecimal(0.5));
if(charge > 10M)
charge = 10M;
}

return charge;

  }
}