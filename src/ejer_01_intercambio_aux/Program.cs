//Intercambio con va//riable auxiliar
//Lea dos números enteros y guárdelos en las variables a y b. Luego intercambie sus contenidos, de modo que a quede con el valor original de b y b con el de a. Solo puede usar una variable adicional. Muestre el resultado.
int a, b, c;
Console.Write("ingrese el primer valor A: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("ingrese el primer valor B: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" los valores originales son: A:{a} y B: {b}");
c = a;
a = b;
b = c;

Console.WriteLine($" los valores cambiados son: A:{ a } y B: { b }");
