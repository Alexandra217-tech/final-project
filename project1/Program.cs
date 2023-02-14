Console.WriteLine("Введите размер массива");
int L = Convert.ToInt32(Console.ReadLine()); 
string[] arrString;
string[] array;
arrString = new string[L];
array = new string[L];
int count =0;
for (int i=0; i<L; i++)
{
    string newString = Console.ReadLine(); 
    arrString[i] = newString;
}

for (int j=0; j<L; j++)
{
    if (arrString[j].Length<=3)
    {
        array[count]=arrString[j];
        count++;
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

Console.WriteLine ();
PrintArray(array);



