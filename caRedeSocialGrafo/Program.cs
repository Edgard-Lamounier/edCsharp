// See https://aka.ms/new-console-template for more information
using caRedeSocialGrafo;

Console.WriteLine("Hello, World!");

// criando as pessoas da Rede Social
Pessoa p1 = new Pessoa("Joao", 1);
Pessoa p2 = new Pessoa("Maria", 2);
Pessoa p3 = new Pessoa("Carla", 3);
Pessoa p4 = new Pessoa("Jose", 4);

// associando as Pessoas como nó no Grafo
Grafo redeSocial = new Grafo();

// criando os nós do grafo
redeSocial.insereFim(p1);
redeSocial.insereFim(p2);
redeSocial.insereFim(p3);
redeSocial.insereFim(p4);

// criando as arestas do grafo
redeSocial.addAresta(p1, p2);
redeSocial.addAresta(p1, p3);
redeSocial.addAresta(p1, p4);
redeSocial.addAresta(p2, p3);
redeSocial.addAresta(p3, p4);

redeSocial.imprimeListaAmigos("Joao");



