using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia( numero: "5656-5656", modelo: "C20", imei: "111111111", memoria: 64 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
Console.WriteLine("");
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "8989-8989", modelo: "X", imei: "222222222", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");