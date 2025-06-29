using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
{
	private ExpressionType _operation;

	[global::__DynamicallyInvokable]
	public sealed override Type ReturnType
	{
		[global::__DynamicallyInvokable]
		get
		{
			ExpressionType operation = _operation;
			if ((uint)(operation - 83) <= 1u)
			{
				return typeof(bool);
			}
			return typeof(object);
		}
	}

	[global::__DynamicallyInvokable]
	public ExpressionType Operation
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _operation;
		}
	}

	internal sealed override bool IsStandardBinder => true;

	[global::__DynamicallyInvokable]
	protected UnaryOperationBinder(ExpressionType operation)
	{
		ContractUtils.Requires(OperationIsValid(operation), "operation");
		_operation = operation;
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
	{
		return FallbackUnaryOperation(target, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.Requires(args == null || args.Length == 0, "args");
		return target.BindUnaryOperation(this);
	}

	internal static bool OperationIsValid(ExpressionType operation)
	{
		switch (operation)
		{
		case ExpressionType.Negate:
		case ExpressionType.UnaryPlus:
		case ExpressionType.Not:
		case ExpressionType.Decrement:
		case ExpressionType.Extension:
		case ExpressionType.Increment:
		case ExpressionType.OnesComplement:
		case ExpressionType.IsTrue:
		case ExpressionType.IsFalse:
			return true;
		default:
			return false;
		}
	}
}
