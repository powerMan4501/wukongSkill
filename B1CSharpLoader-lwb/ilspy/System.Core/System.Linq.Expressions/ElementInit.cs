using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public sealed class ElementInit : IArgumentProvider
{
	private MethodInfo _addMethod;

	private ReadOnlyCollection<Expression> _arguments;

	[global::__DynamicallyInvokable]
	public MethodInfo AddMethod
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _addMethod;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Arguments
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _arguments;
		}
	}

	[global::__DynamicallyInvokable]
	int IArgumentProvider.ArgumentCount
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _arguments.Count;
		}
	}

	internal ElementInit(MethodInfo addMethod, ReadOnlyCollection<Expression> arguments)
	{
		_addMethod = addMethod;
		_arguments = arguments;
	}

	[global::__DynamicallyInvokable]
	Expression IArgumentProvider.GetArgument(int index)
	{
		return _arguments[index];
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return ExpressionStringBuilder.ElementInitBindingToString(this);
	}

	[global::__DynamicallyInvokable]
	public ElementInit Update(IEnumerable<Expression> arguments)
	{
		if (arguments == Arguments)
		{
			return this;
		}
		return Expression.ElementInit(AddMethod, arguments);
	}
}
