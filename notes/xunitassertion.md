 
#  Why \[Theory] is Like Testing on Steroids

*"Imagine you’re testing a tax calculator. You don’t want to write a separate test for every tax rate: 5%, 12%, 18%, 28%… That’s tedious and error-prone. What if you could write **one test method** that runs multiple times with different inputs and expected outputs? That’s exactly what \[Theory] gives you: one smart test, many scenarios covered."*



🔎 **The Difference: \[Fact] vs \[Theory]**

* **\[Fact]**: Runs once, with no input parameters — a single scenario.
* **\[Theory]**: Runs multiple times, each with a different set of input data — like turning one test into many.

✅ **Let’s Write a \[Theory] Example**

In your existing `CalculatorTests` class, add this new test:

```csharp
using Xunit;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, -1, -2)]
    [InlineData(100, 200, 300)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsExpectedSum_ForMultipleInputs(int a, int b, int expected)
    {
        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
```

🔍 **Mentor’s Explanation:**

* **\[Theory]** tells xUnit: “This test has input parameters.”
* **\[InlineData(...)]** provides sets of inputs (a, b) and the expected result for each run.
* xUnit will automatically run your test once for every \[InlineData] you specify.


✅ **Run Your Tests**

From your solution root:

```bash
dotnet test
```

You’ll see output like:

```
Passed CalculatorTests.Add_ReturnsExpectedSum_ForMultipleInputs(a: 2, b: 3, expected: 5)
Passed CalculatorTests.Add_ReturnsExpectedSum_ForMultipleInputs(a: -1, b: -1, expected: -2)
Passed CalculatorTests.Add_ReturnsExpectedSum_ForMultipleInputs(a: 100, b: 200, expected: 300)
Passed CalculatorTests.Add_ReturnsExpectedSum_ForMultipleInputs(a: 0, b: 0, expected: 0)
```

🎉 Four test cases from one method — cleaner code, better coverage!

💡 **Why \[Theory] is So Valuable:**

Your mentor says with a grin:

*"When you write parameterized tests with \[Theory], you don’t just avoid repetition — you **express your intent**: 'This behavior should work across a variety of data.' And that intent makes your tests clear, your coverage thorough, and your future self (and teammates) grateful."*


🚀 **Advanced: Use MemberData or ClassData for Complex Scenarios**

What if your data sets are too big or dynamic for \[InlineData]? Use \[MemberData] or \[ClassData] to supply test data from methods or classes. Example:

```csharp
public static IEnumerable<object[]> AddTestData => new List<object[]>
{
    new object[] { 1, 1, 2 },
    new object[] { 5, 5, 10 },
    new object[] { -10, 20, 10 },
};

[Theory]
[MemberData(nameof(AddTestData))]
public void Add_ReturnsExpectedSum_WithMemberData(int a, int b, int expected)
{
    int result = _calculator.Add(a, b);
    Assert.Equal(expected, result);
}
```

✅ **The Takeaway:**

* Use **\[Theory]** + **\[InlineData]** for quick data-driven tests.
* Use **\[MemberData]**/**\[ClassData]** when you need dynamic or complex test data.
* Parameterized tests help you **cover more scenarios with less duplicated code**, leading to robust and maintainable tests.
