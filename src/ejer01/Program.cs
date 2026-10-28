int a, b, Cambio;
Console.Write("Ingrese el primer número: ");
a=int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
b=int.Parse(Console.ReadLine());

Cambio = a;
a = b;  
b = Cambio;
Console.WriteLine("Cambio de los valores de a y b.");
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);