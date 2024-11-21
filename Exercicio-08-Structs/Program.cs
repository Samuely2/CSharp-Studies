Console.WriteLine();

Console.ReadLine();


struct Cliente()
{
    public string Nome {  get; set; }
    public string Email { get; set; }
    
    private int idade;
    public int Idade
    { 
        get { return idade; }
        set
        {
            if (Idade < 18)
            {
                Idade = 18;
            }
        }
    }
}
