# Dependency Injection

## Repository for learning purposes, with basic examples 

- Dependency Injection is a design pattern and is one example of implementation
of the Dependency Inversion Principle(the D from SOLID)
- There is injection by constructor, where we write a private field on the class
containing the service or class we want to use
- Injection by interface, when the methods are inside the interfaces, and every
service we want to use will implement this interface, allowing to use a lot of
different services without problems
- Setter injection, when we use a property with the service, that implements 
the interface we want to use. So, when we create an object of the class, we can
pass the service as a property.


