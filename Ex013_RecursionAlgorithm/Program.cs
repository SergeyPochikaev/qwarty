string[,] table = new string[2, 5];

// string.Empty - иницилизация строк
//Для обращения к нужному элементу необходимо
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
  for (int columns = 0; columns < 5; columns++)
  {
    Console.WriteLine($"-{table[rows, columns]}-");
  }
}

// Матрица

void PrintArray(int[,] matr)
{
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }

}
//чтобы получить количество строк, необходимо исп. NameArray.GetLens(0), где
//"0" это строка, а "1" это столбец
//Например for (int i = 0; i < matrix.GetLens(0); i++)
for (int i = 0; i < 3; i++)
{
  for (int j = 0; j < 4; j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLens(0); i++)
  {
    for (int j = 0; j < matr.GetLens(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
    Console.WriteLine();
  }

}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

//Пример по использованию матрицы для закрашивания изображения
void PrintImage(int[,] image)
{
  for (int i = 0; i < image.GetLens(0); i++)
  {
    for (int j = 0; j < image.GetLens(0); j++)
    {
      if (image[i, j] == 0) Console.Write($" ");
      else Console.Write($"+");
    }
    Console.WriteLine();
  }
};

//Метод для закрашивания 
void FillImage(int row, int col)
{
  if (pic[row, col] == 0)
  {
    pic[row, col] == 1;
    FillImage(row - 1, col);
    FillImage(row, col - 1);
    FillImage(row + 1, col);
    FillImage(row, col + 1);
  }
};

int[,] pic = new int[,]
{
  {0,0,1},
  {0,0,1},
  {0,0,1},
};

PrintImage(pic);
FillImage(13, 13);
Console.WriteLine();
PrintImage(pic);


//Вычисления факториала
double Factorial(int n)
{
  if (n == 1) return 1;
  else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Собрать строку с числами от a до b, a <= b
string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec (a +1, b);
 else return String.Empty;
}

// Сумма чисел от 1 до n
int SumRec (int n)
{
  if (n == 0) return 0;
  else return n + SumRec(n-1);
}
Console.WriteLine(SumRec(10));

//вывод числа Фибоначчи
//f(1)=1
//f(2)=1
//f(n)=f(n-1)+f(n-2)

int Fibonacci(int n);
{
  if (n == 1 || n == 2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 1);
}

for (int i = 1; i < 10; i++)
{
Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
