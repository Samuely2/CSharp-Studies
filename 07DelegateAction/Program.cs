Console.WriteLine("Informe um número inteiro ; ");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> dobra = x => Console.WriteLine(x * 2);
//Recebendo um parâmetro x onde vai dobrar (multiplicar por 2), e não
//retorna da.
dobra(numero);
Console.ReadKey();

//Ele é usado para implementar callbacks, ou seja, retorno de chamadas
//onde em eventeos é necessário passar uma ação como argumento para ser executada
//quando um evento ocorrer