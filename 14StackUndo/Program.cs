Console.WriteLine("\n### Stack - Undo###");

EditorTexto editor = new EditorTexto();
Console.WriteLine("\nDigitando...\n");
editor.DigitarChar('S');
editor.DigitarChar('A');
editor.DigitarChar('M');
editor.DigitarChar('U');
editor.DigitarChar('E');
editor.DigitarChar('L');

Console.WriteLine("\nFazendo o Undo...\n");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando...\n");
editor.DigitarChar('S');
editor.DigitarChar('a');
editor.DigitarChar('m');
editor.DigitarChar('u');

Console.ReadKey();