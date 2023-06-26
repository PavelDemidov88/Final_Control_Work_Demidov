// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.

string[] arrayNums = new string[] {"zero","one","two","three","four","five","six","seven","eight","nine"};

Console.WriteLine("Исходный массив строк:");
PrintArray(arrayNums);
Console.WriteLine("Массив строк, имеющих не более 3 символов:");
NewArray(arrayNums, 3);

void NewArray(string[] array, int maxValue)
{
    for(int i=0; i<array.Length; i++)
    {
        string text = array[i];
        int length = (text.Length);
        if(length>maxValue); 
        else
        {
            Console.WriteLine("El: " +text);
        }
    }
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
 Console.WriteLine("El: " +inArray[i]);
    }
 Console.WriteLine();
}
