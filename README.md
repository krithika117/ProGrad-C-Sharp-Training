# ProGrad C# Training

### Basic C# Syntax
```
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}

```
### Arrays
3 Types of Arrays 
- One dimensional 
```
int[] numbers = {1, 4, 2};

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
```
- Multi dimensional 
```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
```
- Jagged (Array of Arrays)

```
int[][] jagged_array = { new int[]{ 2, 3, 4 }, new int[]{ 4, 5, 6 } };
foreach (int[] arr in jagged_array)
{
    foreach (int i in arr)
        Console.Write(i+" ");
     Console.WriteLine();
}
```
### Enumeration
```
public enum Months
{
    January,    
    February,   
    March,      
    April,      
    May,        
    June,       
    July, 
    August,
    September,
    October,
    November,
    December
}
static void Main(string[] args)
{
    foreach (Months d in Enum.GetValues(typeof(Months))) { 
    Console.WriteLine(d);
    }
}
```
