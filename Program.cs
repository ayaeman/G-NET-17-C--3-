namespace C_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1
            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);
            //this code will print value 9 because the explicit casting will truncates the decimal part.

            //Question2
            int n = 5;
            double d2 =(double) n / 2;
            Console.WriteLine(d2);

            //Question3
            //Console.WriteLine("Enter your Age:");
            //bool isParsed = int.TryParse(Console.ReadLine() , out int age);
            //if (isParsed)
            //{
            //    Console.WriteLine("Valid Age");
            //}else
            //{
            //    Console.WriteLine("Enter a Valid Age !!");
            //}

            //Question4
            //string s = "12a";
            //int convertedValue = int.Parse(s);
            //Console.WriteLine(convertedValue);
            // Throws a 'FormatException' Exception
            // Because the string value can not be converted into an int as it contains 'a' character

            //Question5
            string s2 = "12a";
            bool isConverted = int.TryParse(s2, out int sValue);
            if (isConverted)
            {
                Console.WriteLine($"Valid ==> {sValue}");
            }else
            {
                Console.WriteLine("Invalid Conversion");
            }

            //Question6
            object o = 10; //boxing
            int a = (int)o;//unboxing
            Console.WriteLine(a + 1);
            //This will print 11
            //As after boxing the value into an object we extract the int value from the object which known as (Unboxing)
            //and then we increment the value with 1


            //Question7
            object obj = 10;
            long longValue = (long)(int)obj; // I handle it by adding (int)
            Console.WriteLine(obj);
            //Throws an 'InvalidCastException' Exception
            //Because before unboxing the object value into long value we have to convert it to its base value (int) and then do the conversion

            //Question8
            object obj2 = 10;
            long longX = (long)(int)obj2;
           // Console.WriteLine(longX.GetType());
            bool canConvert = obj2 is int;
            if (!canConvert)
            {
                Console.WriteLine(-1);
            }else
            {
                Console.WriteLine($"Long Value from Object {longX}");
            }

            //Question9
            string? name = null;
          //  Console.WriteLine(name?.Length);
            //Nothing will be printed
            //because null has no length , it is not a real value and, the (?.) prevents access to Length.

            //Question10
            string? name2 = null;
            int length = name2?.Length ?? 0;
            Console.WriteLine(length);

            //Question11
            string? s = null;
            bool x2 = int.TryParse(s ?? "0",out int res );
            if (x2)
            {
                Console.WriteLine(res);
            }else
            {
                Console.WriteLine("Invalid Conversion");
            }


            //Question12
             string ? strValue = null;
            Console.WriteLine(s?.Length +" No Length " );
            //Throws an 'NullReferenceException' Exception


            //Question13
             string ? s13 = null;
             int x13 = Convert.ToInt32(s13);
             Console.WriteLine(x13);
            //will print 0


            //Question14
             string ? s14 = null;
             //A
            // int a14 = int.Parse(s14); 
            //Console.WriteLine(a14 +"A14"); // ArgumentNullException

            // B
            int b = Convert.ToInt32(s14); //0
            Console.WriteLine(b +"B");

            //Question14
            string? user = "Aya"; //AYA
            //string? user = "null"; //Guest
            Console.WriteLine(user?.ToUpper() ?? "Guest");

        }
    }
}
