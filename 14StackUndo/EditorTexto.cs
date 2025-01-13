public class EditorTexto
{
    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    // Cada caracter que digitari vai incremenetando
    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"Texto : " + texto);
    }

    // Método que desfaz a última operação
    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0, texto.Length - 1);
            Console.WriteLine($"Texto : {texto}");
        }
    }
}