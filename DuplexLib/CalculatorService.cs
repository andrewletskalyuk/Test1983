using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DuplexLib
{
    public class CalculatorService : ICalculatorService
    {
        ICalculatorCallback callback = null;
        double result = 0;
        public CalculatorService()
        {
            callback = OperationContext.Current.GetCallbackChannel<ICalculatorCallback>(); //це зробили проксі із служби на клієнт
        }
        public void AddTo(double value)
        {
            result += value;
            callback.Equels(result); //передаємо результат
        }

        public void ClearResult()
        {
            callback.Result(result); //реалізація на клієнті
            result = 0;
        }

        public void DivideBy(double value)
        {
            result /= value;
            callback.Equels(result); //передаємо результат
        }

        public void MultiplyBy(double value)
        {
            result *= value;
            callback.Equels(result); //передаємо результат
        }

        public void SubtructFrom(double value)
        {
            result -= value;
            callback.Equels(result); //передаємо результат
        }
    }
}
