int a = 1;
int b = 5;
int c = 8;
int d = 3;
int e = 2;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
