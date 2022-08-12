// Напишите программу которая, принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100; num1 = num1 / 10 ; num1 = num1 / 10;
int num2 = num / 100; num2 = num2 / 10 ; num2 = num2 % 10;
int num4 = num / 10; num4 = num4 % 10;
int num5 = num % 10;

if( num1 == num5 && num2 == num4)
{
    Console.Write($"Число {num} является палиндромом");
}
else 
{
    Console.Write($"Число {num} НЕ является палиндромом");
}
