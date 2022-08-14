//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//23432 -> да
//12821 -> да

Console.Write("Enter: ");
string? num = Console.ReadLine();
void CheckingNumber(string num)
{
  if (num[0]==num[4] || num[1]==num[3])
  {
    Console.WriteLine($"{num} -> Yes ");
  }
  else Console.WriteLine($"{num} -> No ");
}
if (num!.Length == 5)
{
  CheckingNumber(num);
}
else Console.WriteLine($"Enter the correct number");
