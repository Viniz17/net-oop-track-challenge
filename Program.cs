using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Realizando testes com Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "Nokia 3310", imei: "IMEI123", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");
Console.WriteLine("\n");



Console.WriteLine("Realizando testes com Iphone:");
Smartphone iphone = new Iphone(numero: "456", modelo: "Iphone 13", imei: "IMEI456", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

