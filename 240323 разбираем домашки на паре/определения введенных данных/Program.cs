using System.Text;

string _line;
StringBuilder _valuestringBuilder = new StringBuilder();

//ввод
Console.WriteLine ("Введите значение: ");
_line = Console.ReadLine ();

//обработка
for (int i = 0; i < _line.Length; i++)
{
    char letter = _line [i];
    if(char.IsDigit(letter))
    {
        _valuestringBuilder.Append (letter); 
    }//если число то вернет тру


}

//вывод