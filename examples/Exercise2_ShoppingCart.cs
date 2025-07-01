using System;

namespace VariablesExercise
{
    class ShoppingCartExercise
    {
        static void Main()
        {
            Console.WriteLine("=== تمرين 2: سلة التسوق ===");
            Console.WriteLine("أنشئ برنامج لحساب إجمالي فاتورة التسوق");
            Console.WriteLine();
            
            // معلومات المنتجات
            string product1Name = "كتاب";
            double product1Price = 25.50;
            int product1Quantity = 2;
            
            string product2Name = "قلم";
            double product2Price = 3.75;
            int product2Quantity = 5;
            
            string product3Name = "دفتر";
            double product3Price = 12.00;
            int product3Quantity = 3;
            
            // TODO: احسب التكلفة الإجمالية لكل منتج
            double product1Total = product1Price * product1Quantity;
            double product2Total = product2Price * product2Quantity;
            double product3Total = product3Price * product3Quantity;
            
            // TODO: احسب إجمالي الفاتورة
            double totalBill = product1Total + product2Total + product3Total;
            
            // TODO: احسب الضريبة (15%)
            double taxRate = 0.15;
            double taxAmount = totalBill * taxRate;
            
            // TODO: احسب المبلغ النهائي
            double finalAmount = totalBill + taxAmount;
            
            // عرض الفاتورة
            Console.WriteLine("فاتورة التسوق:");
            Console.WriteLine("================");
            Console.WriteLine($"{product1Name}: {product1Quantity} × {product1Price:C} = {product1Total:C}");
            Console.WriteLine($"{product2Name}: {product2Quantity} × {product2Price:C} = {product2Total:C}");
            Console.WriteLine($"{product3Name}: {product3Quantity} × {product3Price:C} = {product3Total:C}");
            Console.WriteLine("----------------");
            Console.WriteLine($"المجموع الفرعي: {totalBill:C}");
            Console.WriteLine($"الضريبة ({taxRate:P0}): {taxAmount:C}");
            Console.WriteLine($"المجموع النهائي: {finalAmount:C}");
            
            // تحدي إضافي: تحديد إذا كان المبلغ يستحق خصم
            bool qualifiesForDiscount = totalBill > 50;
            if (qualifiesForDiscount)
            {
                Console.WriteLine("\nتهانينا! تستحق خصم 10% للمشتريات فوق 50 ريال");
            }
            
            Console.WriteLine("\nاضغط أي مفتاح للمتابعة...");
            Console.ReadKey();
        }
    }
}

