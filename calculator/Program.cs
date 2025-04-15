// See https://aka.ms/new-console-template for more information
using calculator;

Console.WriteLine("Hello, World!");


numbers num = new numbers
{
    num1 = 4,
    num2 = 5,
    op = "/"
};

double resault = 0;


if(num.op== "+")
{
    resault = num.num1 + num.num2;
}
else if (num.op == "-")
{
    resault = num.num1 - num.num2;
}
else if (num.op == "*")
{
    resault = num.num1 * num.num2;
}
else if (num.op == "/")
{
    resault = num.num1 / num.num2;
}
else
{
    Console.WriteLine("Invalid operator");
};

Console.WriteLine("The result is: " + resault);