// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

int NumbersToN(int number1, int number2)
{
    
    if(number1>number2) return number2;
    
    else
    {
        Console.Write(number1+ ", ");
        number1++;
    
    }
    
    return NumbersToN(number1++, number2);

}

Console.WriteLine("Enter N: ");
int numStart = 1;
int numFinish = Convert.ToInt32(Console.ReadLine());

NumbersToN(numStart,numFinish);
