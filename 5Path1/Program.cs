
string path1 = "c:\\dados"; // caminho absoluto
string path2 = "txt\\poesia.txt"; // caminho relativo

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine("\nCaminho Combinado: " + pathCombinado);

Console.WriteLine("\nNome do diretório : " + Path.GetDirectoryName(pathCombinado));
Console.WriteLine("\nExtensão : " + Path.GetExtension(pathCombinado));
Console.WriteLine("\nNome do arquivo : " + Path.GetFileName(pathCombinado));
Console.WriteLine("\nNome do arquivo sem extensão : " + Path.GetFileNameWithoutExtension(pathCombinado));
Console.WriteLine("\nPossui extensão? : " + Path.HasExtension(pathCombinado));
Console.WriteLine("\nContém a raiz? : " + Path.IsPathRooted(pathCombinado));
Console.WriteLine("\nNova extensão do arquivo: " + Path.ChangeExtension(pathCombinado, ".doc"));
Console.WriteLine("\nRaiz: " + Path.GetPathRoot(pathCombinado));

char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();

Console.ReadLine();