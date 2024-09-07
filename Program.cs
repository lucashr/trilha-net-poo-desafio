using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123456", "NK47", "00323146781", 1000);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("AppFinancasXpto");

Console.WriteLine();

Iphone iphone = new Iphone("789456", "IFONE363", "0066811743", 3250);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IJogosXpto");
