# final-project

Для начала необходимо создать массив и наполнить его строками с клавиатуры.
После этого перебрать массив по индексам и найти строки меньшие или равные трем символам.
Добавить найденные строки в новый массив.
Вывести новый массив.

void PrintArray (string [] coll)
{
    int count =coll.Length;
    for (int j=0; j<count; j++)
    {
        Console.WriteLine (coll[j]);
    }
}

PrintArray(arrString);