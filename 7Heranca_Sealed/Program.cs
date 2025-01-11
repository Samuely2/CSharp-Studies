


//Cliente cli = new();

//cli.Nome = "José";
//cli.ExibeNome();

Console.ReadKey();

//O modificador sealed bloqueia a herança
//sealed class Pessoa
//{
//    public string? Nome { get; set; }
//    public void ExibeNome()
//    {
//        Console.WriteLine($"Meu nome é {Nome} ");
//    }
//}

//class Cliente
//{
//    public void ExibeNome()
//    {
//        //Console.WriteLine($"\n Nome do cliente : {Nome}");
//    }
//} 

class ClasseBase
{
    protected virtual void Metodo1() // Esse método vai poder ser sobreescrito na classe derivada
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2() // Usa quando quer sianlizar quando um membro de uma classe base quer ser substitudo
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    // Sobreescrevendo o método da classe base
    protected sealed override void Metodo1() // com o modificador sealed impede que esse método seja sobreescrito
    {
        Console.WriteLine("Classe1.Metodo1()");

    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }

class Classe2: Classe1
{
    // Não pode sobreescrever porque o método é selado
    //protected override void Metodo1()
    //{

    //}
        //pode sobreescrever porque o método não é selado
        protected override void Metodo2()
        {

        }
}
}