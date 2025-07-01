using System;

namespace VariablesExample
{
    class SimpleCalculator
    {
        static void Main()
        {
            Console.WriteLine("=== مثال 2: حاسبة بسيطة ===");
            
            // إعلان المتغيرات
            int firstNumber = 15;
            int secondNumber = 8;
            
            // العمليات الحسابية
            int sum = firstNumber + secondNumber;
            int difference = firstNumber - secondNumber;
            int product = firstNumber * secondNumber;
            double division = (double)firstNumber / secondNumber;
            
            // عرض النتائج
            Console.WriteLine($"العدد الأول: {firstNumber}");
            Console.WriteLine($"العدد الثاني: {secondNumber}");
            Console.WriteLine();
            Console.WriteLine("النتائج:");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");
            Console.WriteLine($"{firstNumber} × {secondNumber} = {product}");
            Console.WriteLine($"{firstNumber} ÷ {secondNumber} = {division:F2}");
            
            // مثال على تغيير قيم المتغيرات
            Console.WriteLine("\n=== تغيير قيم المتغيرات ===");
            firstNumber = 20;
            secondNumber = 4;
            
            Console.WriteLine($"القيم الجديدة: {firstNumber} و {secondNumber}");
            Console.WriteLine($"المجموع الجديد: {firstNumber + secondNumber}");
            
            Console.WriteLine("\nاضغط أي مفتاح للمتابعة...");
            Console.ReadKey();
        }
    }
}

