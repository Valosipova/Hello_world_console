﻿// Вид 1
void Method1()
{
    //Console.WriteLine("Автор Валентина Осипова");
}
Method1();

// Вид 2
void Method2(string msg){
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count){
    Console.WriteLine(msg);
    i++;}  
  }
//Method21(count: 4, msg: "новый текст");

// Вид 3
int Method3 (){
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4

string Method4 (int count, string text){
   
    string result = String.Empty;
    for ( int i = 0; i < count;  i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdt");
//Console.WriteLine(res);


//Таблица умножения

for (int i=2; i<=10; i++){
    for (int j = 2; j<=10; j++){
        //Console.WriteLine($"{i}*{j}={i*j}");
    }
    //Console.WriteLine();
}

//Дан текст. В нём нужно все пробелы заменить чёрточками, 
//маленькие буквы «к» заменить большими «К», а большие «С» 
//заменить на маленькие «с».

string text ="— Я думаю, — сказал князь, улыбаясь, — что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty"
//            012345
// s[3] = r

string Replace (string text, char oldValue, char newValue){
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
string newText2 = Replace(text,'к','К');
Console.WriteLine(newText2);
Console.WriteLine();
string newText3 = Replace(text,'С','с');
Console.WriteLine(newText3);
Console.WriteLine();

