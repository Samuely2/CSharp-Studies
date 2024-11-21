Console.WriteLine("## Argumentos Nomeados");

Email email = new Email();

email.Enviar("teste@email.com", "urgente", "Reuniao de orçamento");

// Argumentos nomeados

email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião Orçamento");
email.Enviar(destino: "Urgente", assunto: "teste@email.com", titulo: "Reunião Orçamento");
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião Orçamento");



Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}