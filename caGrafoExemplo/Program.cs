// See https://aka.ms/new-console-template for more information
using caGrafoExemplo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        GrafoLista<Pessoa> listaGrafo = new GrafoLista<Pessoa>(); 

        Pessoa p1 = new Pessoa("Jose", 1);
        Pessoa p2 = new Pessoa("Maria", 2);
        Pessoa p3 = new Pessoa("Joao", 3);

        // tornando estas pessoas em nós no Grafo
        listaGrafo.insereFim(p1);
        listaGrafo.insereFim(p2);
        listaGrafo.insereFim(p3);

        NoGrafo<Pessoa> found = listaGrafo.encontraNoh("Jose");

        if (found != null)
            Console.Write("Encontrei o nó do José!");
        else
            Console.WriteLine("Não achei o José!");

        // listaGrafo.adicionaAresta("José", "Maria");



    }
}