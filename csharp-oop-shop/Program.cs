// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using csharp_oop_shop;

Prodotto p1 = new Prodotto("Sedia", "Sedia pieghevole da giardino", 15, 10);

//Console.WriteLine("Codice Prodotto: {0}", p1.getCodiceProdotto());

Console.WriteLine("Nome: {0}", p1.getNome());
Console.WriteLine("Descrizione: {0}", p1.getDescrizione());
Console.WriteLine("Prezzo: {0}", p1.getPrezzo());
Console.WriteLine("Prezzo + iva: {0}", p1.getPrezzoConIva());
Console.WriteLine("Nome completo: {0}", p1.getNomeEsteso());
Console.WriteLine("-----------------------------------");

