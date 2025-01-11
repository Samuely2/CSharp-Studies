using  _13Interfaces_Exercicio;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

//Para acessar um método que tem implementação em uma interface que tá sendo herdada por uma classe concreta, tem que criar
//a instância da classe que está herdando a interface e converter ela para o tipo de interface.
ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

Console.ReadKey();