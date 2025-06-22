// multiply.test.js
const math = require("./math");   ///AUT

describe('multiply function', () => {
  it('should return the product of two numbers', () => {
    expect(math.multiply(2, 3)).toEqual(6);
    expect(math.multiply(0, 5)).toEqual(0);
    expect(math.multiply(-2, 3)).toEqual(-6);
    expect(math.multiply(-2, -3)).toEqual(6);
  });
});