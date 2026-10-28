//intercambio sin variable
//auxiliar el mismom reto anterior, pero prohibido usar variables adicionales: solo las variables a y b, operaciones aritmeticas y asignaciones. si se puede descubralo.
int a, b;

Console.Write("digite el primer numero: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("digite el segundo numero: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write($"los valores sin intercambiar son son: A {a} y B: {b} ");

a = a + b;
b = a - b;
a = a - b;


Console.WriteLine($" los valores intercambiables son: A {a} y B: {b} ");
