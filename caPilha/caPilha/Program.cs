// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using caPilha;

Pilha p1 = new Pilha(); // criando uma pilha

//if (p1.estaVazia())
//    Console.WriteLine("Pilha Vazia");

//else Console.WriteLine("Pilha não Vazia");

p1.insere(3);
p1.insere(5);
p1.insere(8);
p1.insere(2);

p1.imprime();

Console.WriteLine("Elemento removido:  " + p1.remove());

p1.imprime();


