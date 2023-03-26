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
## Constructors & Destructors
```
class MyClass
{
    // constructor
    public MyClass()
    {
        Console.WriteLine("Object created.");
    }

    // destructor
    ~MyClass()
    {
        Console.WriteLine("Object destroyed.");
    }
}

// create an object of the class
MyClass obj = new MyClass();

// output: Object created.

// destroy the object
obj = null;

// output: Object destroyed.

```
## Generics
```
class MyClass<T>
{
    public T Value { get; set; }

    public void Display()
    {
        Console.WriteLine("Value: " + Value);
    }
}

// create an object of the class with a string type parameter
MyClass<string> obj1 = new MyClass<string>();
obj1.Value = "Hello";
obj1.Display();

// output: Value: Hello

// create an object of the class with an int type parameter
MyClass<int> obj2 = new MyClass<int>();
obj2.Value = 123;
obj2.Display();

// output: Value: 123

```
## Collections
## Lists
```
List<string> myList = new List<string>();
myList.Add("apple");
myList.Add("banana");
myList.Add("orange");

foreach (string item in myList)
{
    Console.WriteLine(item);
}

// output:
// apple
// banana
// orange
```
### Dictionary
```
Dictionary<string, int> myDictionary = new Dictionary<string, int>();
myDictionary.Add("apple", 3);
myDictionary.Add("banana", 6);
myDictionary.Add("orange", 2);

foreach (KeyValuePair<string, int> item in myDictionary)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}

// output:
// apple: 3
// banana: 6
// orange: 2
```
