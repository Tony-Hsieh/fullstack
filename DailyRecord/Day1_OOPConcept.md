# OOP
* Encapsulation:- all member function/variables must be defined inside the class.

* Inheritance:- Child class can access all members of parent class for reusability

* Polymorphism:- A member can be used in many forms for multiple purposes.

* Abstraction:- Hide the discreet implementation and show only few features.

# Common Type System (CTS)
The Common Type System (CTS) is a standard for defining and using data types in the .NET framework. CTS defines a collection of data types, which are used and managed by the run time to facilitate cross-language integration.  
VB.Net, C++.Net, C#, J# for Java, F# for Fortran

# Value type vs Reference type

* value type stores the values directly but reference type stores the memory address of the value
* Value type can not accept null but reference type can accept null
* value types are struct, enum but reference  types are class, interface, array, pointers
* value types are not dealt by garbage collector but reference types are removed by garbage collector
* value types are stored are in stack memory but reference types are stored in heap memory

**struct, enum are value type.**  
int a = 10;  
int a = null; (X)

**class, interface, array, pointers are reference type**  
string str = "demo"; //X10AF0  
string a = null; (O)

# C#
C# Basic: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm

# Question

1. What is struct?  
    From: https://www.c-sharpcorner.com/article/understanding-structures-in-C-Sharp/  
    
    1. Structures provide better performance when we have small collections of value-types that you want to group together.
 
    2. Use Structure if all member fields are of value type. Use Class if any one member is of reference type.
 
    3. In C#, using a value type instead of a reference type will result in fewer objects on the managed heap, which results in a lesser load on the garbage collector (GC), less frequent GC cycles, and consequently better performance. However, value types have their downsides too. Passing around a big struct is definitely costlier than passing a reference, that's one obvious problem.
 
    4. A class is a reference type. When an object of the class is created, the variable to which the object is assigned holds only a reference to that memory. When the object reference is assigned to a new variable, the new variable refers to the original object. Changes made through one variable are reflected in the other variable because they both refer to the same data. A struct is a value type. **When a struct is created, the variable to which the struct is assigned holds the struct's actual data. When the struct is assigned to a new variable, it is copied. The new variable and the original variable, therefore, contain two separate copies of the same data. Changes made to one copy do not affect the other copy.** In general, classes are used to model more complex behavior or data that is intended to be modified after a class object is created. Structs are best suited for small data structures that contain primarily data that is not intended to be modified after the struct is created.
 
    5. A struct is a value type. If you assign a struct to a new variable, the new variable will contain a copy of the original.

2. value and reference type?  
    https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type  
    
    Extended: Python => pass-by-object-reference  
    https://medium.com/@lokeshsharma596/is-python-call-by-value-or-call-by-reference-2dd7db74dbd0


