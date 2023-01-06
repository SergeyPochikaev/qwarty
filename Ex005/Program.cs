Console.Write("Введите ваше имя: ");
string UserName = Console.ReadLine();
//String Маша;
if (UserName.ToLower() == "Маша")
  {
  Console.WriteLine("Привет Маша!!!");
  }
else
  {
  Console.Write("Привет ");
  Console.WriteLine(UserName);
  }