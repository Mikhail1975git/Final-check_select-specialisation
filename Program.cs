// Задача: Написать программу, которая из имеющегося массива строк формирует 
//новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] str = new string[] {"Hello", "2", "world", ":-)"};
string [] str1 = new string[str.Length];
int count = 0;

for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length<=3)
    {
        str1[count]=str[i];
        count++;
    }
}
string [] str2 = new string[count];
for (int i = 0; i < str2.Length; i++)
{
    str2[i]=str1[i];
}

Console.WriteLine("[{0}]", String.Join(",",str));
Console.WriteLine("[{0}]", String.Join(",",str2));
