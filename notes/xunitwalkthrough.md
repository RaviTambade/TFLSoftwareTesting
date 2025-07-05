👨‍🏫  Let’s Write Your First xUnit Test

*"Imagine you’ve just built a calculator class. How do you know your `Add` method actually adds correctly? You don’t want to hope — you want a test that proves it. Let’s do that together using xUnit, right from the command line so you see everything under the hood."*


✅ **Step 1: Create a Solution and Projects**

Open your terminal (or PowerShell), and let’s start fresh:

```bash
mkdir XUnitDemo
cd XUnitDemo
dotnet new sln -n XUnitDemo
```

Now, create your main project:

```bash
dotnet new classlib -n CalculatorLib
dotnet sln add CalculatorLib/CalculatorLib.csproj
```

And create a separate test project:

```bash
dotnet new xunit -n CalculatorLib.Tests
dotnet sln add CalculatorLib.Tests/CalculatorLib.Tests.csproj
```


✅ **Step 2: Add Project Reference**

Your test project needs to reference your library so it can test it:

```bash
dotnet add CalculatorLib.Tests reference CalculatorLib
```


✅ **Step 3: Write Your Code Under Test**

Let’s add a simple calculator in `CalculatorLib/Calculator.cs`:

```csharp
namespace CalculatorLib;

public class Calculator
{
    public int Add(int a, int b) => a + b;
}
```


✅ **Step 4: Write Your First Test**

Open `CalculatorLib.Tests/UnitTest1.cs` and replace it with:

```csharp
using Xunit;
using CalculatorLib;

namespace CalculatorLib.Tests;

public class CalculatorTests
{
    [Fact] // This attribute tells xUnit: "This is a test!"
    public void Add_ReturnsCorrectSum()
    {
        // Arrange: set up objects
        var calculator = new Calculator();

        // Act: perform the action
        int result = calculator.Add(2, 3);

        // Assert: verify the result
        Assert.Equal(5, result);
    }
}
```

🔎 **Mentor’s Explanation of the Test:**

* **\[Fact]** — Like a stamp saying *this method is a test case*.
* **Arrange** — You prepare what you need.
* **Act** — You call the method you want to test.
* **Assert** — You check the result matches your expectation.

✅ **Step 5: Run Your Tests**

From the root of your solution:

```bash
dotnet test
```

You’ll see output like:

```
Passed!  - Failed: 0, Passed: 1, Skipped: 0, Total: 1, Duration: ...
```

🎉 That’s your first xUnit test passing!


✅ **Step 6: Make It Fail to See It Work**

Your mentor says: *"Tests should fail when they should."*
Change the expected result in your test:

```csharp
Assert.Equal(999, result);
```

Run again:

```bash
dotnet test
```

And you’ll see:

```
Failed CalculatorTests.Add_ReturnsCorrectSum
Assert.Equal() Failure
Expected: 999
Actual:   5
```

This proves your test *really* checks your logic — and isn’t passing by accident.

🌟 **Mentor’s Wisdom:**

*"A passing test gives you confidence. A failing test gives you information. Both are your allies. As you grow, your test suite grows with you — catching regressions before your users ever see them. And xUnit makes this easy, fast, and reliable."*

✅ **You’ve Learned:**

✔️ How to scaffold a solution with a library + test project.
✔️ How to add a reference to connect them.
✔️ How to write your first xUnit `[Fact]` test.
✔️ How to run tests and interpret results.

