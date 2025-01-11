namespace Exercicio02_OOP;

public class LivroFotos
{
    private int numPaginas;


    public LivroFotos()
    {
        numPaginas = 16;
    }

    public LivroFotos(int numPaginas_)
    {
        numPaginas = numPaginas_;
    }

    public int GetNumeroPaginas()
    {
        return numPaginas;
    }
}
