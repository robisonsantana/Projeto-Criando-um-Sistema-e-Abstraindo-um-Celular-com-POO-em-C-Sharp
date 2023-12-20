using DesafioPOO.Models;

// Exibir informações sobre o smartphone da Nokia:
Console.WriteLine("Smartphone da Nokia:");
Nokia nokia = new Nokia(numero: "(11) 91234-5678", modelo: "Nokia G60 NK108", imei: "128468242459134", memoria: 128);
nokia.ExibirModelo("Nokia G60 NK108");
nokia.ExibirImei("128468242459134");
nokia.ExibirMemoria(128);
nokia.ExibirNumero("(11) 91234-5678");
nokia.Ligar();
nokia.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

// Exibir informações sobre o smartphone da Apple:
Console.WriteLine("Smartphone da Apple:");
Iphone iphone = new Iphone(numero: "(77) 99876-5432", modelo: "iPhone 15 Pro Max", imei: "649656249658613", memoria: 1024);
iphone.ExibirModelo("iPhone 15 Pro Max");
iphone.ExibirImei("649656249658613");
iphone.ExibirMemoria(1024);
iphone.ExibirNumero("(77) 99876-5432");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Apple Music");