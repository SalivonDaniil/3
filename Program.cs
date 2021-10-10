using System;

namespace _3._1
{
    class Calculator
    {
        private int _num1;
        private int _num2;
        private string _sign;

        public int num1
        {
            get
            {
                return _num1;
            }
            set
            {
                this._num1 = value;
            }
        }
        public int num2
        {
            get
            {
                return _num2;
            }
            set
            {
                this._num2 = value;
            }
        }
        public string sign
        {
            get
            {
                return _sign;
            }
            set
            {
                this._sign = value;
            }
        }
        public Calculator()
        {
            this._num1 = 0;
            this._num2 = 0;
            this._sign = "+";
        }
        public Calculator(int num1)
        {
            this._num1 = num1;
            this._num2 = 0;
            this._sign = "+";
        }
        public Calculator(int num1, int num2)
        {
            this._num1 = num1;
            this._num2 = num2;
            this._sign = "+";
        }
        public Calculator(int num1, int num2, string sign)
        {
            this._num1 = num1;
            this._num2 = num2;
            this._sign = sign;
        }
        
        
        public double calculator()
        {
            if (sign == "+")
            {
                return num1 + num2;
            }
            else if (sign == "-")
            {
                return num1 - num2;
            }
            else if (sign == "*")
            {
                return num1 * num2;
            }
            else
            {
                return 0;
            }

        }

        public double Result
        {
            get
            {
                return this.calculator();
            }
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"Результат: {Result}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator CalculatorOne = new Calculator();
            Console.Write("Введите вводные данные ");
            String s = Console.ReadLine();
            String[] nums1 = s.Split(new char[] { ' ', '+', '-', '*'}, StringSplitOptions.RemoveEmptyEntries);
            String[] nums2 = s.Split(new char[] { ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }, StringSplitOptions.RemoveEmptyEntries);
            CalculatorOne.sign = nums2[0];
            CalculatorOne.num1 = Convert.ToInt32(nums1[0]);
            CalculatorOne.num2 = Convert.ToInt32(nums1[1]);
            CalculatorOne.GetInfo();
            
            
        }
    }
}
