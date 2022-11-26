
/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

int size;
Console.Write($"Введите размерность массива: "); 
int.TryParse(Console.ReadLine()!, out size);

string[] array1 = new string[size];
for (int i = 0; i < size; i++) // Ввод значений элементов первого массива 
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array1[i] = element;
}

string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2) // Метод заполнения второго массива элементами из первого массива длина каждого не превышающее 3
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array) // Метод вывода массива с элементами длина каждого элемента которого не превышает 3.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);
