string directory = "";
string filename = "Data.txt";
string fullPath = "";
string data = "";



data = ReadFile();

while(true)
{
    Print();

    string line =  Console.ReadLine();
    if(line =="exit")
    {
        break;
    }
    data += "\n" + line;
    Console.Clear();    
}

Write();

Console.ReadLine();

string ReadFile()
{
    directory = Directory.GetCurrentDirectory(); //непосредственно exe

    directory = new DirectoryInfo(directory).Parent.Parent.FullName;//расположение понятнее, переход по уровням каталога

    fullPath = Path.Combine(directory, filename);//Чтобы не обращать внимание  на слэши

    return File.ReadAllText(fullPath);
}


void Print()
{
    Console.WriteLine("Данные - \n" + data);
}

void Write()
{
    File.WriteAllText(fullPath, data);  //Запись в файл
}
