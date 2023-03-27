# ProGrad C# Training

## Table of Contents

- [Basic C# Syntax](#basic-c-syntax)
- [Conditional Statements](#conditional-statements)
  * [if-else](#if-else)
- [Loops](#loops)
  * [For loop](#for-loop)
  * [While Loop](#while-loop)
  * [Do while Loop](#do-while-loop)
- [Arrays](#arrays)
  * [One dimensional](#one-dimensional)
  * [Multi dimensional](#multi-dimensional)
  * [Jagged](#jagged-array-of-arrays)
- [Enumeration](#enumeration)
- [Exceptions](#exceptions)
- [`static` Keyword](#static-keyword)
- [`this` Keyword](#this-keyword)
  * [To access instance variables](#to-access-instance-variables)
  * [To call another constructor of the same class](#to-call-another-constructor-of-the-same-class)
  * [To pass the current object as a parameter](#to-pass-the-current-object-as-a-parameter)
- [Constructors & Destructors](#constructors--destructors)
  * [Constructors](#constructors)
  * [Destructors](#destructors)
- [Generics](#generics)
- [Collections](#collections)
  * [Lists](#lists)
  * [Dictionary](#dictionary)
  * [Hash sets](#hash-sets)
  * [Stack](#stack)
  * [Queue](#queue)
  * [Linked List](#linked-list)
  * [Sorted Set](#sorted-set)
  * [Sorted Dictionary](#sorted-dictionary)
  * [Sorted List](#sorted-list)
- [OOPS Concepts](#oops-concepts)
- [Access Specifiers](#access-specifiers)
- [Method Overloading](#method-overloading)
- [`sealed` keyword](#sealed-keyword)


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
### One dimensional 
```
int[] numbers = {1, 4, 2};

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
```
### Multi dimensional 
```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
```
### Jagged (Array of Arrays)

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
## `static` keyword
Declare elements that belong to the class itself, rather than to an instance of the class.
```
public class MyClass {
   public static void SayHello() {
      Console.WriteLine("Hello, world!");
   }
}
MyClass.SayHello();
```
## `this` keyword
### To access instance variables
```
class Person
{
    private string name;
 
    public void SetName(string name)
    {
        this.name = name; // using 'this' to access instance variable
    }
}
```
### To call another constructor of the same class
```
class Person
{
    private string name;
 
    public Person()
    {
        // calling another constructor of the same class
        this("John Doe"); 
    }
 
    public Person(string name)
    {
        this.name = name;
    }
}
```
### To pass the current object as a parameter
```
class Person
{
    private string name;
 
    public void PrintName()
    {
        // passing the current object as a parameter
        Helper.Print(this);
    }
}
 
class Helper
{
    public static void Print(Person person)
    {
        Console.WriteLine(person.name);
    }
}
```
## Constructors & Destructors
### Constructors
```
public class Person
{
    public string Name;
    public int Age;

    // Default constructor
    public Person()
    {
        Name = "John Doe";
        Age = 0;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Create a person object using the default constructor
Person person1 = new Person();

// Create a person object using the parameterized constructor
Person person2 = new Person("Jane Smith", 30);
```
### Destructors
```
public class MyClass
{
    public MyClass()
    {
        System.Console.WriteLine("Constructor called");
    }

    ~MyClass()
    {
        System.Console.WriteLine("Destructor called");
    }
}

// Create a new object of MyClass
MyClass obj = new MyClass();

// Dispose of the object
obj = null;
System.GC.Collect();
```
## Generics
```
using System;

class Program
{
    static void Main(string[] args)
    {
        // create a generic method object with an int parameter
        GenericMethod<int> obj1 = new GenericMethod<int>();
        obj1.Print(123);

        // create a generic method object with a string parameter
        GenericMethod<string> obj2 = new GenericMethod<string>();
        obj2.Print("Hello");

        Console.ReadLine();
    }
}

class GenericMethod<T>
{
    public void Print(T value)
    {
        Console.WriteLine(value);
    }
}
```
## Collections
### Lists
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
### Hash sets
```
HashSet<string> set = new HashSet<string>();

// Add elements to the set
set.Add("Alice");
set.Add("Bob");
set.Add("Charlie");

// Check if an element is in the set
Console.WriteLine(set.Contains("Alice")); // Output: True
Console.WriteLine(set.Contains("Dave")); // Output: False

// Remove elements from the set
set.Remove("Bob");

// Iterate over the elements in the set
foreach (string name in set)
{
    Console.WriteLine(name);
}
```
### Stack
```
Stack<string> stack = new Stack<string>();

// Push elements onto the stack
stack.Push("Alice");
stack.Push("Bob");
stack.Push("Charlie");

// Pop elements off the stack
Console.WriteLine(stack.Pop()); // Output: Charlie
Console.WriteLine(stack.Pop()); // Output: Bob

// Peek at the top element of the stack
Console.WriteLine(stack.Peek()); // Output: Alice
```
### Queue
```
Queue<string> queue = new Queue<string>();

// Enqueue elements into the queue
queue.Enqueue("Alice");
queue.Enqueue("Bob");
queue.Enqueue("Charlie");

// Dequeue elements from the queue
Console.WriteLine(queue.Dequeue()); // Output: Alice
Console.WriteLine(queue.Dequeue()); // Output: Bob

// Peek at the front element of the queue
Console.WriteLine(queue.Peek()); // Output: Charlie
```
### Linked List
```
var linkedListDemo = new LinkedList<int>();
linkedListDemo.AddLast(1);
linkedListDemo.AddLast(2);  
linkedListDemo.AddLast(3);
linkedListDemo.AddLast(3);
linkedListDemo.AddLast(3);
linkedListDemo.AddLast(4);
linkedListDemo.AddLast(5);
foreach (var item in linkedListDemo) { Console.WriteLine(item); }
Console.WriteLine();
linkedListDemo.AddFirst(0);
foreach (var item in linkedListDemo) { Console.WriteLine(item); }
Console.WriteLine();
linkedListDemo.RemoveFirst();
linkedListDemo.RemoveLast();
foreach (var item in linkedListDemo) { Console.WriteLine(item); }
Console.WriteLine();
LinkedListNode<int> node = linkedListDemo.Find(3);

foreach (var item in linkedListDemo) {
    if (item == 3)
    {
        linkedListDemo.AddBefore(node, -1);
    }
    Console.WriteLine(item); 
}
```
### Sorted Set
```
// Create a new sorted set of integers
SortedSet<int> sortedSet = new SortedSet<int>();

// Add some elements to the set
sortedSet.Add(4);
sortedSet.Add(1);
sortedSet.Add(3);
sortedSet.Add(2);

// Iterate over the elements in the set
foreach (int num in sortedSet)
{
    System.Console.WriteLine(num);
}
```
### Sorted Dictionary
```
// Create a new sorted dictionary of strings and integers
SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();

// Add some key-value pairs to the dictionary
sortedDictionary.Add("one", 1);
sortedDictionary.Add("two", 2);
sortedDictionary.Add("three", 3);
sortedDictionary.Add("four", 4);

// Iterate over the key-value pairs in the dictionary
foreach (KeyValuePair<string, int> kvp in sortedDictionary)
{
    System.Console.WriteLine(kvp.Key + ": " + kvp.Value);
}
```
### Sorted List
```
// create a new sorted list
SortedList<string, int> sortedList = new SortedList<string, int>();

// add elements to the sorted list
sortedList.Add("apple", 3);
sortedList.Add("banana", 2);
sortedList.Add("orange", 4);
sortedList.Add("grape", 1);

// iterate through the sorted list
foreach (KeyValuePair<string, int> kvp in sortedList)
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}
```
# OOPS Concepts
## Access Specifiers
| Caller location         | Public | Protected Internal | Protected | Internal | Private Protected | Private |
| ---------------------------- | ------ | ------------------ | --------- | -------- | ----------------- | ------- |
| Within the class            | Yes    | Yes                | Yes       | Yes      | Yes               | Yes     |
| Derived class (Same assembly)| Yes    | Yes                | Yes       | Yes      | Yes               | No      |
| Non-Derived class (Same assembly)| Yes    | Yes                | No       | Yes      | No                | No      |
| Derived class (Different assembly)| Yes    | Yes                 | Yes        | No       | No                | No      |
| Non-Derived class (Different assembly)| Yes    | No                 | No        | No       | No                | No      |

## Method Overloading
```
class Program 
{
    private static void Method1() {
        Console.WriteLine("No Parameters");
    }
    private static void Method1(string s) {
        Console.WriteLine("1 Parameter = " + s);
    }
    static void Main(string[] args)
    {
        //Program p = new Program();
        Method1();
        Method1("krithika");
    }
}
// Output
// No Parameters
// 1 Parameter = Krithika
```
## `sealed` keyword
Sealed entities cannot be inherited.
```
// C# code to show restrictions
// of a Sealed Class
using System;

class Bird {

}

// Creating a sealed class
sealed class Test : Bird {
}

// Inheriting the Sealed Class
class Example : Test {
}

// Driver Class
class Program {

// Main Method
  static void Main()
  {
  
  }
}
// Output
// Error CS0509 ‘Example’ : cannot derive from sealed type ‘Test’
```
# File Handling
## 
