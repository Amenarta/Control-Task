// Решение задачи:
void FindArray(string[] word)
{
    string result = String.Empty;
    int length = word.Length;
    for (int i = 0; i< word.Length; i++)
    {
        if (word[i].Length > 3)
         {
            word[i] = "Слово больше 3-х символов";
            Console.WriteLine(i + "->" + "Слово больше 3-х символов");
         }           
    }
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i].Length <= 3)
        {
            result = word[i];
        }
    } 
    Console.WriteLine();  
    Console.Write("Из введеных слов - слово менее или равно 3-м символам" + "-> " + result);
}

void ScreenArray (string[] word)
{
    for (int i = 0; i < word.Length; i++)
        Console.Write(word[i] + " ");
    Console.WriteLine();
}


string[] myArray = {"1234", "Moskow", "Oda", "Smile"};
ScreenArray(myArray);
FindArray(myArray);






