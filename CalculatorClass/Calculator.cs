namespace TddProjekt
{
    public class Calculator
    {

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Mod(int num1, int num2)
        {
            return num1 % num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public object Text(string t1)
        {
            return t1 = "hello world";
        }
    }
}