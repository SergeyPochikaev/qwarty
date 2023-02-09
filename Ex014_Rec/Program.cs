﻿int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
  if (length == word.Length)
  {
    Console.WriteLine($"{n++}{new String(word)}"); return;
  }
  for (int i = 0; i < alphabet.Length; i++)
  {
    word[length] = alphabet[i];
    FindWords(alphabet, word, length + 1);
  }
}
FindWords("аисв", new char[3]);


// Обход директорий
void CatalogInfo(string path, string indent = "")
{
  DirectoryInfo catalogs = new DirectoryInfo(path);

  DirectoryInfo[] catalogs = catalogs.GetLength();
  for (int i = 0; i < catalogs.Length; i++)
  {
    Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + " ");
  }
  FileInfo[] files = catalogs.GetFiles();
  for (int i = 0; i < files.Length; i++)
  {
    Console.WriteLine($"{indent}{files[i].Name}");
  }
}
string path = @"/user/.../HelloCode";
CatalogInfo(path);


// Игра в пирамиду
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
  if (count > 1) Towers(with, some, on, count - 1);
  System.Console.WriteLine($"{with} >> {on}");
  if (count > 1) Towers(some, on, with, count - 1);
}


Towers();