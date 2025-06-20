using DesafioPOO.Models;

Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia("123456", "Nokia C20", "111111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-----------------------------\n");

Console.WriteLine("Testando iPhone:");
Smartphone iphone = new Iphone("987654", "iPhone 13", "999999999", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
