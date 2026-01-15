int result = 0; 

void Add(int num1, int num2)
{ 
    result = num1 + num2; 
    Console.WriteLine($"{num1} + {num2} = {result}");
}

void Sub(int num1, int num2)
{
    result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result}");
}

void Mult(int num1, int num2)
{
    result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
}

void Over(int num1, int num2)
{
    result = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {result}");
}

Add(12, 16);
Sub(10, 7);
Mult(5, 2);
Over(50, 5);
