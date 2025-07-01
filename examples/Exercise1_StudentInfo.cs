using System;

namespace VariablesExercise
{
    class StudentInfoExercise
    {
        static void Main()
        {
            Console.WriteLine("=== تمرين 1: معلومات الطالب ===");
            Console.WriteLine("أكمل الكود التالي بإضافة المتغيرات المناسبة:");
            Console.WriteLine();
            
            // TODO: أضف متغيرات لتخزين المعلومات التالية:
            // 1. اسم الطالب (نص)
            // 2. عمر الطالب (عدد صحيح)
            // 3. معدل الطالب (عدد عشري)
            // 4. هل الطالب ناجح؟ (قيمة منطقية)
            
            // مثال على الحل:
            string studentName = "سارة";
            int studentAge = 19;
            double studentGPA = 3.75;
            bool isPassed = studentGPA >= 2.0;
            
            // عرض المعلومات
            Console.WriteLine("معلومات الطالب:");
            Console.WriteLine($"الاسم: {studentName}");
            Console.WriteLine($"العمر: {studentAge} سنة");
            Console.WriteLine($"المعدل: {studentGPA}");
            Console.WriteLine($"حالة النجاح: {(isPassed ? "ناجح" : "راسب")}");
            
            // تحدي إضافي: احسب السنة التي ولد فيها الطالب
            int currentYear = 2024;
            int birthYear = currentYear - studentAge;
            Console.WriteLine($"سنة الميلاد: {birthYear}");
            
            Console.WriteLine("\nاضغط أي مفتاح للمتابعة...");
            Console.ReadKey();
        }
    }
}

