
string[] StartArr = {"lol", "news", "kek", "abcd", "1", "100000"};
int len = StartArr.Length;
string[] FinishArr = new string[len];

int j = 0;

for(int i = 0; i < StartArr.Length; i++){
    if(StartArr[i].Length <= 3){
        FinishArr[j] = StartArr[i];
        j++;
    }
}

for(int i = 0; i < FinishArr.Length; i++){
    Console.Write($"{FinishArr[i]} ");
}