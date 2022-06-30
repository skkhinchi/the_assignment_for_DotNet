# the_assignment_for_DotNet

## Assignment 1 :

> ### In visual studio, Create Classlibrary project. Declare a class Demo in it. In Demo class write member function called message that prints "I am great" on the terminal. Compile the project. Now add console application project in the same solution/workspace and in the console application use the Demo class reference and create its instance and call the function message.

 > - How to write class.
 > - How to print on console.
 > - How create class library.
 > - How to create console application.
 > - How reference project.

Solution: Ref Video : https://www.youtube.com/watch?v=pe1_zs1FEi0
: https://www.w3schools.com/cs/cs_classes.php

## Assignment 2:

> ### Write a class LengthHelper with function findLength that takes string as parameter and returns the length of string. This can be a class libarary/console. Create a unit test project using Xunit and write test cases to find length of string for "", "123", "123456789010", NULL.

> -  How to write test cases
> - Unit Testing

Solution: 
> - https://www.youtube.com/watch?v=VdDTxGnCGlw
> - https://docs.microsoft.com/en-us/dotnet/api/nunit.framework?view=xamarin-ios-sdk-12
> - https://docs.microsoft.com/en-us/dotnet/api/nunit.framework.assert.null?view=xamarin-ios-sdk-12


## Assignment 3:

> ### Read about Statics constructor, properties. Write a Singleton class called Counter. It will have two functions Increment and Decrement that will increase and decrease the count respectively. It has one property called count that returns the current counter. The class will have one static getinstance method to return the instance of Counter. Singleton typically means that only one instance of the class can be created.

Solution: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors

Static Constructor : A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed only once. It is called automatically before the first instance is created or any static members are referenced.

```
class SimpleClass
{
    // Static variable that must be initialized at run time.
    static readonly long baseline;

    // Static constructor is called at most one time, before any
    // instance constructor is invoked or member is accessed.
    static SimpleClass()
    {
        baseline = DateTime.Now.Ticks;
    }
}
```
What is singleton class in C# : 
Singleton Class allow for single allocations and instances of data. It has normal methods and you can call it using an instance. To prevent multiple instances of the class, the private constructor is used.

