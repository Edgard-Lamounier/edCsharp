// See https://aka.ms/new-console-template for more information

// criar uma Pilha

using caPilhaDinamica;

Pilha p = new Pilha(); // p é um objeto da classe Pilha

p.Insere(3);
p.Insere(5);
p.Insere(8);

p.Imprime();

Console.WriteLine("Desempilhando o " + p.Remove());

p.Imprime();
