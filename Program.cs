using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo:"modelo 1", imei:"111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "modelo 2", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");