Console.WriteLine("Введите размер массива");
int L = Convert.ToInt32(Console.ReadLine()); 
string[] arrString;
string[] array;
int len =0;
array = new string[L];
arrString = new string[L];
for (int i=0; i<L; i++)
{
    string newString = Console.ReadLine(); 
    arrString[i] = newString;
    if (arrString[i].Length<=3)
    {
        len++;
    }
}



void PrintArray (string [] coll)
{
    int count =coll.Length;
    for (int j=0; j<count; j++)
    {
        Console.WriteLine (coll[j]);
    }
}

//PrintArray(array);


