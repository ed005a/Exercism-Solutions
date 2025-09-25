public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation == null)
            throw new ArgumentNullException();
        if (operation == "-") throw new ArgumentOutOfRangeException();
        if (operation.Length > 1) throw new ArgumentOutOfRangeException();
        if (operation == "+") return $"{operand1} + {operand2} = {(operand1 + operand2).ToString()}";
        if (operation == "*") return $"{operand1} * {operand2} = {(operand1 * operand2).ToString()}";
        if (operation == "/" && operand2 != 0) return $"{operand1} / {operand2} = {(operand1 / operand2).ToString()}";
        if (operation == "/" && operand2 == 0) return "Division by zero is not allowed.";
        throw new ArgumentException();
    }
}
