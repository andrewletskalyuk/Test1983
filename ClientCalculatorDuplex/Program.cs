using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClientCalculatorDuplex.ServiceReference1;

namespace ClientCalculatorDuplex
{
    /// <summary>
    /// реалізувати інтерфейс колбеку
    /// </summary>
    public class CallbaclHandler : ICalculatorServiceCallback //це можна було в іншому файлі - класі
    {
        public void Equels(double result)
        {
            Console.WriteLine("Result {0}," , result);
        }

        public void Result(double result1)
        {
            File.AppendAllText("result.txt", "Result = " + result1.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //проксі треба створити об"єкт
            //об"єкт типу 
            ICalculatorServiceCallback callback = new CallbaclHandler();
            InstanceContext context = new InstanceContext(callback); //будуємо середовище виконання
            CalculatorServiceClient proxi = new CalculatorServiceClient(context); //instanceContext 

            proxi.AddTo(100); //тут еквел не викликається

            proxi.MultiplyBy(2);
            proxi.DivideBy(4);
            proxi.ClearResult();
            //proxi.Close();
            Console.ReadLine();
        }
    }
}
