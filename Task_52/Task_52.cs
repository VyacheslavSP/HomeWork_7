byte[,] BuildArray()
{
  var rnd =new Random();
  byte tmpSqear=(byte)rnd.Next(2,byte.MaxValue);
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
float[] FindAverage(byte[,] myArray)
{
  byte collum=(byte)myArray.GetLength(1);
  byte row=(byte)myArray.GetLength(0);
  float[] arrayAverage=new float[collum];
  for (byte i=0; i<collum; i++) {
    for (byte j=0; j<row; j++) {
      if (j<row-1) {
        arrayAverage[i]=(Single) (arrayAverage[i]+myArray[j,i]);
      }else{
          arrayAverage[i]=(Single) (arrayAverage[i]+myArray[j,i]);
          arrayAverage[i]=arrayAverage[i]/row;
      }
    }
  }
  return arrayAverage;
}
byte[,] myArray=BuildArray();
//byte[,] myArray=new byte[,]{{1,4,7,2},{5,9,2,3},{8,4,2,4}};
float[] Results=FindAverage(myArray);
//
string Answer="{";
char finish='}';
foreach(float  element in Results)
{
  Answer+=(element+";");
}
Answer=Answer.Remove(Answer.Length-1, 1).Insert(Answer.Length-1, finish.ToString()); // прсто стало интересно попробовать реализовать выход из foreach. но через for проще)
Console.WriteLine(Answer);
