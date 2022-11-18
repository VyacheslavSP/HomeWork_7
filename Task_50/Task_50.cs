// вариант поиска по двум индексам
byte[,] BuildArray()
{
  var rnd =new Random();
  byte tmpSqear=(byte)rnd.Next(1,byte.MaxValue); //здесь и далее. создается квадратный массив. понятно что прямоугольный будет работать так же. Варианты пилообразных массивов (1 строка 5 столбцов,2 строка 20 столбцов, 3 строка 2 столбца и  т.д.) в данной задаче не рассматриваются
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
byte [] CheckArrayRowAndCollum(string message)
{
  int length=message.Length;
  byte[] arrayRowAndCollum= new byte [3]; // третья цифра зарезервирована для проверки корректности. т.к. размерность byte -1 использовать нельзя, поэтому 0=> все нормально, byte.MaxValue=> ошибка
  try
  {
    int pointPozition=message.IndexOf(',');
    if(pointPozition==-1)
    {
      throw new Exception("неккорекный ввод, не найден разделитель");
    }
    try
    {
      byte row=Convert.ToByte(message.Substring(0,pointPozition));
      byte collum=Convert.ToByte(message.Substring(pointPozition+1));
      arrayRowAndCollum[0]=row;
      arrayRowAndCollum[1]=collum;
    }
    catch {
      throw new Exception("неккорекный ввод индексов");
    }
  }
  catch (Exception e)
  {
    Console.WriteLine($"Ошибка: {e.Message}");
    arrayRowAndCollum[2]=byte.MaxValue;
  }
return   arrayRowAndCollum;
}
void Result (byte[,] myArray,byte[] arrayRowAndCollum)
{
  try {
    Console.WriteLine("ответ число "+ myArray[arrayRowAndCollum[0],arrayRowAndCollum[1]]);
  }
  catch  {
    Console.WriteLine("Числа с таким индексом в массиве нет");
  }
  return;
}
byte[,]myArray=BuildArray();
//byte[,]myArray=new byte[,]{{1,4,7,2},{5,9,2,3},{8,4,2,4}};
Console.WriteLine("Введите индексы(не более 255) числа через разделитель ','");
byte[] arrayRowAndCollum=CheckArrayRowAndCollum(Console.ReadLine());
if (arrayRowAndCollum[2]==0) {
  Result(myArray,arrayRowAndCollum);
}
