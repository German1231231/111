string[] array = new string[5] {"22", "63", "spider", "world", "cat"};
int count = 0; 

for(int i = 0; i < array.Length; i++) 
{
    if(array[i].Length <= 3) // поиск элементом <=3 для нахождения размера нового массива
    {
        count++;
    }
}

string[] arr = new string[count]; // создаём новый массив, зная нужный размер

void FormingArrayThree(string[] array1, string[] array2) // метод заполнения массива элементами другого массива, которые <=3
{
    int len = 0;
    for(int j = 0; j < array1.Length; j++)
    {
        if(array1[j].Length <= 3)
        {
            array2[len] = array1[j];
            len++;
        }
    }
}

void PrintArray(string[] array1) // метод "печати" на экран элементов массива
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}

FormingArrayThree(array, arr);
PrintArray(arr);