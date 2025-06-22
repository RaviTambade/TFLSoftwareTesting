// math_bdd.test.js
describe('Multiplication', () => {
    test('Multiply two numbers', () => {
      // Given
      const a = 5;
      const b = 10;
  
      // When
      const result = multiply(a, b);
  
      // Then
      expect(result).toEqual(50);
    });
  });
  
  function multiply(a, b) {
    return a * b;
  }