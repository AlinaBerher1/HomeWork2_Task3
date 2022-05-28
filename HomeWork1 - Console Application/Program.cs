/*  Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте три строковые переменные и присвойте им значения: "\nмоя строка 1" "\tмоя строка 2" "\aмоя строка 3" 
Выведите значение каждой переменной на экран. Какие отличия вы увидели. Сделайте выводы. */

class Task3
{
    static void Main()
    {
        string d = "my string 1";
        string a = "\nmy string 1";
        string b = "\tmy string 2";
        string c = "\amy string 3";

        Console.Write (d);
        Console.Write (a);
        Console.Write (b);
        Console.Write (c);
    }
}