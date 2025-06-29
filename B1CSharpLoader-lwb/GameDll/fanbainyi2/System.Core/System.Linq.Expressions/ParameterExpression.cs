using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
[global::__DynamicallyInvokable]
public class ParameterExpression : Expression
{
	private readonly string _name;

	[global::__DynamicallyInvokable]
	public override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(object);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Parameter;
		}
	}

	[global::__DynamicallyInvokable]
	public string Name
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _name;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsByRef
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetIsByRef();
		}
	}

	internal ParameterExpression(string name)
	{
		_name = name;
	}

	internal static ParameterExpression Make(Type type, string name, bool isByRef)
	{
		if (isByRef)
		{
			return new ByRefParameterExpression(type, name);
		}
		if (!type.IsEnum)
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				return new PrimitiveParameterExpression<bool>(name);
			case TypeCode.Byte:
				return new PrimitiveParameterExpression<byte>(name);
			case TypeCode.Char:
				return new PrimitiveParameterExpression<char>(name);
			case TypeCode.DateTime:
				return new PrimitiveParameterExpression<DateTime>(name);
			case TypeCode.DBNull:
				return new PrimitiveParameterExpression<DBNull>(name);
			case TypeCode.Decimal:
				return new PrimitiveParameterExpression<decimal>(name);
			case TypeCode.Double:
				return new PrimitiveParameterExpression<double>(name);
			case TypeCode.Int16:
				return new PrimitiveParameterExpression<short>(name);
			case TypeCode.Int32:
				return new PrimitiveParameterExpression<int>(name);
			case TypeCode.Int64:
				return new PrimitiveParameterExpression<long>(name);
			case TypeCode.Object:
				if (type == typeof(object))
				{
					return new ParameterExpression(name);
				}
				if (type == typeof(Exception))
				{
					return new PrimitiveParameterExpression<Exception>(name);
				}
				if (type == typeof(object[]))
				{
					return new PrimitiveParameterExpression<object[]>(name);
				}
				break;
			case TypeCode.SByte:
				return new PrimitiveParameterExpression<sbyte>(name);
			case TypeCode.Single:
				return new PrimitiveParameterExpression<float>(name);
			case TypeCode.String:
				return new PrimitiveParameterExpression<string>(name);
			case TypeCode.UInt16:
				return new PrimitiveParameterExpression<ushort>(name);
			case TypeCode.UInt32:
				return new PrimitiveParameterExpression<uint>(name);
			case TypeCode.UInt64:
				return new PrimitiveParameterExpression<ulong>(name);
			}
		}
		return new TypedParameterExpression(type, name);
	}

	internal virtual bool GetIsByRef()
	{
		return false;
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitParameter(this);
	}
}
