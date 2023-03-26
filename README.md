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
