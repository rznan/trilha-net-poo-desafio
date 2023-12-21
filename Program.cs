using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone\n");
Smartphone iphone = new Iphone(numero:"123456789", modelo:"Mod01", IMEI:"212334455667", memoria:16);
Console.WriteLine(iphone);
iphone.Ligar();
iphone.InstalarAplicativo("Reddit");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia\n");
Smartphone nokia = new Nokia(numero:"987654321", modelo:"Mod12", IMEI:"766554343212", memoria:128);
Console.WriteLine(nokia);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");
