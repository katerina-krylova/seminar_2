Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumber%10);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}
