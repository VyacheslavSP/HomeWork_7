/* Вариант спорный и странный(обобенно к теме как не надо псиать код) и все таки решил показать
данный вариант может найти свое применение, когда у нас сильно многомерный массив (условно 1024 измерения) или какй-то пилообразный
для нормального поиска элемента по индексу необходимо было бы передать все 1024 индекса.Однако, тот же
foreach проходится по всем элементам вне зависимости от количесва строк/столбцов. а метод .Length() возвращает общее число элеменотов
под капотом,если я правильно понял,все массивы все равно разворачиваются в строчку,значит для системы нет разницы как именно мы будем обрабатывать
таким образом мы можем искать элементы не по индексу а по его позиции относительно нулевого элемента.*/
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

byte[,] myArray=BuildArray();
//byte[,] myArray=new byte[,]{{1,2,3},{5,1,3},{10,90,2}};
byte indexElement=0;
Console.WriteLine("Введите 'индекс'");
try{
  indexElement=Convert.ToByte(Console.ReadLine());
}
catch  {
  Console.WriteLine("Некорректный ввод 'индекса'");
}
if (indexElement>=myArray.Length) {
  Console.WriteLine("Числа с таким 'индексом' в массиве нет");
}
byte i=0;
foreach (byte element in myArray)
{
  if (i==indexElement) {
    Console.WriteLine("Искомый элемент "+ element);
    break;
  } else{
    i++;
  }
}
