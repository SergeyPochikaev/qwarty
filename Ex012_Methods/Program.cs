// Вид 1 (Не чего не возвращают и не чего не принимают)
void Method1()
{
  Console.WriteLine("Автор ....");
}
// Вызываются Method1
Method1();




// Вид 2 (Не чего не возвращают, но принимают аргументы)
void Method2(string msg)
{
  // выводит сообщение
  Console.WriteLine(msg);
}
// Вызываются Method2
Method2("Текст сообщения");
// можно указать конкретное значение присвоить аргумент, если метод принимает какое-то кол-во аргументов
Method2(msg: "Текст сообщения");
//Например://
void Method2(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Вызов Method2//
Method2("Текст", 4);
//Если конкретно из списков аргументов то можно пристроить://
Method2(msg: "Текст", count: 4); // Аргументы можно менять местами




// Вид 3 (Что-то возвращают, но ни чего не принимают)
int Method3();
{
  return DateTime.Now.Year;
}
// Вызываются Method3
int year = Method3();
Console.WriteLine(year);




// Вид 4 (Что-то принимают и выдают)
string Method4(int count, string text);
{
  int i = 0;
  string result = ""; //Пустая строка String.Empty
  while (i < count)
  {
    result = result + text;
    i++;
  }
  return result;
}
// Вызываются Method4
string res = Method4(10, "asdf");
Console.WriteLine(res);