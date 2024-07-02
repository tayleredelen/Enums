using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());
            Console.WriteLine(method); //same output as above since ToString auto used with all Console.WriteLine values

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof (ShippingMethod), methodName);



        }
    }
}
