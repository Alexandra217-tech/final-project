Console.WriteLine("Введите размер массива");
int L = Convert.ToInt32(Console.ReadLine()); 
string[] arrString;
arrString = new string[L];
for (int i=0; i<L; i++)
{
    string newString = Console.ReadLine(); 
    arrString[i] = newString;
}




