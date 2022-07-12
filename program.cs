Console.Write("number");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("number");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("number");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numA > max) max = numA; 
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.Write ("max= ");
Console.WriteLine(max);