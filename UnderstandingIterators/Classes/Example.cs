using System.Collections;

namespace UnderstandingIterators.Classes
{
    public class Example
    {

        /// <summary>
        /// (iterator block) Method to generate even numbers. applies lazy evaluation
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> GenerateEvenNumbers()
        {
            for (int i = 0; ; i++)
            {
                yield return i * 2;
            }
        }

        /// <summary>
        /// (non-iterator block) Method to generate even numbers. Doesnt apply lazy evaluation 
        /// </summary>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<int> GenerateEvenNumbersNonIterator(int totalCount)
        {
            List<int> evenNumbers = new List<int>();
            int i = 0;

            while (evenNumbers.Count < totalCount)
            {
                evenNumbers.Add(i);
                i += 2;
            }
            return evenNumbers;
        }

    }
}
