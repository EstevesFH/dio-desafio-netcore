using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NewTalents
{
    public class Calculator
    {
        private List<string> listHistoric;
        private string data;
        private string insertList;


        public Calculator(string data)
        {
            listHistoric = new List<string>();
            this.data = data;
        }

        private Calculator(string result, string insertList)    
        {
            this.insertList = "Result: " + result + "Data: " + data;
        }

        public int addition(int number1, int number2)
        {
            int result = number1 + number2;

            listHistoric.Insert(0, insertList);
            return result;
        }

        public int subtraction(int number1, int number2)
        {
            int result = number1 - number2;

            listHistoric.Insert(0, insertList);
            return result;
        }

        public int multiplication(int number1, int number2)
        {
            int result = number1 * number2;

            listHistoric.Insert(0, insertList);
            return result;
        }

        public int division(int number1, int number2)
        {
            int result = number1 / number2;

            listHistoric.Insert(0, insertList);
            return result;
        }

        public List<string> historic()
        {
            listHistoric.RemoveRange(3, listHistoric.Count -3);
            return listHistoric;
        }
    }
}

