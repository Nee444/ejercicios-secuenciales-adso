double Altura, Base, Area, Perimetro, AreaDoble ;
Console.Write("Digiita el valor de la Base: ");
Base=Convert.ToDouble(Console.ReadLine());
Console.Write("Diga el Valor de Altura: ");
Altura=Convert.ToDouble(Console.ReadLine());
Area = Base * Altura;
Perimetro = (Base * 2) + (Altura * 2);
AreaDoble= (Base*2)*(Altura*3);


Console.WriteLine("el Area del recctangulo es:" + Area);
Console.WriteLine("el perimetro del rectangulos es:" + Perimetro);
Console.WriteLine("el Area del rectangulo Duplicado es:" + AreaDoble);



