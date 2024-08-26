using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("12121", "asasasa", "1212", 400);
Iphone iphone = new Iphone("12121", "asasasa", "1212", 400);


nokia.Ligar();
nokia.ReceberLigacao();

iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine($"Numero Nokia {nokia.Numero}");
Console.WriteLine($"Numero Iphone {iphone.Numero}");


nokia.InstalarAplicativo("Twitter");
iphone.InstalarAplicativo("Youtube");