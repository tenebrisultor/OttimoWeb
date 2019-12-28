using System;

namespace MyCalcLib
{

    public interface IMyCalc<T> {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Mul(T a, T b);
        T Div(T a, T b);
    }
    public class MyCalc : IMyCalc<int>
    {
        public int Add(int a, int b) => a + b;        

        public int Div(int a, int b)
        {
            try {
                return a / b;
            }
            catch (DivideByZeroException ex) {
                throw ex;
            }
        }

        public int Mul(int a, int b) => a * b;

        public int Sub(int a, int b) => a - b;        
    }
}
