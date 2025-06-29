using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.Remoting;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public class DynamicMetaObject
{
	private readonly Expression _expression;

	private readonly BindingRestrictions _restrictions;

	private readonly object _value;

	private readonly bool _hasValue;

	[global::__DynamicallyInvokable]
	public static readonly DynamicMetaObject[] EmptyMetaObjects = new DynamicMetaObject[0];

	[global::__DynamicallyInvokable]
	public Expression Expression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _expression;
		}
	}

	[global::__DynamicallyInvokable]
	public BindingRestrictions Restrictions
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _restrictions;
		}
	}

	[global::__DynamicallyInvokable]
	public object Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _value;
		}
	}

	[global::__DynamicallyInvokable]
	public bool HasValue
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _hasValue;
		}
	}

	[global::__DynamicallyInvokable]
	public Type RuntimeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_hasValue)
			{
				Type type = Expression.Type;
				if (type.IsValueType)
				{
					return type;
				}
				if (_value != null)
				{
					return _value.GetType();
				}
				return null;
			}
			return null;
		}
	}

	[global::__DynamicallyInvokable]
	public Type LimitType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return RuntimeType ?? Expression.Type;
		}
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
	{
		ContractUtils.RequiresNotNull(expression, "expression");
		ContractUtils.RequiresNotNull(restrictions, "restrictions");
		_expression = expression;
		_restrictions = restrictions;
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value)
		: this(expression, restrictions)
	{
		_value = value;
		_hasValue = true;
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindConvert(ConvertBinder binder)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackConvert(this);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackGetMember(this);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackSetMember(this, value);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackDeleteMember(this);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackGetIndex(this, indexes);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackSetIndex(this, indexes, value);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackDeleteIndex(this, indexes);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackInvokeMember(this, args);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackInvoke(this, args);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackCreateInstance(this, args);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackUnaryOperation(this);
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		return binder.FallbackBinaryOperation(this, arg);
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerable<string> GetDynamicMemberNames()
	{
		return new string[0];
	}

	internal static Expression[] GetExpressions(DynamicMetaObject[] objects)
	{
		ContractUtils.RequiresNotNull(objects, "objects");
		Expression[] array = new Expression[objects.Length];
		for (int i = 0; i < objects.Length; i++)
		{
			DynamicMetaObject dynamicMetaObject = objects[i];
			ContractUtils.RequiresNotNull(dynamicMetaObject, "objects");
			Expression expression = dynamicMetaObject.Expression;
			ContractUtils.RequiresNotNull(expression, "objects");
			array[i] = expression;
		}
		return array;
	}

	[global::__DynamicallyInvokable]
	public static DynamicMetaObject Create(object value, Expression expression)
	{
		ContractUtils.RequiresNotNull(expression, "expression");
		if (value is IDynamicMetaObjectProvider dynamicMetaObjectProvider && !RemotingServices.IsObjectOutOfAppDomain(value))
		{
			DynamicMetaObject metaObject = dynamicMetaObjectProvider.GetMetaObject(expression);
			if (metaObject == null || !metaObject.HasValue || metaObject.Value == null || metaObject.Expression != expression)
			{
				throw Error.InvalidMetaObjectCreated(dynamicMetaObjectProvider.GetType());
			}
			return metaObject;
		}
		return new DynamicMetaObject(expression, BindingRestrictions.Empty, value);
	}
}
