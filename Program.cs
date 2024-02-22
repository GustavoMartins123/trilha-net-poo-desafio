using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone: Nokia");
Nokia nokia = new Nokia("12345678900", "Modelo X", "394969301059235", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Smartphone: Iphone");
Iphone iphone = new Iphone("98765432100", "Modelo Z", "203405939110400", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");