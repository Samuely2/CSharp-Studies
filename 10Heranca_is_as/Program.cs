using _10Heranca_is_as;
using _9Heranca_Upcastingdown;

//Object carroObj = new Carro();
//
//try
//{
//    var x = (string)carroObj;
//}
//catch (Exception ex)
//{
//    Console.WriteLine("\nA conversão falhou...\n");
//    Console.WriteLine(ex.Message);
//}

// Usando o operador as

//Object carroObj = new Carro();

//var x = carroObj as string;

//if (x != null)
//{
//    Console.WriteLine("Converteu obj para string");
//}
//else
//{
//    Console.WriteLine("Não foi possível converter, x é null");
//}

//Fazendo o downcasting

//Circulo circulo = new Circulo();
//Forma forma = circulo; //upcasting

////Fazendo o downcasting usando o operador as 
//Circulo c = forma as Circulo; // downcasting

//if (c!= null)
//{
//    c.PintarCirculo();
//}
//else
//{
//    Console.WriteLine("Operação de downcasting é inválida");
//}

Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo) // Verifica se o downcast é possivel
{
    Console.WriteLine("Converteu Forma para Circulo\n");
    //((Circulo)forma).PintarCirculo();

    var tipo = forma as Circulo;
    tipo?.PintarCirculo();

}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}


Console.ReadKey();

class Carro
{ }