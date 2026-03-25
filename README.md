# Prey Predator — Starter Project

## Overview
You are building a simulation of a small ecosystem: **lice** (luizen) and **ladybugs** (lieveheersbeestjes).
Each round, animals move, try to breed, and ladybugs hunt lice.
The goal of this exercise is to practice **interfaces**, **abstract classes**, and **polymorphism** in C#.

---

## Recommended build order

Work through the files in this order. Each step builds on the previous one.

### 1. `Position.cs`
Start here — it has no dependencies on anything else.
Implement the property setters (clamping to [0, 15]) and the four Move methods.

### 2. `Contracts/IAnimal.cs` and `Contracts/IPredator.cs`
Fill in the missing members. Read the comments carefully —
each member has a short description of what it should do.
`IAnimalWorld.cs` is already complete for reference.

### 3. `Animal.cs` (abstract class)
Implement the three TODO methods: `StopDisplaying`, `UpdateDisplay`, and `Move`.
`DisplayOn` is already done for you — study it first, it shows the pixel math.

### 4. `Louse.cs`
Only one method to implement: `TryBreed`.
Think about the two conditions: *minimum age* and *breeding interval*.

### 5. `LadyBug.cs`
Three methods: `TryBreed`, `CanEat`, and `Hunt`.
The private helper `CalculateDistanceTo` is a good place to start.

### 6. `AnimalWorld.cs`
`AddAnimal` is straightforward.
`ProcessRound` is the most complex — read the warning about modifying lists during iteration!

### 7. `MainWindow.xaml.cs`
Wire everything together. The XAML is already provided.

---

## Self-check tests

A set of automated checks is included in the solution.
To run them, open the test explorer. 

Tests are grouped by class, so you can check your progress section by section.

---

## Key concepts to keep in mind

### Interface vs abstract class
| | Interface | Abstract class |
|---|---|---|
| Can contain implementation? | No (only signatures) | Yes (some methods can be concrete) |
| Multiple inheritance? | Yes | No |
| Use when... | defining a *contract* any class can fulfil | sharing *common code* among related classes |

`Animal` is abstract because all animals share the same movement and display logic.
`IAnimal`, `IPredator`, `IDisplayable` are interfaces because they define *what* something can do, not *how*.

### Why `IAnimalWorld` instead of `AnimalWorld` in MainWindow?
```csharp
private IAnimalWorld _insectWorld;   // ✅ depends on the contract
private AnimalWorld  _insectWorld;   // ❌ depends on the concrete class
```
Using the interface type means you could swap `AnimalWorld` for a completely different implementation
without touching `MainWindow`. That is the power of programming to interfaces.

### The `is` keyword
```csharp
if (animal is IPredator predator)
{
    predator.Hunt(AllAnimals);   // predator is already cast, no extra cast needed
}
```
This pattern (called *pattern matching*) both checks the type and casts in one step.

### Modifying a list during iteration
```csharp
// 💥 This crashes at runtime:
foreach (var animal in AllAnimals)
    AllAnimals.Remove(animal);

// ✅ Collect first, modify after:
var toRemove = new List<IAnimal>();
foreach (var animal in AllAnimals)
    if (animal.IsDead) toRemove.Add(animal);
foreach (var dead in toRemove)
    AllAnimals.Remove(dead);
```

---

## Expected behaviour
- Start: 100 lice (green-yellow), 10 ladybugs (red)
- Lice breed every 2 rounds, die at age 6
- Ladybugs breed every 4 rounds, die at age 16 or after 3 rounds without food
- A ladybug eats any louse within a Euclidean distance of 3 grid cells

Good luck! 