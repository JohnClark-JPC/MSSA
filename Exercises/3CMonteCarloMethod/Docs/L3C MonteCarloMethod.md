C# provides the `System.Random` class which generates random numbers. By generating many random values, you can estimate the result of complicated mathematical equations via a technique known as the Monte Carlo method. In this exercise, you will estimate the value of pi (![LaTeX: \pi](https://erau.instructure.com/equation_images/%255Cpi)ππ) using a Monte-Carlo method.

Envision a unit circle (i.e., a circle with ![LaTeX: radius=1](https://erau.instructure.com/equation_images/radius%253D1)r a d i u s = 1r a d i u s = 1). Specifically, we will work with the top right quadrant where all valid points are between { x = 0, y = 0 } and { x = 1, y = 1 }. By randomly generating many x, y pairs and calculating the length of the hypotenuse of a triangle with sides of length x, y using the Pythagorean theorem, ![LaTeX: hypotenuse=\sqrt{x^2+y^2}](https://erau.instructure.com/equation_images/hypotenuse%253D%255Csqrt%257Bx%255E2%252By%255E2%257D)h y p o t e n u s e = x 2 + y 2h y p o t e n u s e = x 2 + y 2, you can classify the pairs into those that overlap the unit circle (![LaTeX: \left\{hypotenuse\mid hypotenuse\:\le1\right\}](https://erau.instructure.com/equation_images/%255Cleft%255C%257Bhypotenuse%255Cmid%2520hypotenuse%255C%253A%255Cle1%255Cright%255C%257D){ h y p o t e n u s e ∣ h y p o t e n u s e ≤ 1 }{ h y p o t e n u s e ∣ h y p o t e n u s e ≤ 1 }) and those that fall outside the unit circle (![LaTeX: \left\{hypotenuse\mid hypotenuse\:>1\right\}](https://erau.instructure.com/equation_images/%255Cleft%255C%257Bhypotenuse%255Cmid%2520hypotenuse%255C%253A%253E1%255Cright%255C%257D){ h y p o t e n u s e ∣ h y p o t e n u s e > 1 }{ h y p o t e n u s e ∣ h y p o t e n u s e > 1 }). The ratio of pairs that overlap the unit circle divided by the total number of pairs generated is the area of the unit circle in the top right quadrant.

### Procedure

In a new project:

1. Create a function which, given an instance of a `System.Random` object as a parameter, returns a tuple of two uniformly distributed random floating point numbers between 0 and 1.

2. Create a function which takes two doubles called `x` and `y` and returns a double corresponding to the hypotenuse of a triangle with sides of lengths `x`, `y`.

3. Build a `Main` method which takes one `int` parameter (which we'll call "`iterations`") from the command line.

4. Iterate 

   ```
   iterations
   ```

    times. For each iteration, you should:

   1. generate a new `x`, `y` pair,
   2. take the hypotenuse of the pair, and
   3. increment a counter for each coordinate which overlaps the unit circle

5. Divide the number of coordinate pairs overlapping the unit circle by the total number of `iterations`. Multiply the resulting value by 4.

6. Print the value from step #5 along with the absolute value of the difference between your estimate of and the library-provided value of ![LaTeX: \pi](https://erau.instructure.com/equation_images/%255Cpi)ππ, `Math.PI`.

7. Run your program, passing 10, 100, 1000, and 10000 as the command line parameter. Record the output of your program as comments in your source file.

### Questions

1. Why do we multiply the value from step 5 above by 4?
2. What do you observe in the output when running your program with parameters of increasing size?
3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
4. Find a parameter that requires multiple seconds of run time. What is that parameter?
5. How accurate is the estimated value of pi?
6. Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.

### Submission

Submit your solution as a single .cs source file. Include the answers to the questions as comments.