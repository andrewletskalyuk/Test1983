using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DuplexLib
{
    [ServiceContract(CallbackContract = typeof(ICalculatorCallback))]
    public interface ICalculatorService //це контракт 
    {
        [OperationContract(IsOneWay = true)] //запит - не очікую відповіді
        void AddTo(double value);

        [OperationContract(IsOneWay = true)] //запит - не очікую відповіді
        void SubtructFrom(double value);
        
        [OperationContract(IsOneWay = true)] //запит - не очікую відповіді
        void DivideBy(double value);
        [OperationContract(IsOneWay = true)] //запит - не очікую відповіді
        void MultiplyBy(double value);
        [OperationContract]
        void ClearResult();
    }

    //контрак зворотнього зв"язку - це контракт клієнта
    public interface ICalculatorCallback //
    {
        [OperationContract(IsOneWay = true)]
        void Equels(double result);
        [OperationContract(IsOneWay = true)]
        void Result(double result); //

    }
}
