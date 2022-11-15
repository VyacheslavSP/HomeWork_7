// размерность массива
byte m=3,n=4;
double[,] BuildArray (byte Rows,byte Collum)
{
  var Rand=new Random();
  double[,] ResultsArray= new double[Rows,Collum];
  for(byte i=0;i<Rows;i++)
  {
    for(byte j=0;j<Collum;j++)
    {
      ResultsArray[i,j]=Math.Round(Rand.Next(sbyte.MinValue,sbyte.MaxValue)+Rand.NextDouble(),1);
    }
  }
  return ResultsArray;
}
BuildArray(m,n);
//просмотр резульата
//double[,] TMP=BuildArray(m,n);
//int rows = TMP.GetUpperBound(0) + 1;
//int columns = TMP.Length / rows;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{TMP[i, j]} \t");
//    }
//    Console.WriteLine();
//}
