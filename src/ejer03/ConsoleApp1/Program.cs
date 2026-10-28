double Nota1, Nota2, Nota3, Definitiva;
Console.WriteLine("Ingrese la primera nota: ");
Nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese la segunda nota: ");
Nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la tercera nota: ");
Nota3 = Convert.ToDouble(Console.ReadLine());

Definitiva = (Nota1 * 0.25) + (Nota2 * 0.35) + (Nota3 * 0.40);
Console.WriteLine("La nota definitiva es: " + Definitiva);