// Задание 3
// Семинар 1
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000) // &&(их два) означает "И", чтобы выполнялись условия и справа и слева
{
    int leftDigit = number / 100; // число слева
    int rightDigit = number % 10; // число справа
    System.Console.WriteLine(leftDigit + rightDigit);
}
else {
    System.Console.WriteLine("Вы ввели не трёхзначное число");
}