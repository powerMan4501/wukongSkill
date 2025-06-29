namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public interface IDynamicExpression : IArgumentProvider
{
	[global::__DynamicallyInvokable]
	Type DelegateType
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	Expression Rewrite(Expression[] args);

	[global::__DynamicallyInvokable]
	object CreateCallSite();
}
