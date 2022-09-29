using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f};

            float sum = 0.0f;

            for(int i = 0; i < weights.Length; i++)
            {
                sum += weights[i];
            }
            float average = sum/weights.Length;
            Console.WriteLine(average);
        }

    }
}