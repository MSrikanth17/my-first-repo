# C# Comprehensive Tutorial

Welcome to this complete C# learning tutorial! This program is designed to teach you C# programming from the ground up with clear explanations and practical examples.

## 🚀 Getting Started

### Prerequisites
- .NET SDK (version 10.0 or later)
- A code editor (Visual Studio Code, Visual Studio, or any C# IDE)

### How to Run the Tutorial

1. **Open the project folder in your terminal**
   ```bash
   cd /Users/srikanthmartha/HelloDotNet
   ```

2. **Run the tutorial program**
   ```bash
   dotnet run --project . CSHARP_TUTORIAL.cs
   ```
   
   Alternatively, you can compile and run:
   ```bash
   dotnet build
   dotnet run
   ```

## 📚 Tutorial Sections

### 1. Basic Syntax and Data Types
Learn the fundamental building blocks of C#:
- **Integer types**: `int`, `long`, `short`, `byte`
- **Floating-point types**: `double`, `float`, `decimal`
- **Text types**: `string`, `char`
- **Boolean type**: `bool`
- **Constants** with `const`
- **String operations** and interpolation

### 2. Control Flow
Master program flow control:
- **If-Else statements** for conditional logic
- **Switch statements** for multiple conditions
- **Loops**: `for`, `while`, `do-while`, `foreach`
- **Nested control structures**

### 3. Methods and Functions
Learn how to organize code:
- **Method declaration** and parameters
- **Return values**
- **`out` parameters** for multiple return values
- **`ref` parameters** for passing by reference
- **Method overloading**

### 4. Object-Oriented Programming (OOP)
Understand OOP concepts:
- **Classes and objects**
- **Properties** (getters/setters)
- **Constructors**
- **Inheritance** (base and derived classes)
- **Polymorphism** (method overriding)
- **Encapsulation**

### 5. Collections
Work with data structures:
- **List<T>** - Dynamic arrays
- **Dictionary<TKey, TValue>** - Key-value pairs
- **Arrays** - Fixed-size collections
- **Iteration** through collections

### 6. LINQ (Language Integrated Query)
Learn modern data querying:
- **`Where()`** - Filtering data
- **`OrderBy()`** - Sorting data
- **`Select()`** - Transforming data
- **Chaining** multiple LINQ operations
- **Anonymous types** in queries

### 7. Exception Handling
Write robust code:
- **Try-Catch blocks**
- **Specific exception types**
- **Finally blocks** for cleanup
- **Throwing custom exceptions**
- **Best practices** for error handling

## 🎯 Learning Tips

### For Beginners
1. **Run each section independently** - Modify the `Main` method to run only specific sections
2. **Experiment with the code** - Change values and see what happens
3. **Read the console output carefully** - Each example includes explanatory text
4. **Try the exercises** - Modify the code to test your understanding

### Code Structure
- **Clear comments** explain every concept
- **Real-world examples** make concepts relatable
- **Progressive complexity** - starts simple and builds up
- **Complete, runnable code** - every example works independently

## 🔧 Customization

### Running Specific Sections
To focus on a particular topic, modify the `Main` method:

```csharp
static void Main(string[] args)
{
    // Only run basic syntax
    Console.WriteLine("1. BASIC SYNTAX AND DATA TYPES");
    Console.WriteLine("================================");
    BasicSyntaxAndDataTypes();
}
```

### Adding Your Own Examples
Create new methods following the same pattern:
```csharp
static void MyCustomExample()
{
    Console.WriteLine("My Custom Example:");
    // Your code here
}
```

## 📖 Additional Resources

### Documentation
- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET API Reference](https://docs.microsoft.com/en-us/dotnet/api/)

### Practice Platforms
- [HackerRank](https://www.hackerrank.com/domains/csharp)
- [LeetCode](https://leetcode.com/)
- [Codewars](https://www.codewars.com/)

## 🐛 Troubleshooting

### Common Issues
1. **"dotnet command not found"** - Install .NET SDK
2. **Compilation errors** - Check for typos and missing semicolons
3. **Runtime errors** - Read the exception messages carefully

### Getting Help
- Read the error messages - they're usually very descriptive
- Check the Microsoft documentation
- Experiment with small changes to understand the behavior

## 🎉 Next Steps

After completing this tutorial:
1. **Build a small project** - Apply what you've learned
2. **Explore advanced topics** - Async/await, delegates, events
3. **Learn about .NET ecosystem** - ASP.NET, Entity Framework
4. **Practice regularly** - Coding is a skill that improves with practice

---

**Happy Coding!** 🚀

This tutorial provides a solid foundation in C# programming. Remember, the best way to learn is by doing - so experiment, break things, and fix them. That's how real learning happens!
