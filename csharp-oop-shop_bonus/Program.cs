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
Console.WriteLine("Codice con Pad Left: {0}", p1.padLeft());
Console.WriteLine("-----------------------------------");

Prodotto p2 = new Prodotto("Tavolo", "Tavolo in ferro battuto da giardino", 30, 15);

Console.WriteLine("Nome: {0}", p2.getNome());
Console.WriteLine("Descrizione: {0}", p2.getDescrizione());
Console.WriteLine("Prezzo: {0}", p2.getPrezzo());
Console.WriteLine("Prezzo + iva: {0}", p2.getPrezzoConIva());
Console.WriteLine("Nome completo: {0}", p2.getNomeEsteso());
Console.WriteLine("-----------------------------------");
Console.WriteLine("Codice con Pad Left: {0}", p2.padLeft());
Console.WriteLine("-----------------------------------");

Prodotto p3 = new Prodotto("Gazebo", "Gazebo in ferro battuto", 150, 20);

Console.WriteLine("Nome: {0}", p3.getNome());
Console.WriteLine("Descrizione: {0}", p3.getDescrizione());
Console.WriteLine("Prezzo: {0}", p3.getPrezzo());
Console.WriteLine("Prezzo + iva: {0}", p3.getPrezzoConIva());
Console.WriteLine("Nome completo: {0}", p3.getNomeEsteso());
Console.WriteLine("-----------------------------------");
Console.WriteLine("Codice con Pad Left: {0}", p3.padLeft());
Console.WriteLine("-----------------------------------");