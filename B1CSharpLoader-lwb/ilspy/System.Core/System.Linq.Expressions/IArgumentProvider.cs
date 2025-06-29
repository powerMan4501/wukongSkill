namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public interface IArgumentProvider
{
	[global::__DynamicallyInvokable]
	int ArgumentCount
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	Expression GetArgument(int index);
}
