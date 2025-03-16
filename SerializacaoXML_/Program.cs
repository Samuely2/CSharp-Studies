
using SerializaoXML;
using System.Xml.Serialization;

Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 20);
var caminhoArquivo = @"c:\dados\Serializados";

XmlSerializer serializer