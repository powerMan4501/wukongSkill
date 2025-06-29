namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public abstract class DynamicExpressionVisitor : ExpressionVisitor
{
	[global::__DynamicallyInvokable]
	protected DynamicExpressionVisitor()
	{
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression VisitDynamic(DynamicExpression node)
	{
		return base.VisitDynamic(node);
	}
}
