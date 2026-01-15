int num1 = 10, num2 = 20, result = 0; 

void Add()
{ 
    result = num1 + num2; 
    Console.WriteLine($"{num1} + {num2} = {result}");
}

void Sub()
{
    result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result}");
}

void Mult()
{
    result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
}

void Over()
{
    result = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {result}");
}