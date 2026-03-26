using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# COMPREHENSIVE TUTORIAL ===");
            Console.WriteLine("Welcome to learning C# programming!");
            Console.WriteLine();

            // 1. BASIC SYNTAX AND DATA TYPES
            Console.WriteLine("1. BASIC SYNTAX AND DATA TYPES");
            Console.WriteLine("================================");
            BasicSyntaxAndDataTypes();
            Console.WriteLine();

            // 2. CONTROL FLOW
            Console.WriteLine("2. CONTROL FLOW");
            Console.WriteLine("================");
            ControlFlowExamples();
            Console.WriteLine();

            // 3. METHODS AND FUNCTIONS
            Console.WriteLine("3. METHODS AND FUNCTIONS");
            Console.WriteLine("=========================");
            MethodsExample();
            Console.WriteLine();

            // 4. OBJECT-ORIENTED PROGRAMMING
            Console.WriteLine("4. OBJECT-ORIENTED PROGRAMMING");
            Console.WriteLine("================================");
            ObjectOrientedExample();
            Console.WriteLine();

            // 5. COLLECTIONS
            Console.WriteLine("5. COLLECTIONS");
            Console.WriteLine("===============");
            CollectionsExample();
            Console.WriteLine();

            // 6. LINQ (LANGUAGE INTEGRATED QUERY)
            Console.WriteLine("6. LINQ EXAMPLES");
            Console.WriteLine("=================");
            LINQExample();
            Console.WriteLine();

            // 7. EXCEPTION HANDLING
            Console.WriteLine("7. EXCEPTION HANDLING");
            Console.WriteLine("======================");
            ExceptionHandlingExample();
            Console.WriteLine();

            Console.WriteLine("=== TUTORIAL COMPLETE ===");
            Console.WriteLine("Keep practicing to master C#!");
        }

        // SECTION 1: BASIC SYNTAX AND DATA TYPES
        static void BasicSyntaxAndDataTypes()
        {
            Console.WriteLine("Variables and Data Types:");
            
            // Integer types
            int age = 25;                    // 32-bit integer
            long bigNumber = 9000000000L;    // 64-bit integer (L suffix)
            short smallNumber = 100;         // 16-bit integer
            byte tinyNumber = 255;           // 8-bit integer (0-255)
            
            Console.WriteLine($"Age (int): {age}");
            Console.WriteLine($"Big number (long): {bigNumber}");
            Console.WriteLine($"Small number (short): {smallNumber}");
            Console.WriteLine($"Tiny number (byte): {tinyNumber}");
            
            // Floating-point types
            double price = 19.99;            // 64-bit decimal
            float temperature = 36.5f;        // 32-bit decimal (f suffix)
            decimal preciseValue = 123.456m;  // 128-bit precise decimal (m suffix)
            
            Console.WriteLine($"Price (double): {price}");
            Console.WriteLine($"Temperature (float): {temperature}");
            Console.WriteLine($"Precise value (decimal): {preciseValue}");
            
            // Character and string
            char grade = 'A';                 // Single character
            string name = "John Doe";         // Text
            bool isStudent = true;            // Boolean (true/false)
            
            Console.WriteLine($"Grade (char): {grade}");
            Console.WriteLine($"Name (string): {name}");
            Console.WriteLine($"Is student (bool): {isStudent}");
            
            // Constants
            const double PI = 3.14159;
            Console.WriteLine($"PI constant: {PI}");
            
            // String operations
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;  // Concatenation
            string interpolated = $"{firstName} {lastName}"; // String interpolation
            
            Console.WriteLine($"Full name (concatenation): {fullName}");
            Console.WriteLine($"Full name (interpolation): {interpolated}");
            Console.WriteLine($"Name length: {fullName.Length}");
            Console.WriteLine($"Upper case: {fullName.ToUpper()}");
        }

        // SECTION 2: CONTROL FLOW
        static void ControlFlowExamples()
        {
            Console.WriteLine("If-Else Statements:");
            
            int score = 85;
            
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
            
            Console.WriteLine("\nSwitch Statement:");
            
            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the work week");
                    break;
                case "Friday":
                    Console.WriteLine("Almost weekend!");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend!");
                    break;
                default:
                    Console.WriteLine("Regular day");
                    break;
            }
            
            Console.WriteLine("\nFor Loop:");
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }
            
            Console.WriteLine("\nWhile Loop:");
            
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine($"While count: {count}");
                count++;
            }
            
            Console.WriteLine("\nDo-While Loop:");
            
            int doCount = 0;
            do
            {
                Console.WriteLine($"Do-While count: {doCount}");
                doCount++;
            } while (doCount < 3);
            
            Console.WriteLine("\nForeach Loop:");
            
            string[] fruits = { "Apple", "Banana", "Orange" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }
        }

        // SECTION 3: METHODS AND FUNCTIONS
        static void MethodsExample()
        {
            Console.WriteLine("Method Calls:");
            
            // Calling methods with different parameters
            int sum = Add(5, 3);
            Console.WriteLine($"Add(5, 3) = {sum}");
            
            string greeting = Greet("Alice");
            Console.WriteLine(greeting);
            
            // Method with out parameter
            int.TryParse("123", out int result);
            Console.WriteLine($"Parsed number: {result}");
            
            // Method with ref parameter
            int number = 10;
            DoubleValue(ref number);
            Console.WriteLine($"Doubled value: {number}");
        }

        // Helper methods for Section 3
        static int Add(int a, int b)
        {
            return a + b;
        }

        static string Greet(string name)
        {
            return $"Hello, {name}! Welcome to C#.";
        }

        static void DoubleValue(ref int value)
        {
            value = value * 2;
        }

        // SECTION 4: OBJECT-ORIENTED PROGRAMMING
        static void ObjectOrientedExample()
        {
            Console.WriteLine("Creating Objects:");
            
            // Creating instances of classes
            Person person1 = new Person("John", 25);
            Person person2 = new Person("Alice", 30);
            
            person1.Introduce();
            person2.Introduce();
            
            // Using properties
            Console.WriteLine($"{person1.Name} is {person1.Age} years old");
            
            // Inheritance example
            Student student = new Student("Bob", 20, "Computer Science");
            student.Introduce();
            student.Study();
            
            // Polymorphism example
            Person[] people = { person1, person2, student };
            Console.WriteLine("\nPolymorphism Example:");
            foreach (Person person in people)
            {
                person.Introduce();
            }
        }

        // SECTION 5: COLLECTIONS
        static void CollectionsExample()
        {
            Console.WriteLine("Lists:");
            
            // List - dynamic array
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            
            Console.WriteLine("Names in list:");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }
            
            Console.WriteLine($"\nTotal names: {names.Count}");
            Console.WriteLine($"First name: {names[0]}");
            
            Console.WriteLine("\nDictionary:");
            
            // Dictionary - key-value pairs
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Alice"] = 25;
            ages["Bob"] = 30;
            ages["Charlie"] = 35;
            
            Console.WriteLine("Ages dictionary:");
            foreach (KeyValuePair<string, int> kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} years old");
            }
            
            Console.WriteLine($"\nBob's age: {ages["Bob"]}");
            
            Console.WriteLine("\nArray:");
            
            // Array - fixed size
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.WriteLine($"- {num}");
            }
            
            Console.WriteLine($"\nArray length: {numbers.Length}");
        }

        // SECTION 6: LINQ EXAMPLES
        static void LINQExample()
        {
            Console.WriteLine("LINQ Query Examples:");
            
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // Where - filtering
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine($"- {num}");
            }
            
            // OrderBy - sorting
            var sortedNumbers = numbers.OrderByDescending(n => n);
            Console.WriteLine("\nNumbers in descending order:");
            foreach (int num in sortedNumbers)
            {
                Console.WriteLine($"- {num}");
            }
            
            // Select - projection
            var squaredNumbers = numbers.Select(n => n * n);
            Console.WriteLine("\nSquared numbers:");
            foreach (int num in squaredNumbers)
            {
                Console.WriteLine($"- {num}");
            }
            
            // Complex query
            var result = numbers
                .Where(n => n > 5)
                .OrderBy(n => n)
                .Select(n => new { Number = n, Square = n * n });
            
            Console.WriteLine("\nComplex query (numbers > 5, sorted, with squares):");
            foreach (var item in result)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }
        }

        // SECTION 7: EXCEPTION HANDLING
        static void ExceptionHandlingExample()
        {
            Console.WriteLine("Try-Catch Examples:");
            
            // Example 1: Divide by zero
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: Cannot divide by zero! {ex.Message}");
            }
            
            // Example 2: Invalid array index
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine($"Value at index 5: {arr[5]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: Array index out of range! {ex.Message}");
            }
            
            // Example 3: Finally block
            try
            {
                Console.WriteLine("Attempting risky operation...");
                string text = null;
                int length = text.Length; // This will throw NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: Null reference! {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Cleanup code in finally block");
            }
            
            // Example 4: Throwing custom exceptions
            try
            {
                ValidateAge(15);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation error: {ex.Message}");
            }
        }

        // Helper method for exception handling
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or older");
            }
            Console.WriteLine("Age is valid");
        }
    }

    // SUPPORTING CLASSES FOR OOP SECTION

    // Base class
    class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        
        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        // Method
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }

    // Derived class (inheritance)
    class Student : Person
    {
        public string Major { get; set; }
        
        // Constructor
        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
        }
        
        // Override method (polymorphism)
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, I'm {Age} years old, and I study {Major}.");
        }
        
        // Additional method
        public void Study()
        {
            Console.WriteLine($"{Name} is studying {Major}.");
        }
    }
}
