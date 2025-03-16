
using SerializaoXML;
using System.Xml.Serialization;

Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 20);
var caminhoArquivo = @"c:\dados\serializados\AlunoSerializado.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, aluno1);
}
Console.WriteLine("Objeto serializado para XML com sucesso!");
Console.ReadKey();