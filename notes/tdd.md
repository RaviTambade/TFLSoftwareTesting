## “TDD – Write the Test First, Then Write the Code”

**Hi learners! 👋**

Let me tell you about a powerful mindset that **transformed the way I build software** — it's called **Test-Driven Development**, or simply **TDD**.

Many years ago, I was mentoring a junior developer on a shopping app. He wrote thousands of lines of code — and then said, "Sir, now I will write test cases."
I smiled and said:

> “Why chase bugs later… when you can stop them at the gate?”

That’s when I introduced him to **TDD — the art of writing tests before writing code**.

### 🎯 What is TDD?

TDD flips traditional thinking.
Instead of **writing code first and testing later**, you write a **failing test first**, then build just enough code to make it pass, and finally **refactor**.

We call this rhythm the **Red–Green–Refactor** cycle:

### 🔴 **Red** – Start with a Failing Test

🧪 Think of this like a detective setting a trap.

* "I expect the cart total to be ₹200 when I add 2 items worth ₹100 each."
* But hey — there’s no cart code yet!
* So the test **fails** (that’s good!) — this tells you what you’re *about* to build.

### 🟢 **Green** – Write Just Enough Code to Pass

Now comes the coder's time to shine.
You **only write the bare minimum code** needed to pass the test.

No polishing. No extras. Just **get the test to go green**. ✅

### 🔁 **Refactor** – Clean and Polish

Now that the test passes — you **improve your code**:

* Rename confusing variables
* Split large methods
* Remove duplication

But here’s the magic — all while your test stays **green**.

### 🧪 Why TDD Feels Like a Superpower

Let me tell you what my student said 2 weeks into TDD:

> “Sir, I’m catching my own bugs before anyone else even sees my code!”

Here’s why:

* ✅ You write **better designs** — because you think from a user’s view.
* 🔄 You build a **safety net** of tests — so you can refactor boldly.
* 📚 You create **living documentation** — anyone can read the tests and understand the system.

## 🛍️ Real-Life Example: TDD in an E-Commerce App

Let’s now walk through a **realistic scenario** — you're building an **online shopping cart**. I want you to imagine that you’re wearing the **hat of both developer and tester**.

### 📦 **Story 1: Add Items to Cart**

> "As a user, I want to add items to my cart and see the total price."

1. **🔴 Red Phase**:

   * Write a test: “Cart should return ₹300 after adding 3 items of ₹100 each.”
   * It fails — perfect!

2. **🟢 Green Phase**:

   * Add minimal code: a `Cart` class, `addItem()` method, and `getTotal()` logic.

3. **🔁 Refactor**:

   * Maybe introduce a `CartItem` model or a `calculateTotal()` method for clarity.

### 🧾 **Story 2: Apply Discount Code**

> "As a user, I want to apply a discount code and reduce the total."

1. **🔴 Red**: Write a test with a 10% discount applied — it fails.
2. **🟢 Green**: Implement the `applyDiscount("SAVE10")` method.
3. **🔁 Refactor**: Move discount rules to a separate service.

### 💳 **Story 3: Checkout and Payment**

> "As a user, I want to checkout and complete my purchase."

1. **🔴 Red**: Write a test that ensures `checkout()` returns `PaymentSuccess`.
2. **🟢 Green**: Build a stub `PaymentGateway` and make it return success.
3. **🔁 Refactor**: Introduce error handling and retry logic.

### 🎯 Bonus Tests:

* What if item stock is zero?
* What if the discount code is invalid?
* What if payment fails?

Every new scenario becomes a **new test first**, then code later.

## 🔍 Mentor's Wisdom: Why TDD Works in the Real World

Imagine you’re walking across a **rope bridge**. Every step you take is a test.
If a plank breaks, the test fails — and you **know exactly which plank** to fix.

That’s what TDD gives you:

* Confidence to **move fast**
* Discipline to **write clean code**
* Protection against **regressions**

And here’s the beautiful part — **your tests grow with your app**.

### 👨‍🎓 Want to Practice TDD?

Here’s a mini challenge you can try:

* Create a simple `BankAccount` class.
* Start by writing a failing test: “Account should have ₹0 on creation.”
* Add methods like `deposit()`, `withdraw()`, and write tests before each.
* Introduce scenarios like “insufficient balance” or “daily limit exceeded.”

You’ll begin to *think like a user*, *code like an engineer*, and *test like a pro*.

 

## 🧠 Final Words from Your Mentor

> “TDD is not just about tests. It’s a way of thinking — build with proof, improve with courage.”

So next time you sit down to write code, don’t ask:

> “What should I write?”

Ask:

> “What should work — and how will I prove it?”

And that’s how you become a **craftsman**, not just a coder. 🎯

 
