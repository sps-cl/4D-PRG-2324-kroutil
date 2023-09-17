interface IOperation {
    int calculate(int a, int b);
}
class OpAdd implements IOperation {
    @Override
    public int calculate(int a, int b) {
        return a + b;
    }
}
class OpSub implements IOperation {
    @Override
    public int calculate(int a, int b) {
        return a - b;
    }
}
class OpMagic implements IOperation {
    @Override
    public int calculate(int a, int b) {
        return a * b;
    }
}
class CalculatorContext {
    private IOperation operation;
    public CalculatorContext(IOperation operation) {
        this.operation = operation;
    }
    public int executeOperation(int a, int b) {
        return operation.calculate(a, b);
    }
}
public class CalculatorApp {
    public static void main(String[] args) {
        CalculatorContext context = new CalculatorContext(new OpAdd());
        int result = context.executeOperation(10, 5);
        System.out.println(result); // Output: 15
        context = new CalculatorContext(new OpSub());
        result = context.executeOperation(10, 5);
        System.out.println(result); // Output: 5
        context = new CalculatorContext(new OpMagic());
        result = context.executeOperation(10, 5);
        System.out.println(result); // Output: 50
    }
}