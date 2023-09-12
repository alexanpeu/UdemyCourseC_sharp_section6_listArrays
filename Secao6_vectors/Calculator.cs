

namespace Secao6_vectors
{
    internal class Calculator
    {
        //creating a function vector with parameters
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i< numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //using a funcion ref to retornate the value to the initial variable
        public static void TripleRef(ref int x)
        {
            x *= 3;
        }
        //using a funcion out to keep the value original but retorn in other variable
        public static void TripleOut(int origin, out int resultOut)
        {
            resultOut = origin * 3;
        }
    }
}
