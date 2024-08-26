using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 01", imei: "1212121212", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine();

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "8912345", modelo: "Iphone 15", imei: "1212121212", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
// TODO: Realizar os testes com as classes Nokia e Iphone