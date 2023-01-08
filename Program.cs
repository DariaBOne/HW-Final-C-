Console.WriteLine("Сколько строк будет в массиве");
int M = Convert.ToInt32(Console.ReadLine());
string[] massiv = new string[M];
string [] newMassiv = new string [M];
Console.WriteLine("Вводите поочередно строки массива");
for (int i=0; i<M;i++)
massiv[i] = Console.ReadLine();
void PrintArray (string[]array)
{
for (int i=0; i< array.Length;i++)
Console.Write($"{array[i]} ");
}
int j = 0;
for (int i=0; i< massiv.Length;i++)
{
  if (massiv[i].Length<=3)
     {newMassiv[j] = massiv[i];
      j++;
     }
}
bool newMassivEmpty = newMassiv.All(el=> el == null);
if (newMassivEmpty == true)
Console.WriteLine("Новый массив пуст");
else
{
Console.Write("Новый массив:  ");
PrintArray (newMassiv);
}

