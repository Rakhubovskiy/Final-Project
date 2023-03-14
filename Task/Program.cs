// Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] arrText = { "Hello", "2", "world", ":-)" };

for (int i = 0; i < arrText.Length; i++)
{
    Console.Write($"{arrText[i]} ");
}

Console.WriteLine();

string newText = Replace(arrText);

string Replace(string[] text)
{
    string result = String.Empty;
    string fals = "cat";
    int word;
    for (int i = 0; i < text.Length; i++)
    {
        if ((word = text[i].CompareTo(fals)) < 0)
        {
            Console.Write($"{text[i]} ");
        }
        else
        {
            Console.Write("");
        }
    }
    return result;
}
