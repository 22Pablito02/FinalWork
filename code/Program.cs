
string[] StartArr = { "You", "news", "go", "abcd", "od", "100000", "man", "qwert", "!" };
string[] FinishArr = new string[StartArr.Length];

PrintArr(SearchSmallValue(StartArr, FinishArr));

string[] SearchSmallValue(string[] SArr, string[] FArr)
{
    int j = 0;
    for (int i = 0; i < StartArr.Length; i++)
    {
        if (StartArr[i].Length <= 3)
        {
            FinishArr[j] = StartArr[i];
            j++;
        }
    }
    return FinishArr;
}

void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}