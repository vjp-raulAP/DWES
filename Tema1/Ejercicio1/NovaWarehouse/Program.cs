Console.WriteLine("Package weight (kg): ");   //  Muestra por pantalla 
string? input = Console.ReadLine();           // "string" -- texto , "?"-- indic que puede ser nulo , "input" -- nombre de la variable , Console.ReadLine()-- Lee teclado
double weightKg = double.Parse(input!);       //convierto en numero el imput


const double baseCost = 3.50;                 //constante  llamo baseCost
const double costPerKg = 0.80;                //cosntante  llamo costPerKg
double totalCost = baseCost + (weightKg * costPerKg);
Console.WriteLine($"Shipping cost:{totalCost:C2}");  //$".." permite meter una variable dentro de texto.  ":C" formatea el número como moneda con 2 decimales

//1. Añade una variable bool isExpress que sume un recargo fi jo de 5€ si es true.

bool isExpress = true;

if (isExpress)
{
    totalCost += 5;  //preguntar si se puede hacer
}
Console.WriteLine($"Shipping cost whith isExpress: {totalCost:C2}");
bool iss = false;