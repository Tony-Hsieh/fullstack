# C#

Based on Day1 code ConsoleApp1

# Question
1. static in C#  
You use static methods when the method does not need to access any non-static class elements such as properties, events, or methods in order to do it's job.  
Think of it this way: how many wheels does a car have? What colour is a car?
The first is a static question, because all cars have 4 wheels (if they had two they would be motorcycles, and three would make them tricycles). You don't need to establish which car you are talking about, because the question is generic to all cars.  
A non-static method can only be called on an object of a class that it belongs to. A static method can access only static members. A non-static method can access both static and non-static members because at the time when the static method is called, the class might not be instantiated (if it is called on the class itself). In the other case, a non-static method can only be called when the class has already been instantiated.

2. Property meaning
 https://www.w3schools.com/cs/cs_properties.php  
 provide public get and set methods, through properties, to access and update the value of a private field
