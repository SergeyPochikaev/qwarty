// Вид 4 (Что-то принимают и выдают но с процедурой цикла for)
string Method4(int count, string text);
{

  string result = ""; //Пустая строка String.Empty
  for (int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}
// Вызываются Method4
string res = Method4(10, "asdf");
Console.WriteLine(res);


//Пример//(Вывод табл. умножения через for)
  for (int i = 2; i <= 10; i++)
  {
    for (int j = 2; j <= 10; j++)
    {
      Console.WriteLine($"{i} * {j}  = {i*j}");//Использовано интрополяция строк i*j
    }
    Console.WriteLine();
  }
