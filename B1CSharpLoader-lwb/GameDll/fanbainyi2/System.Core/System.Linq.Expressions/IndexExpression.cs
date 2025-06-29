using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class IndexExpression : Expression, IArgumentProvider
{
	private readonly Expression _instance;

	private readonly PropertyInfo _indexer;

	private IList<Expression> _arguments;

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Index;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_indexer != null)
			{
				return _indexer.PropertyType;
			}
			return _instance.Type.GetElementType();
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Object
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _instance;
		}
	}

	[global::__DynamicallyInvokable]
	public PropertyInfo Indexer
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _indexer;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Arguments
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Expression.ReturnReadOnly(ref _arguments);
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

	internal IndexExpression(Expression instance, PropertyInfo indexer, IList<Expression> arguments)
	{
		_ = indexer == null;
		_instance = instance;
		_indexer = indexer;
		_arguments = arguments;
	}

	[global::__DynamicallyInvokable]
	public IndexExpression Update(Expression @object, IEnumerable<Expression> arguments)
	{
		if (@object == Object && arguments == Arguments)
		{
			return this;
		}
		return Expression.MakeIndex(@object, Indexer, arguments);
	}

	[global::__DynamicallyInvokable]
	Expression IArgumentProvider.GetArgument(int index)
	{
		return _arguments[index];
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitIndex(this);
	}

	internal Expression Rewrite(Expression instance, Expression[] arguments)
	{
		return Expression.MakeIndex(instance, _indexer, arguments ?? _arguments);
	}
}
