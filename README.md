# ProGrad C# Training

## Table of Contents
### [Fundamentals](#fundamentals-1)
- [Basic C# Syntax](#basic-c-syntax)
- [Conditional Statements](#conditional-statements)
  * [if-else](#if-else)
- [Loops](#loops)
  * [For loop](#for-loop)
  * [While Loop](#while-loop)
  * [Do while Loop](#do-while-loop)
- [String Manipulation](#string-manipulation)
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
- [Delegates](#delegates)
  * [Delegate between classes](#delegate-between-classes)
  * [Multi Cast delegate](#multi-cast-delegate)
  * [`getInvocationList()`](#getInvocationList)
- [Anonymous Methods](#anonymous-methods)
- [Lambda Functions](#lambda-functions)
- [`get` and `set`](#get-and-set)
- [`Action` keyword](#action-keyword)
- [`Func` keyword](#func-keyword)
- [`Predicate` keyword](#predicate-keyword)
  
### [OOPS Concepts](#oops-concepts-1)
- [Access Specifiers](#access-specifiers)
- [Method Overloading](#method-overloading)
- [Method Overriding](#method-overriding)
- [Inheritance](#inheritance)
  * [Single Inheritance](#single-inheritance)
  * [Multi-level Inheritance](#multi-level-inheritance)
  * [Hierarchical Inheritance](#hierarchical-inheritance)
- [Interfaces](#interfaces)
- [`abstract` keyword](#abstract-keyword)
- [`virtual` keyword](#virtual-keyword)
- [`abstract` vs `virtual`](#abstract-vs-virtual)
- [`sealed` keyword](#sealed-keyword)

### [File Handling](#file-handling-1)
- [Using File](#using-file)
- [Using FileWriter](#using-filewriter)
- [Using StreamWriter and StreamReader](#using-streamwriter-and-streamreader)
- [Using TextWriter and TextReader](#using-textwriter-and-textreader)

### [Asynchronous Programming](#asynchronous-programming-1)
- [`async()` and `await()`] keywords


# Fundamentals
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
## String Manipulation
| Method Name | Description |
|-------------|-------------|
| `Length` | Gets the number of characters in the string |
| `ToUpper()` | Returns a new string that converts all characters in this instance to uppercase |
| `ToLower()` | Returns a new string that converts all characters in this instance to lowercase |
| `Trim()` | Returns a new string in which all leading and trailing white-space characters are removed |
| `Substring(int startIndex, int length)` | Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length |
| `IndexOf(char value)` | Returns the zero-based index of the first occurrence of the specified Unicode character in the string |
| `IndexOf(string value)` | Returns the zero-based index of the first occurrence of the specified string in the string |
| `Contains(string value)` | Returns a value indicating whether a specified substring occurs within this string |
| `Replace(char oldChar, char newChar)` | Returns a new string in which all occurrences of a specified character in the current instance are replaced with another specified character |
| `Replace(string oldValue, string newValue)` | Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string |
| `Split(char[] separator)` | Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array |
| `StartsWith(string value)` | Determines whether the beginning of this string instance matches the specified string |
| `EndsWith(string value)` | Determines whether the end of this string instance matches the specified string |
| `Concat(string[] values)` | Concatenates one or more instances of String |
| `Join(string separator, string[] value)` | Concatenates all the elements of a string array, using the specified separator between each element |
| `Format(string format, object arg0)` | Replaces one or more format items in a specified string with the string representation of a specified object |
| `Equals(object obj)` | Determines whether the specified object is equal to the current object |
| `Equals(string value)` | Determines whether two specified strings have the same value |
| `Compare(string strA, string strB)` | Compares two specified String objects and returns an integer that indicates their relative position in the sort order |
| `CompareTo(string strB)` | Compares this instance with a specified object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified object |
| `ToUpperInvariant()` | Returns a new string that converts all characters in this instance to uppercase, using the casing rules of the invariant culture |
| `ToLowerInvariant()` | Returns a new string that converts all characters in this instance to lowercase, using the casing rules of the invariant culture |
| `ToCharArray()` | Copies the characters in this instance to a Unicode character array |
| `PadLeft(int totalWidth)` | Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length |
| `PadRight(int totalWidth)` | Returns a new string that right-aligns the characters in this string by padding them with spaces on the right, for a specified total length |

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
## Delegates
```
// Declare a delegate
delegate int additionDelegate(int a, int b);
internal class Program
{
    public static int addNumbers(int a, int b) {
        return a + b;
    }
    static void Main(string[] args)
    {
        additionDelegate adder = addNumbers;
        Console.WriteLine(adder.Invoke(5, 9));
        Console.WriteLine(adder(15, 9));
    }
}
```
### Delegate between classes
```
public class MyClass
{
    public delegate int DelegateAdd(int a, int b);
}
internal class Program
{
    static int Add(int a, int b)
    { return a + b; }
    //static int Sub(int a,int b) {  return a - b; }
    public static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        MyClass.DelegateAdd Dsum = Add;
        Console.WriteLine(Dsum(2, 4));
        Console.WriteLine(Dsum.Invoke(2, 5));
    }
}
```
### Multi Cast Delegate
```
delegate int CalculateDelegate(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        CalculateDelegate add = new CalculateDelegate(new Calculator().Add);
        CalculateDelegate subtract = new CalculateDelegate(new Calculator().Subtract);
        CalculateDelegate multiply = new CalculateDelegate(new Calculator().Multiply);
       
        int result1 = add.Invoke(5, 3);
        int result2 = subtract.Invoke(5, 3);
        int result3 = multiply.Invoke(5, 3);

        Console.WriteLine("Addition result: " + result1);
        Console.WriteLine("Subtraction result: " + result2);
        Console.WriteLine("Multiplication result: " + result3);
    }
}

class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }
}
```
### `getInvocationList()`
```
delegate int mathOperations(int a, int b);
static void Main(string[] args)
{
    mathOperations total = Add;
    total += Subtract;
    total += Multiply;

    foreach (var method in total.GetInvocationList())

    {
        Console.WriteLine(method.DynamicInvoke(5,3));
    }
}

public static int Add(int x, int y)
{
    return x + y;
}

public static int Subtract(int x, int y)
{
    return x - y;
}

public static int Multiply(int x, int y)
{
    return x * y;
}
```
## Anonymous Methods
```
delegate int DelegateForSum(int x, int y);
delegate void printMessage(string s);
delegate void noParameter();
internal class AnonymousFunctionsDemo
{
    public static void Main(String [] args){
        DelegateForSum dAdd = delegate (int a, int b) { return a + b; };
        printMessage dMesssage = delegate (string s) { Console.WriteLine("Hello " + s); };
        noParameter np = delegate () { Console.WriteLine("No Paramter"); };
        Console.WriteLine(dAdd(3, 4));
        dMesssage("Krithika");
        np();
    }
}
```
## Lambda Functions
```
internal class LambdaDemo
{
    delegate int GreatestDelegate(int a, int b);
    public static void Main(String[] args)
    {
        GreatestDelegate sum = (num1, num2) => (num1 > num2) ? num1 : num2 ;
        Console.WriteLine(sum(9, 8));
    }
}
```
```
public static void Main(String[] args)
{
    var greater = (int num1, int num2) => (num1 > num2) ? num1 : num2;
    Console.WriteLine(greater(9, 8));
}
```
```
public static void Main(String[] args)
{
    var sum = (int num1, int num2) => (num1 + num2); 
    var sub = (int sum, int num2) => (sum - num2);    
    Console.WriteLine(sub(sum(9,8), 1));
}
```
```
public static void Main(String[] args)
{
    List<int> L1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    List<int> divisible_by_5 = (L1).FindAll((int n) => n % 5 == 0);
    Console.WriteLine(string.Join(" ", divisible_by_5));
}
```
## `get` and `set`
```
internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public static void Main(string[] args)
    {

        List<Student> student_list = new List<Student>();
        student_list.Add(new Student() { Id = 1, Name = "Krithika", Age = 20});
        student_list.Add(new Student() { Id = 2, Name = "Sai", Age = 20});
        student_list.Add(new Student() { Id = 3, Name = "Priya", Age = 20});
        student_list.Add(new Student() { Id = 4, Name = "Nithya", Age = 20});
        foreach (Student student in student_list)
        {
            Console.WriteLine("Name = "+student.Name);

        }
    }
}
 ```
## `Action` keyword
It is a type of built-in delegate.
```
Action<string> writerDelegate = (message) => Console.WriteLine("The message is = " + message);
writerDelegate("Test Message");
```
## `Func` keyword
It is a type of built-in delegate. But we can specify output parameters as well.
```
Func<int, int, int> multiplier = (a, b) =>  a * b;
Console.WriteLine("Product = " +multiplier(11, 7));
```
## `Predicate` keyword
```
List<int> numbers = new List<int> { 2, 7, 4, 9, 1, 5, 6, 3 };
Predicate<int> p = x => x > 5;
List<int> greaterThanFive = numbers.FindAll(p);
Console.WriteLine(string.Join(" ",greaterThanFive));
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
## Method Overriding
```
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}
```
```
Animal animal = new Animal();
animal.MakeSound(); // writes "The animal makes a sound" to the console

Dog dog = new Dog();
dog.MakeSound(); // writes "The dog barks" to the console
```
## Inheritance
### Single Inheritance
```
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

Dog myDog = new Dog();
myDog.Eat();
myDog.Bark();
```
### Multi-level Inheritance
```
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

Dog myDog = new Dog();
myDog.Eat();
myDog.Run();
myDog.Bark();
```
### Hierarchical Inheritance
```
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing...");
    }
}

Dog myDog = new Dog();
myDog.Eat();
myDog.Bark();

Cat myCat = new Cat();
myCat.Eat();
myCat.Meow();
```
## Interfaces
Interfaces can be used to establish Multiple inheritance without the need for classes.
```
using System;

interface IAnimal
{
    void Move();
}

interface IPet
{
    void Play();
}

class Cat : IAnimal, IPet
{
    public void Move()
    {
        Console.WriteLine("Cat is walking");
    }

    public void Play()
    {
        Console.WriteLine("Cat is playing");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat myCat = new Cat();
        myCat.Move();
        myCat.Play();
    }
}
```
## `abstract` keyword
```
public abstract class Animal
{
    public abstract void Speak(); // abstract method
}

public class Dog : Animal
{
    public override void Speak() // implement the abstract method in derived class
    {
        Console.WriteLine("Bark!");
    }
}
```
```
Animal a = new Dog();
a.Speak(); // output: Bark!
```
## `virtual` keyword
```
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}
```
## `abstract` vs `virtual`
| Virtual                                          | Abstract                                         |
|--------------------------------------------------|--------------------------------------------------|
| Can have method body                             | Cannot have method body                                       |
| Can be overridden in derived classes             | Must be implemented by derived classes                        |
| Must have a default implementation in the base class  | No implementation in the base class                           |
| Use `virtual` keyword to declare                 | Use `abstract` keyword to declare                              |

## `sealed` keyword
Sealed entities cannot be inherited.
```
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
## Using File
```
File.WriteAllText("C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\filedemoplain.txt", "This is Krithika");
```
## Using FileWriter 
```
string s = "Hello!";
Console.WriteLine("Inside File handling");
FileStream fs = new FileStream("C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\filename.txt", FileMode.OpenOrCreate);
byte[] content = Encoding.UTF8.GetBytes(s);
fs.Write(content, 0, content.Length);
fs.Close();
```
## Using StreamWriter and StreamReader
```
FileStream fs1 = new FileStream("C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\textwriter.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
Stream stream = new MemoryStream();
StreamWriter writer = new StreamWriter(fs1);
writer.WriteLine("StreamWriter Demo");
Console.WriteLine("Written");
writer.Close();

StreamReader reader = new StreamReader(fs1);
string c = reader.ReadToEnd();
Console.WriteLine(c);
fs1.Close();
```
## Using TextWriter and TextReader
```
const string path = "C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\textwriter.txt";
using (TextWriter textWriter = File.CreateText(path))
{
    char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
    textWriter.WriteLine(charArray);
}

using (TextReader textReader = File.OpenText(path))
{
    Console.WriteLine(textReader.Read());
}
```

# Asynchronous Programming
## `async()` and `await()`
```
internal class newClass
{

    public async Task<string> Method1()
    {
        Console.WriteLine("Method 1 started");
        await Task.Delay(6000);
        Console.WriteLine("Method 1 ended");
        return "";
    }

    public async Task<string> Method2()
    {
        Console.WriteLine("Method 2 started");
        await Task.Delay(4000);
        Console.WriteLine("Method 2 ended");
        return "";
    }
    public async Task<string> Method3()
    {
        Console.WriteLine("Method 3 started");
        await Task.Delay(2000);
        Console.WriteLine("Method 3 ended");
        return "";
    }
}
internal class AsyncProgramming
{
    static async Task Main(string[] args)
    {

        newClass obj = new newClass();
        Console.WriteLine("Without await");
        obj.Method1();
        obj.Method2();
        obj.Method3();
        Console.ReadLine();
        Console.WriteLine("With await");

        await obj.Method1();
        await obj.Method2();
        await obj.Method3();
        Console.ReadLine();

    }

}

/*
Output
Without await
Method 1 started
Method 2 started
Method 3 started
Method 3 ended
Method 2 ended
Method 1 ended
ok
With await
Method 1 started
Method 1 ended
Method 2 started
Method 2 ended
Method 3 started
Method 3 ended
*/
```
