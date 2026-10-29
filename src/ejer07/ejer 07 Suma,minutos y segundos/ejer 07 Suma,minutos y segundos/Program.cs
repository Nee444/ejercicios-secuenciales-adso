int Hora, minutos, segundos, SeguntosT;
Console.WriteLine(" escribe cuantos segundos te gustaria convertir: ");
SeguntosT = Convert.ToInt32(Console.ReadLine());
Hora = SeguntosT / 3600;
minutos=SeguntosT%3600/ 60;
segundos=SeguntosT%60;
Console.WriteLine("en horas: " + Hora);
Console.WriteLine("en minutos: " +  minutos);
Console.WriteLine("en segundos: " +  segundos);
