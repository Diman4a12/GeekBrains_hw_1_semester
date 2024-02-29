//Создание массива
string[] textList = {"Hello", "224", "world", ":-)", "try", "ui"};

//Подсчет количества элементов с необходимой длинной
int CountSymbol (string[] textList) {
    int count = 0;
    for (int i=0; i < textList.Length; i++){
        if (textList[i].Length <= 3) {
            count ++;
        }
    }
    return count;
}

//Создание массива необходимой длины
string[] textListLen3 = new string[CountSymbol(textList)];

//ЗАполнение массива элементами
void AddStringToList (){
    int j = 0;
     for (int i=0; i < textList.Length; i++){
        if (textList[i].Length <= 3) {
            textListLen3[j] = textList[i];
            j++;
        }
    }
}

//Вызов функции
AddStringToList();

//Вывод на печать
System.Console.WriteLine($"['{string.Join("', '", textListLen3)}']");
