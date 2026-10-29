Double C, F, Kelvin;
Console.Write("Digite los Celciues que quiere convertir: ");
C=Convert.ToDouble(Console.ReadLine());
F = (C * 1.8 + 32);
Kelvin = (C + 273.15);
Console.WriteLine("los grados °c convertidos a °F son: " + F);
Console.WriteLine("los gracos °c convertidos a Kelvin son:" + Kelvin);
