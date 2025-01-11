// Fazendo o upcasting
// Upcasting - Converter uma instância de uma classe derivada para a instância de uma classe base
// Ou seja converter um tipo especializado para um tipo mais geral
using _9Heranca_Upcastingdown;

// O upcasting é possível porque circulo deriva de forma
//Circulo circulo = new Circulo(10, 20); //Upcasting
//Forma forma = circulo;

//circulo.Desenhar();


//Console.WriteLine(forma == circulo);
//Para poder acessar o método PintarCirculo() da classe Circulo temos que fazer o DownCasting de Forma para Circulo.

//Fazendo o downcasting
Circulo circulo = new Circulo(20, 20);
Forma f = circulo; // upcasting

//Convertendo a variável do tipo forma que é f para a instância do tipo Circulo que é circulo
Circulo c = (Circulo)f;

// Agora vai da pra usar os dois métodos tanto da classe pai quanto o da classe filha
c.Desenhar();
c.PintarCirculo();


Console.ReadKey();