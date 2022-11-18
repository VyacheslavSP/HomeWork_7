// вариант поиска индекса по значению числа
byte[,] BuildArray()
{
  var rnd =new Random();
  byte tmpSqear=(byte)rnd.Next(2,byte.MaxValue); // минимальный квадрат 2х2. иначе одномерный массив
  byte[,] myArray=new byte[tmpSqear,tmpSqear];
  for (byte i=0;i<tmpSqear;i++)
  {
    for(byte j=0;j<tmpSqear;j++)
    {
      myArray[i,j]=(byte)rnd.Next(byte.MinValue,byte.MaxValue);
    }
  }
  return myArray;
}
void SreachPozition(byte[,] myArray, byte number)
{
  try{
    for (int i=0; i<=myArray.GetLength(1); i++) {
      for (int j=0; j<=myArray.GetLength(0); j++) {
        if (myArray[i,j]==number) {
          Console.WriteLine("Индексы числа {"+i+","+j+"}");
          return;
        }
      }
    }
  }
  catch
  {
    Console.WriteLine("такого числа в массиве нет");
  }
}
byte[,]myArray=BuildArray();
//byte[,]myArray=new byte[,]{{1,4,7,123},{5,9,2,3},{8,4,140,255}};
byte number;
while (true) {
  Console.WriteLine("Введите искомое число от 0 до 255");
  try {
    number=Convert.ToByte(Console.ReadLine());
    break;
  }
  catch {
    Console.WriteLine("Ошибка: неккорекный ввод числа");
  }
}
SreachPozition(myArray,number);
