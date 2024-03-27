using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Fraction class using the contructor with no parameters
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetDecimalValue()}");

        // Create an instance of the Fraction class using the contructor with one parameter
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");

        // Create an instance of the Fraction class using the contructor with two parameters
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

        // Create an instance of the Fraction class using the contructor with two parameters
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"{fraction4.GetFractionString()}");
        Console.WriteLine($"{fraction4.GetDecimalValue()}");
        
        // fraction.SetTop(4);
        // fraction.SetBottom(456);
        int numerator = fraction1.GetTop(); 
        int denominator = fraction1.GetBottom();


    }
}