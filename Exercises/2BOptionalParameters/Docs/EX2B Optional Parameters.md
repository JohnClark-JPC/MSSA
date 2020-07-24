Among other languages, C# provides a syntax for optional (or "default") parameters. This is a "syntactic sugar" which allows you to write one method which does the work of several overloaded methods. One such example would be the following:

```
// Can be called with 0, 1, or 2 parameters
void AnimalSound( string animal = "duck", string sound = "quack" )
{
    Console.WriteLine($"The {animal} goes \"{sound}\"!");
}
```

is equivalent to manually writing:

```
void AnimalSound( string animal, string sound )
{
    Console.WriteLine($"The {animal} goes \"{sound}\"!");
}

// Calls the two-parameter method with a default sound
void AnimalSound( string animal )
{
    AnimalSound( animal, "quack" );
}

// Calls the one-parameter method with a default animal
// OR
// Calls the two-parameter method with a default animal and sound
void AnimalSound()
{
    AnimalSound("duck");
    // OR
    // AnimalSound("duck", "quack");
}
```

## Assignment

1. Write a method that takes two optional parameters.
2. Manually write out the method you created in #1, this time using overloaded functions rather than optional parameters.
3. Using your own words in a comment at the top of your .cs file, describe "syntactic sugar".

## Submission

Submit your assignment as a single C# (.cs) file.