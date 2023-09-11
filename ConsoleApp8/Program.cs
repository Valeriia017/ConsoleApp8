using System;

public class Square
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public bool Correct()
    {
        return side > 0;
    }

    public double Area()
    {
        return side * side;
    }

    public double Perimeter()
    {
        return side * 4;
    }

    public void Print()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Значення поля: " + side);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            Console.WriteLine("Введіть значення сторони квадрата:");
            double side = Convert.ToDouble(Console.ReadLine());

            Square square = new Square(side);

            square.Print();

            if (square.Correct())
            {
                Console.WriteLine("Площа: " + square.Area());
                Console.WriteLine("Периметр: " + square.Perimeter());
            }
            else
            {
                Console.WriteLine("Об'єкт не може існувати.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}

