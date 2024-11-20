using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ct7
{
    //public interface IConverter<in T, out U>
    //{
    //    U Convert(T value);
    //}

    //public class StringToIntConverter : IConverter<string, int>
    //{
    //    public int Convert(string value) => int.Parse(value);
    //}

    //public class ObjectToStringConverter : IConverter<object, string>
    //{
    //    public string Convert(object value) => value.ToString();
    //}

    //public static class ConverterHelper
    //{
    //    public static U[] ConvertArray<T, U>(T[] values, IConverter<T, U> converter)
    //    {
    //        U[] result = new U[values.Length];
    //        for (int i = 0; i < values.Length; i++)
    //        {
    //            result[i] = converter.Convert(values[i]);
    //        }
    //        return result;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        string[] strings = { "1", "2", "3" };
    //        var stringToInt = new StringToIntConverter();

    //        int[] integers = ConverterHelper.ConvertArray(strings, stringToInt);
    //        Console.WriteLine(string.Join(", ", integers));

    //        object[] objects = { 42, 3.14, "hello" };
    //        var objectToString = new ObjectToStringConverter();

    //        string[] stringsFromObjects = ConverterHelper.ConvertArray(objects, objectToString);
    //        Console.WriteLine(string.Join(", ", stringsFromObjects));
    //    }
    //}

    //public abstract class Animal
    //{
    //    public string Name { get; set; }
    //    public abstract void SayHello();
    //}

    //public class Dog : Animal
    //{
    //    public override void SayHello()
    //    {
    //        Console.WriteLine($"Гав! Я {Name}.");
    //    }
    //}

    //public class Cat : Animal
    //{
    //    public override void SayHello()
    //    {
    //        Console.WriteLine($"Mяу! Я {Name}.");
    //    }
    //}

    //public static class AnimalHelper
    //{
    //    public static void ProcessAnimals(List<Animal> animals, Action<Animal> action)
    //    {
    //        foreach (var animal in animals)
    //        {
    //            action(animal);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        var animals = new List<Animal>
    //    {
    //        new Dog { Name = "Бобик" },
    //        new Cat { Name = "Пушистик" }
    //    };

    //        AnimalHelper.ProcessAnimals(animals, animal => animal.SayHello());
    //    }
    //}
    public static class Calculator
    {
        public static double Add(double x, double y) => x + y;
        public static double Subtract(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Divide(double x, double y) => y != 0 ? x / y : throw new DivideByZeroException();

        public static double Calculate(double x, double y, Func<double, double, double> operation)
        {
            return operation(x, y);
        }
    }

    class Program
    {
        static void Main()
        {
            double a = 10, b = 20;

            Console.WriteLine($"Дополнение: {Calculator.Calculate(a, b, Calculator.Add)}");
            Console.WriteLine($"Вычитание: {Calculator.Calculate(a, b, Calculator.Subtract)}");
            Console.WriteLine($"Умножение: {Calculator.Calculate(a, b, Calculator.Multiply)}");
            Console.WriteLine($"Деление: {Calculator.Calculate(a, b, Calculator.Divide)}");
        }
    }


}
