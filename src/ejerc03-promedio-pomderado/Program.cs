using System.Xml;

double n1, n2, n3, promedioPonderado;
Console.WriteLine("la primera nota es: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("la primera nota es: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("la primera nota es: ");
n3 = Convert.ToDouble(Console.ReadLine());

promedioPonderado = (n1 * 0.25) + (n2 * 0.35) + (n3 * 0.4);

Console.WriteLine($"su promedio ponderado es {promedioPonderado}");