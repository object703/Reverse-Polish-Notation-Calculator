using System;
using System.Linq;
using System.Windows.Forms;

namespace RPN
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        public double Evaluate(string expression)
        {
            /*
             * 1. Split the expression into individual tokens using a space as the delimiter.
             * 2. Iterate over each token:
             *      - If the token is a number, push it onto the stack.
             *      - If the token is an operator (+, -, *, /):
             *          a. Pop two numbers from the stack (b first, then a).
             *          b. Perform the operation (a + b, a - b, etc.).
             *          c. Push the result back onto the stack.
             * 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
             *    Pop and return it as the final result.
             */

            string[] tokens = expression.Split(' ');
            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double value))
                {
                    stack.Push(value);
                }

                string[] operators = new string[4] { "+", "-", "*", "/" };
                if (operators.Any(token.Contains))
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;

                        case "-":
                            stack.Push(a - b);
                            break;

                        case "*":
                            stack.Push(a * b);
                            break;

                        case "/":
                            stack.Push(a / b);
                            break;
                    }
                }
            }

            return stack.Pop();
        }
    }
}
