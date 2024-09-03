using DesafioPOO.Models;

Console. WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "2178962478", modelo: "Modelo 1", imei: "2165487498", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Teams");

Console.WriteLine("\n");

Console. WriteLine("IPhone:");
Smartphone iphone = new Iphone(numero: "1512365478", modelo: "Modelo 2", imei: "5515185", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");