using System.Text;

string _line;
float _value=0;
StringBuilder _valuestringBuilder = new StringBuilder();

//ввод
Console.WriteLine ("Введите значение: ");
_line = Console.ReadLine ();

//обработка
for (int i = 0; i < _line.Length; i++)
{
    char letter = _line [i];

    if (char.IsDigit ( letter ))
    {
        _valuestringBuilder.Append ( letter );
    }//если число то вернет тру
    else if (letter == '.' || letter == ',')
    {
        _valuestringBuilder.Append ( ',' );
    }

}

if(_valuestringBuilder.Length == 0)
{
    Console.WriteLine ("Ошибка, нет чисел");
}
else
{ 
_value = float.Parse (_valuestringBuilder.ToString ());
}

//вывод
Console.WriteLine ("Числа = "+ _value);