string[] arr = new string[] {"фамилия", "имя", "отчество", "дом", "этаж", "квартира", "123"};
string[] arr2 = new string[arr.Length];

void ThreeSymbolInArray(string[] arr, string[] arr2)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    
    foreach(string item in arr)
    {
        System.Console.Write($"{item}, ");
    } 
    System.Console.WriteLine();
}
