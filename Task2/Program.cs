// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
if (num > 0)

   while (i <= num)
   {
       int c = i * i * i;
       Console.WriteLine($"{i}  |  {c}");
       i++;
   }