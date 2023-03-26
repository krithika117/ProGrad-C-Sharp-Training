# ProGrad C# Training

## Basic C# Syntax
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
## Conditional Statements
### if-else
```
if (condition)
{
    // code to execute if the condition is true
}
else if (condition2)
{
    // code to execute if condition2 is true
}
else
{
    // code to execute if both conditions are false
}
```
## Loops
### For loop
```
for (int i = 0; i < length; i++)
{
    // code to execute for each iteration of the loop
}
```
### While Loop
```
while (condition)
{
    // code to execute while the condition is true
}

```
### Do while Loop
```
do
{
    // code to execute at least once, and then repeatedly while the condition is true
}
while (condition);

```
## Arrays
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
## Enumeration
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
## Exceptions
```
try
{
    // code that may throw an exception
}
catch (Exception ex)
{
    // handle the exception
}
finally
{
    // code that will be executed whether or not an exception is thrown
}
```
## Constructors
```
class MyClass
{
    // default constructor
    public MyClass()
    {
        // code to initialize class members
    }

    // parameterized constructor
    public MyClass(int param1, string param2)
    {
        // code to initialize class members with the given parameters
    }
}
```
