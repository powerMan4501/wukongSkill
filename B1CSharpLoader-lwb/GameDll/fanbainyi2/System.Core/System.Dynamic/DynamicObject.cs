using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Dynamic;

[Serializable]
[global::__DynamicallyInvokable]
public class DynamicObject : IDynamicMetaObjectProvider
{
	private sealed class MetaDynamic : DynamicMetaObject
	{
		private delegate DynamicMetaObject Fallback(DynamicMetaObject errorSuggestion);

		private sealed class GetBinderAdapter : GetMemberBinder
		{
			internal GetBinderAdapter(InvokeMemberBinder binder)
				: base(binder.Name, binder.IgnoreCase)
			{
			}

			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
			{
				throw new NotSupportedException();
			}
		}

		private static readonly Expression[] NoArgs = new Expression[0];

		private new DynamicObject Value => (DynamicObject)base.Value;

		internal MetaDynamic(Expression expression, DynamicObject value)
			: base(expression, BindingRestrictions.Empty, value)
		{
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return Value.GetDynamicMemberNames();
		}

		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			if (IsOverridden("TryGetMember"))
			{
				return CallMethodWithResult("TryGetMember", binder, NoArgs, (DynamicMetaObject e) => binder.FallbackGetMember(this, e));
			}
			return base.BindGetMember(binder);
		}

		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			if (IsOverridden("TrySetMember"))
			{
				return CallMethodReturnLast("TrySetMember", binder, NoArgs, value.Expression, (DynamicMetaObject e) => binder.FallbackSetMember(this, value, e));
			}
			return base.BindSetMember(binder, value);
		}

		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			if (IsOverridden("TryDeleteMember"))
			{
				return CallMethodNoResult("TryDeleteMember", binder, NoArgs, (DynamicMetaObject e) => binder.FallbackDeleteMember(this, e));
			}
			return base.BindDeleteMember(binder);
		}

		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			if (IsOverridden("TryConvert"))
			{
				return CallMethodWithResult("TryConvert", binder, NoArgs, (DynamicMetaObject e) => binder.FallbackConvert(this, e));
			}
			return base.BindConvert(binder);
		}

		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			Fallback fallback = (DynamicMetaObject e) => binder.FallbackInvokeMember(this, args, e);
			DynamicMetaObject errorSuggestion = BuildCallMethodWithResult("TryInvokeMember", binder, DynamicMetaObject.GetExpressions(args), BuildCallMethodWithResult("TryGetMember", new GetBinderAdapter(binder), NoArgs, fallback(null), (DynamicMetaObject e) => binder.FallbackInvoke(e, args, null)), null);
			return fallback(errorSuggestion);
		}

		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			if (IsOverridden("TryCreateInstance"))
			{
				return CallMethodWithResult("TryCreateInstance", binder, DynamicMetaObject.GetExpressions(args), (DynamicMetaObject e) => binder.FallbackCreateInstance(this, args, e));
			}
			return base.BindCreateInstance(binder, args);
		}

		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			if (IsOverridden("TryInvoke"))
			{
				return CallMethodWithResult("TryInvoke", binder, DynamicMetaObject.GetExpressions(args), (DynamicMetaObject e) => binder.FallbackInvoke(this, args, e));
			}
			return base.BindInvoke(binder, args);
		}

		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			if (IsOverridden("TryBinaryOperation"))
			{
				return CallMethodWithResult("TryBinaryOperation", binder, DynamicMetaObject.GetExpressions(new DynamicMetaObject[1] { arg }), (DynamicMetaObject e) => binder.FallbackBinaryOperation(this, arg, e));
			}
			return base.BindBinaryOperation(binder, arg);
		}

		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			if (IsOverridden("TryUnaryOperation"))
			{
				return CallMethodWithResult("TryUnaryOperation", binder, NoArgs, (DynamicMetaObject e) => binder.FallbackUnaryOperation(this, e));
			}
			return base.BindUnaryOperation(binder);
		}

		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			if (IsOverridden("TryGetIndex"))
			{
				return CallMethodWithResult("TryGetIndex", binder, DynamicMetaObject.GetExpressions(indexes), (DynamicMetaObject e) => binder.FallbackGetIndex(this, indexes, e));
			}
			return base.BindGetIndex(binder, indexes);
		}

		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			if (IsOverridden("TrySetIndex"))
			{
				return CallMethodReturnLast("TrySetIndex", binder, DynamicMetaObject.GetExpressions(indexes), value.Expression, (DynamicMetaObject e) => binder.FallbackSetIndex(this, indexes, value, e));
			}
			return base.BindSetIndex(binder, indexes, value);
		}

		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			if (IsOverridden("TryDeleteIndex"))
			{
				return CallMethodNoResult("TryDeleteIndex", binder, DynamicMetaObject.GetExpressions(indexes), (DynamicMetaObject e) => binder.FallbackDeleteIndex(this, indexes, e));
			}
			return base.BindDeleteIndex(binder, indexes);
		}

		private static Expression[] GetConvertedArgs(params Expression[] args)
		{
			ReadOnlyCollectionBuilder<Expression> readOnlyCollectionBuilder = new ReadOnlyCollectionBuilder<Expression>(args.Length);
			for (int i = 0; i < args.Length; i++)
			{
				readOnlyCollectionBuilder.Add(Expression.Convert(args[i], typeof(object)));
			}
			return readOnlyCollectionBuilder.ToArray();
		}

		private static Expression ReferenceArgAssign(Expression callArgs, Expression[] args)
		{
			ReadOnlyCollectionBuilder<Expression> readOnlyCollectionBuilder = null;
			for (int i = 0; i < args.Length; i++)
			{
				ContractUtils.Requires(args[i] is ParameterExpression);
				if (((ParameterExpression)args[i]).IsByRef)
				{
					if (readOnlyCollectionBuilder == null)
					{
						readOnlyCollectionBuilder = new ReadOnlyCollectionBuilder<Expression>();
					}
					readOnlyCollectionBuilder.Add(Expression.Assign(args[i], Expression.Convert(Expression.ArrayIndex(callArgs, Expression.Constant(i)), args[i].Type)));
				}
			}
			if (readOnlyCollectionBuilder != null)
			{
				return Expression.Block(readOnlyCollectionBuilder);
			}
			return Expression.Empty();
		}

		private static Expression[] BuildCallArgs(DynamicMetaObjectBinder binder, Expression[] parameters, Expression arg0, Expression arg1)
		{
			if (parameters != NoArgs)
			{
				if (arg1 != null)
				{
					return new Expression[3]
					{
						Constant(binder),
						arg0,
						arg1
					};
				}
				return new Expression[2]
				{
					Constant(binder),
					arg0
				};
			}
			if (arg1 != null)
			{
				return new Expression[2]
				{
					Constant(binder),
					arg1
				};
			}
			return new Expression[1] { Constant(binder) };
		}

		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			Type type = binder.GetType();
			while (!type.IsVisible)
			{
				type = type.BaseType;
			}
			return Expression.Constant(binder, type);
		}

		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback)
		{
			return CallMethodWithResult(methodName, binder, args, fallback, null);
		}

		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback, Fallback fallbackInvoke)
		{
			DynamicMetaObject fallbackResult = fallback(null);
			DynamicMetaObject errorSuggestion = BuildCallMethodWithResult(methodName, binder, args, fallbackResult, fallbackInvoke);
			return fallback(errorSuggestion);
		}

		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke)
		{
			if (!IsOverridden(methodName))
			{
				return fallbackResult;
			}
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			ParameterExpression parameterExpression2 = ((methodName != "TryBinaryOperation") ? Expression.Parameter(typeof(object[]), null) : Expression.Parameter(typeof(object), null));
			Expression[] convertedArgs = GetConvertedArgs(args);
			DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
			if (binder.ReturnType != typeof(object))
			{
				UnaryExpression ifTrue = Expression.Convert(dynamicMetaObject.Expression, binder.ReturnType);
				string value = Strings.DynamicObjectResultNotAssignable("{0}", Value.GetType(), binder.GetType(), binder.ReturnType);
				Expression test = ((!binder.ReturnType.IsValueType || !(Nullable.GetUnderlyingType(binder.ReturnType) == null)) ? ((Expression)Expression.OrElse(Expression.Equal(dynamicMetaObject.Expression, Expression.Constant(null)), Expression.TypeIs(dynamicMetaObject.Expression, binder.ReturnType))) : ((Expression)Expression.TypeIs(dynamicMetaObject.Expression, binder.ReturnType)));
				ConditionalExpression expression = Expression.Condition(test, ifTrue, Expression.Throw(Expression.New(typeof(InvalidCastException).GetConstructor(new Type[1] { typeof(string) }), Expression.Call(typeof(string).GetMethod("Format", new Type[2]
				{
					typeof(string),
					typeof(object[])
				}), Expression.Constant(value), Expression.NewArrayInit(typeof(object), Expression.Condition(Expression.Equal(dynamicMetaObject.Expression, Expression.Constant(null)), Expression.Constant("null"), Expression.Call(dynamicMetaObject.Expression, typeof(object).GetMethod("GetType")), typeof(object))))), binder.ReturnType), binder.ReturnType);
				dynamicMetaObject = new DynamicMetaObject(expression, dynamicMetaObject.Restrictions);
			}
			if (fallbackInvoke != null)
			{
				dynamicMetaObject = fallbackInvoke(dynamicMetaObject);
			}
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[2] { parameterExpression, parameterExpression2 }, (methodName != "TryBinaryOperation") ? Expression.Assign(parameterExpression2, Expression.NewArrayInit(typeof(object), convertedArgs)) : Expression.Assign(parameterExpression2, convertedArgs[0]), Expression.Condition(Expression.Call(GetLimitedSelf(), typeof(DynamicObject).GetMethod(methodName), BuildCallArgs(binder, args, parameterExpression2, parameterExpression)), Expression.Block((methodName != "TryBinaryOperation") ? ReferenceArgAssign(parameterExpression2, args) : Expression.Empty(), dynamicMetaObject.Expression), fallbackResult.Expression, binder.ReturnType)), GetRestrictions().Merge(dynamicMetaObject.Restrictions).Merge(fallbackResult.Restrictions));
		}

		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Expression value, Fallback fallback)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), null);
			Expression[] convertedArgs = GetConvertedArgs(args);
			DynamicMetaObject errorSuggestion = new DynamicMetaObject(Expression.Block(new ParameterExpression[2] { parameterExpression, parameterExpression2 }, Expression.Assign(parameterExpression2, Expression.NewArrayInit(typeof(object), convertedArgs)), Expression.Condition(Expression.Call(GetLimitedSelf(), typeof(DynamicObject).GetMethod(methodName), BuildCallArgs(binder, args, parameterExpression2, Expression.Assign(parameterExpression, Expression.Convert(value, typeof(object))))), Expression.Block(ReferenceArgAssign(parameterExpression2, args), parameterExpression), dynamicMetaObject.Expression, typeof(object))), GetRestrictions().Merge(dynamicMetaObject.Restrictions));
			return fallback(errorSuggestion);
		}

		private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), null);
			Expression[] convertedArgs = GetConvertedArgs(args);
			DynamicMetaObject errorSuggestion = new DynamicMetaObject(Expression.Block(new ParameterExpression[1] { parameterExpression }, Expression.Assign(parameterExpression, Expression.NewArrayInit(typeof(object), convertedArgs)), Expression.Condition(Expression.Call(GetLimitedSelf(), typeof(DynamicObject).GetMethod(methodName), BuildCallArgs(binder, args, parameterExpression, null)), Expression.Block(ReferenceArgAssign(parameterExpression, args), Expression.Empty()), dynamicMetaObject.Expression, typeof(void))), GetRestrictions().Merge(dynamicMetaObject.Restrictions));
			return fallback(errorSuggestion);
		}

		private bool IsOverridden(string method)
		{
			MemberInfo[] member = Value.GetType().GetMember(method, MemberTypes.Method, BindingFlags.Instance | BindingFlags.Public);
			MemberInfo[] array = member;
			for (int i = 0; i < array.Length; i++)
			{
				MethodInfo methodInfo = (MethodInfo)array[i];
				if (methodInfo.DeclaringType != typeof(DynamicObject) && methodInfo.GetBaseDefinition().DeclaringType == typeof(DynamicObject))
				{
					return true;
				}
			}
			return false;
		}

		private BindingRestrictions GetRestrictions()
		{
			return BindingRestrictions.GetTypeRestriction(this);
		}

		private Expression GetLimitedSelf()
		{
			if (TypeUtils.AreEquivalent(base.Expression.Type, typeof(DynamicObject)))
			{
				return base.Expression;
			}
			return Expression.Convert(base.Expression, typeof(DynamicObject));
		}
	}

	[global::__DynamicallyInvokable]
	protected DynamicObject()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryGetMember(GetMemberBinder binder, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TrySetMember(SetMemberBinder binder, object value)
	{
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryDeleteMember(DeleteMemberBinder binder)
	{
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryConvert(ConvertBinder binder, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryCreateInstance(CreateInstanceBinder binder, object[] args, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryInvoke(InvokeBinder binder, object[] args, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryBinaryOperation(BinaryOperationBinder binder, object arg, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryUnaryOperation(UnaryOperationBinder binder, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		result = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
	{
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual bool TryDeleteIndex(DeleteIndexBinder binder, object[] indexes)
	{
		return false;
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerable<string> GetDynamicMemberNames()
	{
		return new string[0];
	}

	[global::__DynamicallyInvokable]
	public virtual DynamicMetaObject GetMetaObject(Expression parameter)
	{
		return new MetaDynamic(parameter, this);
	}
}
