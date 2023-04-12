// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

﻿using System; 
using static System.Console;
int M = AskNumber("M"); 
int N = AskNumber("N"); 
WriteLine($"M = {M}; N = {N} -> {PrintSum(M, N)}"); 

static int PrintSum(int M, int N) { 
 if(M > N) { 
 return 0; 
    }
 return M + PrintSum(M + 1, N); 
}

static int AskNumber(string name) { 
 Write($"Введите число {name}: "); 
 return int.Parse(ReadLine()); 
}
