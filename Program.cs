// №1 Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// -----------------------------------------------------------------------
// Console.Write("Введите значение M: ");  
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите значение N: ");  
// int n = Convert.ToInt32(Console.ReadLine()); 
// naturalNumbers(m, n); 

// void naturalNumbers(int M, int N)  // Создаем метод(функцию) naturalNumbers(int M, int N)
// {
//     if (M > N)  // Если значение переменной M(начальное число) больше значения переменной N(конечное число)
//     {
//         return;  // То остановка рекурсии
//     }
//     else  
//         Console.Write(M + " ");  // То вывод в консоль значения переменной M с пробелом(" ")
//     naturalNumbers(M + 1, N);  
// }

// ----------------------------------------------------------

// // №2 Напишите программу вычисления функции
// // Аккермана с помощью рекурсии. Даны два
// // неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9


// Console.Write("Введите значение M: "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите значение N: "); 
// int n = Convert.ToInt32(Console.ReadLine());     

// Console.WriteLine($"Результат: {AkkermanFunction(m, n)}");

// int AkkermanFunction(int M, int N)  // Создаем метод(функцию) AkkermanFunction(int M, int N) (вычисление функции Аккермана)
// {
//     if (M == 0)  // Если значение переменной M равно(==) 0
//     {
//         return N + 1;  // То остановка рекурсии и увеличиваем значение переменной N(введенной в консоль) на 1
//     }
//     else if (M > 0 && N == 0)  // Если же значение переменной M больше 0 и(&&) значение N равно(==) 0 
//     {
//         return AkkermanFunction(M - 1, 1);  // То остановка рекурсии
//     }
//     else 
//     {
//         return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));  // То остановка рекурсии
//     }
// }

// ----------------------------------------------------

// №3 Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


// Console.WriteLine("Введите размер массива");  
// int size = Convert.ToInt32(Console.ReadLine()); 
// int[] num = new int[size]; 

// RandomNumbers();  // Идентификатор RandomNumbers метода(функции) void
// PrintArrayReversed(num, num.Length - 1); 

// void RandomNumbers()  // Создаем метод(функуцию) RandomArray  (наполняет массив рандомными числами) 
// {
//     for (int i = 0; i < num.Length; i++)  // прохождение по всем элементам массива
//     {
//         num[i] = new Random().Next(1, 51);  // Заполняем массив рандомными числами от 1 до 50
//         Console.Write(num[i] + " ");  
//     }
//     Console.WriteLine();  //Вывод в консоль пустой строки
// }

// void PrintArrayReversed(int[] array, int index)  // Создаем метод(функцию) PrintArrayReversed  (функция для вывода элементов массива в обратном порядке)
// {
//     if (index < 0)  // Если индекс становится меньше 0
//     {
//         return;  // То остановка рекурсии
//     }
//     else  
//         Console.Write(array[index] + " ");  // То вывод в консоль текущего элемента массива array[index] с пробелом(" ")
//     PrintArrayReversed(array, index - 1);  
// }