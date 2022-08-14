//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write("Enter number: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube)
{
  int count = 0;
  int length = cube.Length;
  while (count < length)
  {
    cube[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}
void PrintArry(int[] coll)
{
  int count1 = coll.Length;
  int index = 1;
  while(index < count1)
  {
    Console.Write(coll[index] + " ");
    index++;
  }
} 
int[] array = new int[cube+1];
Cube(array);
PrintArry(array);

// int index = 1, потому что по условию задачи промежуток чисел от 1 до N,
// если int index = 0, то и значения в примерах начнутся с 0.