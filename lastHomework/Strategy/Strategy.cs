interface IStrategy
{
	public int DoOperation(int num1, int num2);
}


class OperationAdd : IStrategy
{
	public int DoOperation(int num1, int num2)
		=> num1 + num2;
}


class OperationSubstract : IStrategy
{
	public int DoOperation(int num1, int num2)
		=> num1 - num2;
}


public class OperationMultiply : IStrategy
{
	public int DoOperation(int num1, int num2)
		 => num1 * num2;
}


class Context
{
	private IStrategy strategy;

	public Context(IStrategy strategy)
		=> this.strategy = strategy;

	public int executeStrategy(int num1, int num2)
		=> strategy.DoOperation(num1, num2);
}


/*class Program
{
	static void Main()
	{
		Context context = new Context(new OperationAdd());

		Console.WriteLine("259 + 925 = " + context.executeStrategy(259, 925));

		context = new Context(new OperationSubstract());
		Console.WriteLine("925 - 259 = " + context.executeStrategy(925, 259));

		context = new Context(new OperationMultiply());
		Console.WriteLine("25 * 9 = " + context.executeStrategy(9, 25));
	}
}*/