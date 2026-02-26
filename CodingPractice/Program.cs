using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

// 1

Foo.Car fooCar = new Foo.Car();
fooCar.Go();

Bar.Car barCar = new Bar().Car();
barCar.Go();

namespace Foo
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}

namespace Bar
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}

// 2

Korea.Seoul.Car seoulCar = new Korea.Seoul.Car();
seoulCar.Run();

Korea.Incheon.Car incheonCar = new Korea.Incheon.Car();
incheonCar.Run();

namespace Korea.Seoul
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("서울 자동차가 달립니다.");
        }
    }
}

namespace Korea.Incheon
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("인천 자동차가 달립니다");
        }
    }
}

// 3

using static System.Console;
using static System.Math;

WriteLine("Hello, World");

double result = Sqrt(16);
Console.WriteLine($"제곱근: {result}");

double maxValue = double.MaxValue(10, 20);
Console.WriteLine($"최댓값: {maxValue}");