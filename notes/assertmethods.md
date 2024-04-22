# Assert Methods (Commonly used)

In xUnit, assertions are made using various methods provided by the Assert class. These methods are used to validate expected outcomes in your test methods. Here are some commonly used assertion methods in xUnit:

1. **Equal / NotEqual**:
   - `Assert.Equal(expected, actual)`: Verifies that the expected value is equal to the actual value.
   - `Assert.NotEqual(expected, actual)`: Verifies that the expected value is not equal to the actual value.

2. **True / False**:
   - `Assert.True(condition)`: Verifies that the condition is true.
   - `Assert.False(condition)`: Verifies that the condition is false.

3. **Null / NotNull**:
   - `Assert.Null(obj)`: Verifies that the object is null.
   - `Assert.NotNull(obj)`: Verifies that the object is not null.

4. **Empty / NotEmpty**:
   - `Assert.Empty(collection)`: Verifies that the collection is empty.
   - `Assert.NotEmpty(collection)`: Verifies that the collection is not empty.

5. **Contains / DoesNotContain**:
   - `Assert.Contains(expectedItem, collection)`: Verifies that the collection contains the expected item.
   - `Assert.DoesNotContain(expectedItem, collection)`: Verifies that the collection does not contain the expected item.

6. **InRange / NotInRange**:
   - `Assert.InRange(actual, low, high)`: Verifies that the actual value is within the specified range.
   - `Assert.NotInRange(actual, low, high)`: Verifies that the actual value is not within the specified range.

7. **Throws / DoesNotThrow**:
   - `Assert.Throws<ExceptionType>(action)`: Verifies that the specified action throws an exception of the specified type.
   - `Assert.DoesNotThrow(action)`: Verifies that the specified action does not throw any exceptions.

8. **IsType / IsNotType**:
   - `Assert.IsType<ExpectedType>(obj)`: Verifies that the object is of the expected type.
   - `Assert.IsNotType<UnexpectedType>(obj)`: Verifies that the object is not of the unexpected type.

9. **Collection / Subset**:
   - `Assert.Collection(collection, asserts)`: Verifies that the collection contains elements that satisfy the specified assertions.
   - `Assert.Subset(expected, actual)`: Verifies that the actual collection is a subset of the expected collection.

These are just a few examples of commonly used assertion methods in xUnit. Depending on your testing needs, you may use additional assertion methods provided by xUnit or custom assertion methods tailored to your specific requirements. By using assertion methods effectively, you can ensure that your test methods accurately validate the behavior and outcomes of your code under test.