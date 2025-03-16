using System.Runtime.Serialization.Formatters.Binary;

namespace SerializaoBinariaObsoleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 20);
            var caminhoArquivo = @"c:\dados\Serializados";

            using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(stream, aluno1);

                Console.WriteLine("Tecle algo para realizar a Desserialização");
                Console.ReadKey();
                stream.Seek(0, SeekOrigin.Begin);
                var alunoDesserializado = (Aluno)bf.Deserialize(stream);
                Console.WriteLine(alunoDesserializado.Name);
                
            }
        }
    }
}
