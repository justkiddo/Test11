using CW_11.Classes;
using CW_11.Classes._5;

// 1 


int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

string res = string.Empty;

for (int i = 0; i < mas.GetLength(0); i++)
{
    res += "{";
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        res += "{";
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            res += "{" + mas[i, j, k] +"}"; // переменные стоят попарно % от деления !=0 добавить запятые не успел

        }
        res += "}";
    }
    res += "}";
}
Console.WriteLine(res);   
Console.WriteLine();


//   2   класс MyString

MyString ms = new MyString();

string rs = "12345";


string rn = ms.Reverse(rs);

Console.WriteLine(rn);
Console.WriteLine();

// 3 DateTimeExtension

DateTimeExtension dte = new DateTimeExtension();
dte.Passed();
Console.WriteLine();

//  5  базовые и наследники

BaseClass1 base1= new BaseClass1();
BaseClass1 derived1 = new Derived1();
Derived2 derived2 = new Derived2();
derived1.ShowValues();
Console.WriteLine();
derived2.ShowValues();
Console.WriteLine();

//   6 


