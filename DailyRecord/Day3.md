# Inheritance

Examples should be from real world example.
BaseEmployee, PartTime, FullTime


# Question 
1. property VS variable


2. public class VS class  
    public class can be used outside while class can only be used internally.

3. Enum.GetNames(typeof(Options))


4. hiding VS overriding
    * Method Overriding: https://www.geeksforgeeks.org/c-sharp-method-overriding/
    * Method Hiding: 
        * https://www.c-sharpcorner.com/UploadFile/8911c4/different-between-method-overriding-method-hiding-new-keyw/
        * https://www.geeksforgeeks.org/method-hiding-in-c-sharp/
    * Difference: https://www.tutorialspoint.com/What-is-the-difference-between-overriding-and-hiding-in-Chash#:~:text=Hiding%20redefines%20the%20complete%20method,access%20the%20child%20class%20methods.


5. abstract VS virtual  
    Virtual methods have an implementation and provide the derived classes with the option of overriding it. Abstract methods do not provide an implementation and force the derived classes to override the method.  
    So, abstract methods have no actual code in them, and subclasses HAVE TO override the method. Virtual methods can have code, which is usually a default implementation of something, and any subclasses CAN override the method using the override modifier and provide a custom implementation.
