### Assignment

This activity consists of four programming exercises. The following exercises are open book and open note. You are free to use any written documentation you wish. However, these are individual exercises, and you cannot consult with each other in writing your programs. At a minimum, your program must compile successfully and run.

 

#### Basic Difficulty

**Area and circumference of circle**
Write a program that calculates both the area and the circumference of a circle given the radius ![LaTeX: r](https://erau.instructure.com/equation_images/r)r. Assume that ![LaTeX: r](https://erau.instructure.com/equation_images/r)r is greater than zero, but not necessarily an integer. Use these formulas. The C# syntax for the square root is `Math.Sqrt()`. ![LaTeX: \pi](https://erau.instructure.com/equation_images/%255Cpi)π is `Math.PI`.

![LaTeX: \begin{gather*} \textrm{Circumference} = 2 \pi r \\ \textrm{Area} = \pi r^2 \end{gather*}](https://erau.instructure.com/equation_images/%255Cbegin%257Bgather*%257D%250A%255Ctextrm%257BCircumference%257D%2520%253D%25202%2520%255Cpi%2520r%2520%255C%255C%250A%255Ctextrm%257BArea%257D%2520%253D%2520%255Cpi%2520r%255E2%250A%255Cend%257Bgather*%257D)Circumference = 2 π r Area = π r 2

**Volume of a hemisphere**
Write a program that calculates the volume of a hemisphere given the length of the radius. Assume that the radius is not negative.

![LaTeX: \begin{gather*} \textrm{Volume} = \frac{\frac{4}{3}\pi r^3}{2} \end{gather*}](https://erau.instructure.com/equation_images/%255Cbegin%257Bgather*%257D%250A%255Ctextrm%257BVolume%257D%2520%253D%2520%255Cfrac%257B%255Cfrac%257B4%257D%257B3%257D%255Cpi%2520r%255E3%257D%257B2%257D%250A%255Cend%257Bgather*%257D)Volume = 4 3 π r 3 2

#### Intermediate Difficulty

**Area of triangle given the length of the sides**
Write a program that calculates the area of a triangle given the length of the three sides. Use Heron's formula, below. Sides are designated ![LaTeX: a](https://erau.instructure.com/equation_images/a)a, ![LaTeX: b](https://erau.instructure.com/equation_images/b)b, and ![LaTeX: c](https://erau.instructure.com/equation_images/c)c. ![LaTeX: p](https://erau.instructure.com/equation_images/p)p is half the circumference, or ![LaTeX: \frac{a+b+c}{2}](https://erau.instructure.com/equation_images/%255Cfrac%257Ba%2Bb%2Bc%257D%257B2%257D)a + b + c 2. Assume that the length of every side is an integer greater than zero.

![LaTeX: \begin{gather*} p = \frac{a + b + c}{2} \\ \textrm{Area} = \sqrt{p(p-a)(p-b)(p-c)} \end{gather*}](https://erau.instructure.com/equation_images/%255Cbegin%257Bgather*%257D%250Ap%2520%253D%2520%255Cfrac%257Ba%2520%2B%2520b%2520%2B%2520c%257D%257B2%257D%2520%255C%255C%250A%255Ctextrm%257BArea%257D%2520%253D%2520%255Csqrt%257Bp%2528p-a%2529%2528p-b%2529%2528p-c%2529%257D%250A%255Cend%257Bgather*%257D)p = a + b + c 2 Area = p ( p − a ) ( p − b ) ( p − c )

#### Advanced Difficulty

**Solving a quadratic equation**
Write a program that solves a quadratic equation. The formula is given below. The coefficients for the terms are ![LaTeX: a](https://erau.instructure.com/equation_images/a)a for ![LaTeX: x^2](https://erau.instructure.com/equation_images/x%255E2)x 2, ![LaTeX: b](https://erau.instructure.com/equation_images/b)b for ![LaTeX: x](https://erau.instructure.com/equation_images/x)x, and ![LaTeX: c](https://erau.instructure.com/equation_images/c)c. Assume that the coefficients are non-negative integers, that is, a coefficient could be zero. Also note that the term under the square root symbol will not give a valid answer for this problem if it is negative. (You cannot take the square root of a negative number … we are not using imaginary numbers.) Also, note that many solutions will not work.

![LaTeX: \begin{gather*} ax^2 + bx + c = 0 \\  x = \frac{- b \pm \sqrt{b^2 - 4ac}}{2a} \end{gather*}](https://erau.instructure.com/equation_images/%255Cbegin%257Bgather*%257D%250Aax%255E2%2520%2B%2520bx%2520%2B%2520c%2520%253D%25200%2520%255C%255C%250A%2520x%2520%253D%2520%255Cfrac%257B-%2520b%2520%255Cpm%2520%255Csqrt%257Bb%255E2%2520-%25204ac%257D%257D%257B2a%257D%250A%255Cend%257Bgather*%257D)a x 2 + b x + c = 0 x = − b ± b 2 − 4 a c 2 a

 

#### Template

```c#
namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here

            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");

            // Implementation here

            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here

            Console.WriteLine($"The area is {area}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            // Implementation here

            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }
    }
}
```

