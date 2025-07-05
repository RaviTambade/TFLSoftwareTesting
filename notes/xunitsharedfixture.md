

# Why Shared Setup is Like a Well-Prepared Kitchen

*"Imagine you’re a chef. Every dish you cook in a night might use the same prep station, stove, or knife. You don’t set up a new kitchen for every dish. That would waste time and energy. In testing, you sometimes need the same heavy or expensive setup shared across multiple tests. That’s where xUnit’s \[Collection] and shared context come to the rescue — so you set up once, reuse often, and clean up properly."*


✅ **Why You Need Shared Context**

Your mentor explains:

* Sometimes your tests depend on **slow or expensive resources**, like:

  * Connecting to a test database
  * Starting a web server
  * Seeding data
* Setting this up for every single test wastes time and resources.
* But reusing the same setup must still **isolate tests logically** so they don’t interfere.


✅ **xUnit’s Solution: \[Collection] + ICollectionFixture**

**How it works:**
1️⃣ You define a **fixture class** with your shared resources.
2️⃣ You mark one or more test classes with `[Collection("name")]`.
3️⃣ xUnit creates a **single instance of the fixture per collection** and injects it into your tests.


✅ **Example: Shared Database Fixture**

Imagine you want to reuse an in-memory database across tests:

1️⃣ **Define the fixture class:**

```csharp
using System;

public class DatabaseFixture : IDisposable
{
    public FakeDatabase Database { get; private set; }

    public DatabaseFixture()
    {
        Console.WriteLine("Setting up shared DatabaseFixture...");
        Database = new FakeDatabase();
        Database.Connect();
    }

    public void Dispose()
    {
        Console.WriteLine("Cleaning up DatabaseFixture...");
        Database.Dispose();
    }
}
```

2️⃣ **Create a collection definition:**

```csharp
using Xunit;

[CollectionDefinition("Database collection")]
public class DatabaseCollection : ICollectionFixture<DatabaseFixture>
{
    // This class has no code, and is never created. 
    // Its only purpose is to apply [CollectionDefinition] to associate the fixture.
}
```

3️⃣ **Use the shared fixture in test classes:**

```csharp
using Xunit;

[Collection("Database collection")]
public class UserRepositoryTests
{
    private readonly DatabaseFixture _fixture;

    public UserRepositoryTests(DatabaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void AddUser_ShouldIncreaseUserCount()
    {
        var initialCount = _fixture.Database.UserCount;
        _fixture.Database.AddUser(new User { Name = "Alice" });

        Assert.Equal(initialCount + 1, _fixture.Database.UserCount);
    }
}

[Collection("Database collection")]
public class OrderRepositoryTests
{
    private readonly DatabaseFixture _fixture;

    public OrderRepositoryTests(DatabaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void AddOrder_ShouldIncreaseOrderCount()
    {
        var initialCount = _fixture.Database.OrderCount;
        _fixture.Database.AddOrder(new Order { Id = 1 });

        Assert.Equal(initialCount + 1, _fixture.Database.OrderCount);
    }
}
```

🔎 **Mentor’s Explanation:**

* `[Collection("Database collection")]` groups test classes into a logical collection that **shares the same fixture instance**.
* `ICollectionFixture<T>` tells xUnit which fixture to instantiate and pass into the test class constructor.
* xUnit automatically **creates one DatabaseFixture for all tests in the collection**, calls its constructor once, then cleans it up by calling `Dispose()` after all tests finish.

🚨 **Important Notes:**

* Tests in the same collection **run sequentially**, avoiding race conditions on shared state.
* Tests in different collections can still run in parallel.
* Shared fixtures are perfect for integration tests with shared external resources.


🌟 **Mentor’s Wisdom:**

*"With shared fixtures, you stop repeating expensive setup in every test. Instead, you **prepare once**, like a chef’s mise en place, and reuse confidently. You keep tests fast, isolated, and reliable — and you save yourself from unnecessary boilerplate."*


✅ **The Takeaway:**

* Use `[Collection]` + `ICollectionFixture` when you need to share setup across multiple test classes.
* xUnit manages lifecycle: construct once, dispose once.
* This pattern is a professional way to write **efficient integration or acceptance tests**.
