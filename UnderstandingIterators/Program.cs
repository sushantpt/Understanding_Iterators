// See https://aka.ms/new-console-template for more information
using System.Collections;
using UnderstandingIterators.Classes;

/*Console.WriteLine("Hello, World!");
*/

Example example = new Example();

IEnumerable<int> evenNumbers = example.GenerateEvenNumbers();


// print 10 numbers.
/*Console.WriteLine("Iterator block:");
foreach (int evenNumber in evenNumbers.Take(10))
{
    Console.WriteLine(evenNumber);
}*/



// print 10 numbers without yield 
/*Console.WriteLine("Non-iterator block:");
foreach (int evenNumber in example.GenerateEvenNumbersNonIterator(10))
{
    Console.WriteLine(evenNumber);
}*/



/*IEnumerable<int> enumerable = example.GenerateEvenNumbers();
using (IEnumerator<int> enumerator =
enumerable.GetEnumerator())
{
    while (enumerator.MoveNext())
    {
        int value = enumerator.Current;
        Console.WriteLine(value);
    }
}*/



// To generate infinite even numbers:
IEnumerable<int> enumerable = example.GenerateEvenNumbers();
IEnumerator<int> enumerator = enumerable.GetEnumerator(); // IEnumerable.GetEnumerator() it asks the sequence to create an IEnumerator that’s set up to iterate over that sequence, just like putting a new bookmark at the start of a book. 
/*while (enumerator.MoveNext())
{
    int val = enumerator.Current;
    Console.WriteLine(val);
}*/


/*// Ctrl + C to stop the execution. 
foreach (int val in enumerable.Take(10))
{
    Console.WriteLine(val);
}
*/


// generate even numbers greater than 10 and less than 100
var conditionalEvenNumbers = example.GenerateEvenNumbers().Where(x => x > 10 & x < 100);
foreach(int val in conditionalEvenNumbers.Take(5))
{
    Console.WriteLine(val);
}


