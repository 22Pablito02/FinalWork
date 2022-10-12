
string[] StartArr = { "You", "news", "go", "abcd", "od", "100000", "man", "qwert", "!" };
string[] FinishArr = new string[StartArr.Length];

PrintArr(SearchSmallValue(StartArr, FinishArr));

string[] SearchSmallValue(string[] SArr, string[] FArr)
{
    int j = 0;
    for (int i = 0; i < SArr.Length; i++)
    {
        if (SArr[i].Length <= 3)
        {
            FArr[j] = SArr[i];
            j++;
        }
    }
    return FArr;
}

void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}