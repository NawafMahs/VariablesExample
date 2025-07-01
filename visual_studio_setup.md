# دليل إعداد Visual Studio للعرض التقديمي

## قبل الدرس - إعداد البيئة

### 1. تحضير Visual Studio
- تأكد من تثبيت Visual Studio Community (مجاني)
- تأكد من تثبيت .NET Framework أو .NET Core
- اضبط حجم الخط ليكون واضحاً للطلاب (Font Size: 14-16)
- اختر Theme مناسب (Light Theme للوضوح)

### 2. إنشاء مشروع تجريبي
```
1. افتح Visual Studio
2. اختر "Create a new project"
3. اختر "Console App (.NET Core)" أو "Console App (.NET Framework)"
4. اسم المشروع: "VariablesDemo"
5. اختر مكان حفظ المشروع
6. اضغط "Create"
```

### 3. إعداد الكود الأساسي
```csharp
using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("مرحباً بكم في درس المتغيرات!");
            
            // سيتم إضافة الكود هنا أثناء الدرس
            
            Console.WriteLine("اضغط أي مفتاح للخروج...");
            Console.ReadKey();
        }
    }
}
```

## أثناء الدرس - العرض التفاعلي

### الخطوة 1: عرض واجهة Visual Studio
- اشرح الأجزاء الرئيسية:
  - Solution Explorer (مستكشف الحلول)
  - Code Editor (محرر الكود)
  - Output Window (نافذة المخرجات)
  - Error List (قائمة الأخطاء)

### الخطوة 2: كتابة كود المتغيرات تدريجياً
```csharp
// أضف هذا الكود تدريجياً أثناء الشرح
static void Main(string[] args)
{
    Console.WriteLine("مرحباً بكم في درس المتغيرات!");
    
    // متغيرات الأعداد الصحيحة
    int studentAge = 20;
    Console.WriteLine($"عمر الطالب: {studentAge}");
    
    // متغيرات النصوص
    string studentName = "أحمد";
    Console.WriteLine($"اسم الطالب: {studentName}");
    
    // متغيرات الأعداد العشرية
    double studentGrade = 87.5;
    Console.WriteLine($"درجة الطالب: {studentGrade}");
    
    // متغيرات منطقية
    bool isPassed = studentGrade >= 60;
    Console.WriteLine($"هل نجح الطالب؟ {isPassed}");
    
    Console.WriteLine("اضغط أي مفتاح للخروج...");
    Console.ReadKey();
}
```

### الخطوة 3: تشغيل البرنامج
- اضغط F5 أو Ctrl+F5 لتشغيل البرنامج
- اشرح الفرق بين التشغيل مع وبدون التصحيح
- اعرض النتائج في Console Window

### الخطوة 4: إظهار الأخطاء الشائعة
```csharp
// أمثلة على أخطاء شائعة لتوضيحها للطلاب
int age = "20";        // خطأ: نوع البيانات غير متطابق
string name = أحمد;    // خطأ: النص يجب أن يكون بين علامتي اقتباس
bool isActive = 1;     // خطأ: القيمة المنطقية يجب أن تكون true أو false
```

## نصائح للعرض

### 1. استخدام IntelliSense
- اظهر للطلاب كيف يساعد IntelliSense في الكتابة
- اشرح الاقتراحات التلقائية
- وضح رسائل الخطأ الحمراء

### 2. استخدام Debugger
- ضع Breakpoint على سطر واحد
- اشرح كيفية مراقبة قيم المتغيرات
- استخدم Watch Window لمراقبة المتغيرات

### 3. تنظيم الكود
- اشرح أهمية المسافات البادئة (Indentation)
- وضح استخدام الأقواس المجعدة {}
- اشرح التعليقات // و /* */

## أمثلة تفاعلية للطلاب

### مثال 1: معلومات شخصية
```csharp
// اطلب من الطلاب ملء هذه المعلومات
string myName = "اكتب اسمك هنا";
int myAge = 0; // اكتب عمرك هنا
double myHeight = 0.0; // اكتب طولك هنا
bool iAmStudent = true; // هل أنت طالب؟
```

### مثال 2: حاسبة بسيطة
```csharp
int number1 = 10;
int number2 = 5;
int sum = number1 + number2;
Console.WriteLine($"{number1} + {number2} = {sum}");
```

## استكشاف الأخطاء وحلها

### مشاكل شائعة:
1. **البرنامج لا يعمل**: تأكد من عدم وجود أخطاء في Error List
2. **النص لا يظهر بالعربية**: تأكد من encoding UTF-8
3. **Console يختفي بسرعة**: استخدم Console.ReadKey() في النهاية

### حلول سريعة:
- استخدم Ctrl+Z للتراجع
- استخدم Ctrl+S لحفظ الملف
- استخدم F5 لتشغيل البرنامج
- استخدم Shift+F5 لإيقاف التشغيل

## ملفات المشروع المرفقة
- يمكن استخدام الملفات الموجودة في مجلد examples/
- انسخ الكود من الملفات وألصقه في Visual Studio
- اشرح كل سطر للطلاب أثناء النسخ

## بعد الدرس
- احفظ المشروع في مكان يمكن للطلاب الوصول إليه
- شارك ملفات الكود مع الطلاب
- أعط الطلاب رابط تحميل Visual Studio Community

