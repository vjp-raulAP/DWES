Console.WriteLine("Package weight (kg): ");   //  Muestra por pantalla 
string? input = Console.ReadLine();           // "string" -- texto , "?"-- indic que puede ser nulo , "input" -- nombre de la variable , Console.ReadLine()-- Lee teclado
double weightKg = double.Parse(input!);       //convierto en numero el imput

string nombre = "";
const double baseCost = 3.50;                 //constante  llamo baseCost
const double costPerKg = 0.80;                //cosntante  llamo costPerKg
double totalCost = baseCost + (weightKg * costPerKg);
Console.WriteLine($"Shipping cost:{totalCost:C2}");  //$".." permite meter una variable dentro de texto.  ":C" formatea el número como moneda con 2 decimales

//1. Añade una variable bool isExpress que sume un recargo fijo de 5€ si es true.

bool isExpress = true;
const double expressRate = 5.00;

if (isExpress)
{
    totalCost += expressRate;  //preguntar si se puede hacer
}
Console.WriteLine($"Shipping cost whith isExpress: {totalCost:C2}");

//2.Muestra también el peso convertido a libras (weightKg * 2.20462)

double pesoLibras = (weightKg * 2.20462);
// double kgToLib(double weightKg)
Console.WriteLine($"El peso en libras es {pesoLibras:C2}");

//clase 17/09/2026

//TryParse

//ejercicio guarD claude


static decimal CalculateDiscount(Customer customer, Order order)
{
    decimal discount = 0;

    if (customer != null)
    {
        Console.WriteLine("Customer is NULL");
        return discount;
    }
    
    if (!customer.Active)
    { 
    Console.WriteLine("Customer is Inactive ");
    return discount;
    }
        
    if (order == null)
    {
        Console.WriteLine("the order is null ");
        return discount;
    }
    if (order.Total <= 0)
    {
        Console.WriteLine("Order has no total");
    return discount;
    }
    if (customer.IsVip)
    {
        return order.Total > 1000;
             order.Total * 0.20m;
             order.Total * 0.10m;
    }

    return order.Total * 0.05m;
}


Console.Write("Enter quantity for SKU-4471: ");
string? rawQuantity = Console.ReadLine();
if (!int.TryParse(rawQuantity, out int quantity) || quantity <= 0)
{
Console.WriteLine("Invalid quantity. Order line rejected.");
return;
}
Console.WriteLine($"Added {quantity} units of SKU-4471 to the order.");





class Customer

{
public bool Active { get; internal set; }
public bool IsVip { get; internal set; }
}
class Order
{
public int Total { get; internal set; }
}