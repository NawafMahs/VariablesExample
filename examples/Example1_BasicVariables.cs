using System;

namespace VariablesExample
{
    class BasicVariables
    {
        static void Main()
        {
            // مثال 1: المتغيرات الأساسية
            Console.WriteLine("=== مثال 1: المتغيرات الأساسية ===");
            
            // متغيرات الأعداد الصحيحة
            int studentAge = 20;
            int numberOfStudents = 25;
            
            // متغيرات النصوص
            string studentName = "فاطمة";
            string schoolName = "مدرسة النور";
            
            // متغيرات الأعداد العشرية
            double studentGrade = 87.5;
            double temperature = 23.8;
            
            // متغيرات منطقية
            bool isPresent = true;
            bool hasPassedExam = false;
            
            // طباعة القيم
            Console.WriteLine($"اسم الطالب: {studentName}");
            Console.WriteLine($"العمر: {studentAge} سنة");
            Console.WriteLine($"اسم المدرسة: {schoolName}");
            Console.WriteLine($"عدد الطلاب: {numberOfStudents}");
            Console.WriteLine($"الدرجة: {studentGrade}");
            Console.WriteLine($"درجة الحرارة: {temperature}°C");
            Console.WriteLine($"حاضر: {isPresent}");
            Console.WriteLine($"نجح في الامتحان: {hasPassedExam}");
            
            Console.WriteLine("\nاضغط أي مفتاح للمتابعة...");
            Console.ReadKey();
        }
    }
}

