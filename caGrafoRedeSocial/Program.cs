// See https://aka.ms/new-console-template for more information
using caGrafoRedeSocial;

Console.WriteLine("Hello, World!");

Pessoa p1 = new Pessoa("Jose", 1);
Pessoa p2 = new Pessoa("Maria", 2);
Pessoa p3 = new Pessoa("Jose", 3);

Grafo grafo = new Grafo();

grafo.insereFim(p1);
grafo.insereFim(p2);
grafo.insereFim(p3);

grafo.adicionaAresta(p1, p2);
grafo.imprimeListaAmigos("Jose");

Console.ReadLine();


