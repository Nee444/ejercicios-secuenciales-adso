Double R, A, P;
const double Pi = 3.1416;

Console.Write("Ingrese el radio ");
R = Convert.ToDouble(Console.ReadLine());

A = Pi * Math.Pow(R, 2);
P = 2 * Pi * R;

Console.WriteLine($"El area es {A:F2} y el Perimetro es {P:F2}");