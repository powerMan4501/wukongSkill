using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Linq.Expressions.Compiler;
using System.Reflection;

namespace System.Runtime.CompilerServices;

[global::__DynamicallyInvokable]
public class CallSite
{
	private static volatile CacheDict<Type, Func<CallSiteBinder, CallSite>> _SiteCtors;

	internal readonly CallSiteBinder _binder;

	internal bool _match;

	[global::__DynamicallyInvokable]
	public CallSiteBinder Binder
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _binder;
		}
	}

	internal CallSite(CallSiteBinder binder)
	{
		_binder = binder;
	}

	[global::__DynamicallyInvokable]
	public static CallSite Create(Type delegateType, CallSiteBinder binder)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		ContractUtils.RequiresNotNull(binder, "binder");
		if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		CacheDict<Type, Func<CallSiteBinder, CallSite>> cacheDict = _SiteCtors;
		if (cacheDict == null)
		{
			cacheDict = (_SiteCtors = new CacheDict<Type, Func<CallSiteBinder, CallSite>>(100));
		}
		MethodInfo methodInfo = null;
		if (!cacheDict.TryGetValue(delegateType, out var value))
		{
			methodInfo = typeof(CallSite<>).MakeGenericType(delegateType).GetMethod("Create");
			if (delegateType.CanCache())
			{
				value = (Func<CallSiteBinder, CallSite>)Delegate.CreateDelegate(typeof(Func<CallSiteBinder, CallSite>), methodInfo);
				cacheDict.Add(delegateType, value);
			}
		}
		if (value != null)
		{
			return value(binder);
		}
		return (CallSite)methodInfo.Invoke(null, new object[1] { binder });
	}
}
[global::__DynamicallyInvokable]
public class CallSite<T> : CallSite where T : class
{
	[global::__DynamicallyInvokable]
	public T Target;

	internal T[] Rules;

	private static T _CachedUpdate;

	private static volatile T _CachedNoMatch;

	private const int MaxRules = 10;

	[global::__DynamicallyInvokable]
	public T Update
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_match)
			{
				return _CachedNoMatch;
			}
			return _CachedUpdate;
		}
	}

	private CallSite(CallSiteBinder binder)
		: base(binder)
	{
		Target = GetUpdateDelegate();
	}

	private CallSite()
		: base(null)
	{
	}

	internal CallSite<T> CreateMatchMaker()
	{
		return new CallSite<T>();
	}

	[global::__DynamicallyInvokable]
	public static CallSite<T> Create(CallSiteBinder binder)
	{
		if (!typeof(T).IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		return new CallSite<T>(binder);
	}

	private T GetUpdateDelegate()
	{
		return GetUpdateDelegate(ref _CachedUpdate);
	}

	private T GetUpdateDelegate(ref T addr)
	{
		if (addr == null)
		{
			addr = MakeUpdateDelegate();
		}
		return addr;
	}

	private void ClearRuleCache()
	{
		base.Binder.GetRuleCache<T>();
		Dictionary<Type, object> cache = base.Binder.Cache;
		if (cache != null)
		{
			lock (cache)
			{
				cache.Clear();
			}
		}
	}

	internal void AddRule(T newRule)
	{
		T[] rules = Rules;
		if (rules == null)
		{
			Rules = new T[1] { newRule };
			return;
		}
		T[] array;
		if (rules.Length < 9)
		{
			array = new T[rules.Length + 1];
			Array.Copy(rules, 0, array, 1, rules.Length);
		}
		else
		{
			array = new T[10];
			Array.Copy(rules, 0, array, 1, 9);
		}
		array[0] = newRule;
		Rules = array;
	}

	internal void MoveRule(int i)
	{
		T[] rules = Rules;
		T val = rules[i];
		rules[i] = rules[i - 1];
		rules[i - 1] = rules[i - 2];
		rules[i - 2] = val;
	}

	internal T MakeUpdateDelegate()
	{
		Type typeFromHandle = typeof(T);
		MethodInfo method = typeFromHandle.GetMethod("Invoke");
		if (typeFromHandle.IsGenericType && IsSimpleSignature(method, out var sig))
		{
			MethodInfo methodInfo = null;
			MethodInfo methodInfo2 = null;
			if (method.ReturnType == typeof(void))
			{
				if (typeFromHandle == DelegateHelpers.GetActionType(sig.AddFirst(typeof(CallSite))))
				{
					methodInfo = typeof(UpdateDelegates).GetMethod("UpdateAndExecuteVoid" + sig.Length, BindingFlags.Static | BindingFlags.NonPublic);
					methodInfo2 = typeof(UpdateDelegates).GetMethod("NoMatchVoid" + sig.Length, BindingFlags.Static | BindingFlags.NonPublic);
				}
			}
			else if (typeFromHandle == DelegateHelpers.GetFuncType(sig.AddFirst(typeof(CallSite))))
			{
				methodInfo = typeof(UpdateDelegates).GetMethod("UpdateAndExecute" + (sig.Length - 1), BindingFlags.Static | BindingFlags.NonPublic);
				methodInfo2 = typeof(UpdateDelegates).GetMethod("NoMatch" + (sig.Length - 1), BindingFlags.Static | BindingFlags.NonPublic);
			}
			if (methodInfo != null)
			{
				_CachedNoMatch = (T)(object)CreateDelegateHelper(typeFromHandle, methodInfo2.MakeGenericMethod(sig));
				return (T)(object)CreateDelegateHelper(typeFromHandle, methodInfo.MakeGenericMethod(sig));
			}
		}
		_CachedNoMatch = CreateCustomNoMatchDelegate(method);
		return CreateCustomUpdateDelegate(method);
	}

	private static Delegate CreateDelegateHelper(Type delegateType, MethodInfo method)
	{
		return Delegate.CreateDelegate(delegateType, method);
	}

	private static bool IsSimpleSignature(MethodInfo invoke, out Type[] sig)
	{
		ParameterInfo[] parametersCached = invoke.GetParametersCached();
		ContractUtils.Requires(parametersCached.Length != 0 && parametersCached[0].ParameterType == typeof(CallSite), "T");
		Type[] array = new Type[(invoke.ReturnType != typeof(void)) ? parametersCached.Length : (parametersCached.Length - 1)];
		bool result = true;
		for (int i = 1; i < parametersCached.Length; i++)
		{
			ParameterInfo parameterInfo = parametersCached[i];
			if (parameterInfo.IsByRefParameter())
			{
				result = false;
			}
			array[i - 1] = parameterInfo.ParameterType;
		}
		if (invoke.ReturnType != typeof(void))
		{
			array[array.Length - 1] = invoke.ReturnType;
		}
		sig = array;
		return result;
	}

	private T CreateCustomNoMatchDelegate(MethodInfo invoke)
	{
		ParameterExpression[] array = invoke.GetParametersCached().Map((ParameterInfo p) => Expression.Parameter(p.ParameterType, p.Name));
		return Expression.Lambda<T>(Expression.Block(Expression.Call(typeof(CallSiteOps).GetMethod("SetNotMatched"), array.First()), Expression.Default(invoke.GetReturnType())), array).Compile();
	}

	private T CreateCustomUpdateDelegate(MethodInfo invoke)
	{
		List<Expression> list = new List<Expression>();
		List<ParameterExpression> list2 = new List<ParameterExpression>();
		ParameterExpression[] array = invoke.GetParametersCached().Map((ParameterInfo p) => Expression.Parameter(p.ParameterType, p.Name));
		LabelTarget labelTarget = Expression.Label(invoke.GetReturnType());
		Type[] typeArguments = new Type[1] { typeof(T) };
		ParameterExpression parameterExpression = array[0];
		ParameterExpression[] collection = array.RemoveFirst();
		ParameterExpression parameterExpression2 = Expression.Variable(typeof(CallSite<T>), "this");
		list2.Add(parameterExpression2);
		list.Add(Expression.Assign(parameterExpression2, Expression.Convert(parameterExpression, parameterExpression2.Type)));
		ParameterExpression parameterExpression3 = Expression.Variable(typeof(T[]), "applicable");
		list2.Add(parameterExpression3);
		ParameterExpression parameterExpression4 = Expression.Variable(typeof(T), "rule");
		list2.Add(parameterExpression4);
		ParameterExpression parameterExpression5 = Expression.Variable(typeof(T), "originalRule");
		list2.Add(parameterExpression5);
		list.Add(Expression.Assign(parameterExpression5, Expression.Field(parameterExpression2, "Target")));
		ParameterExpression parameterExpression6 = null;
		if (labelTarget.Type != typeof(void))
		{
			list2.Add(parameterExpression6 = Expression.Variable(labelTarget.Type, "result"));
		}
		ParameterExpression parameterExpression7 = Expression.Variable(typeof(int), "count");
		list2.Add(parameterExpression7);
		ParameterExpression parameterExpression8 = Expression.Variable(typeof(int), "index");
		list2.Add(parameterExpression8);
		list.Add(Expression.Assign(parameterExpression, Expression.Call(typeof(CallSiteOps), "CreateMatchmaker", typeArguments, parameterExpression2)));
		Expression test = Expression.Call(typeof(CallSiteOps).GetMethod("GetMatch"), parameterExpression);
		Expression expression = Expression.Call(typeof(CallSiteOps).GetMethod("ClearMatch"), parameterExpression);
		MethodCallExpression arg = Expression.Call(typeof(CallSiteOps), "UpdateRules", typeArguments, parameterExpression2, parameterExpression8);
		Expression arg2;
		if (labelTarget.Type == typeof(void))
		{
			Expression[] list3 = array;
			arg2 = Expression.Block(Expression.Invoke(parameterExpression4, new TrueReadOnlyCollection<Expression>(list3)), Expression.IfThen(test, Expression.Block(arg, Expression.Return(labelTarget))));
		}
		else
		{
			ParameterExpression left = parameterExpression6;
			Expression[] list3 = array;
			arg2 = Expression.Block(Expression.Assign(left, Expression.Invoke(parameterExpression4, new TrueReadOnlyCollection<Expression>(list3))), Expression.IfThen(test, Expression.Block(arg, Expression.Return(labelTarget, parameterExpression6))));
		}
		Expression arg3 = Expression.Assign(parameterExpression4, Expression.ArrayAccess(parameterExpression3, parameterExpression8));
		LabelTarget labelTarget2 = Expression.Label();
		ConditionalExpression arg4 = Expression.IfThen(Expression.Equal(parameterExpression8, parameterExpression7), Expression.Break(labelTarget2));
		UnaryExpression unaryExpression = Expression.PreIncrementAssign(parameterExpression8);
		list.Add(Expression.IfThen(Expression.NotEqual(Expression.Assign(parameterExpression3, Expression.Call(typeof(CallSiteOps), "GetRules", typeArguments, parameterExpression2)), Expression.Constant(null, parameterExpression3.Type)), Expression.Block(Expression.Assign(parameterExpression7, Expression.ArrayLength(parameterExpression3)), Expression.Assign(parameterExpression8, Expression.Constant(0)), Expression.Loop(Expression.Block(arg4, arg3, Expression.IfThen(Expression.NotEqual(Expression.Convert(parameterExpression4, typeof(object)), Expression.Convert(parameterExpression5, typeof(object))), Expression.Block(Expression.Assign(Expression.Field(parameterExpression2, "Target"), parameterExpression4), arg2, expression)), unaryExpression), labelTarget2, null))));
		ParameterExpression parameterExpression9 = Expression.Variable(typeof(RuleCache<T>), "cache");
		list2.Add(parameterExpression9);
		list.Add(Expression.Assign(parameterExpression9, Expression.Call(typeof(CallSiteOps), "GetRuleCache", typeArguments, parameterExpression2)));
		list.Add(Expression.Assign(parameterExpression3, Expression.Call(typeof(CallSiteOps), "GetCachedRules", typeArguments, parameterExpression9)));
		if (labelTarget.Type == typeof(void))
		{
			Expression[] list3 = array;
			arg2 = Expression.Block(Expression.Invoke(parameterExpression4, new TrueReadOnlyCollection<Expression>(list3)), Expression.IfThen(test, Expression.Return(labelTarget)));
		}
		else
		{
			ParameterExpression left2 = parameterExpression6;
			Expression[] list3 = array;
			arg2 = Expression.Block(Expression.Assign(left2, Expression.Invoke(parameterExpression4, new TrueReadOnlyCollection<Expression>(list3))), Expression.IfThen(test, Expression.Return(labelTarget, parameterExpression6)));
		}
		TryExpression arg5 = Expression.TryFinally(arg2, Expression.IfThen(test, Expression.Block(Expression.Call(typeof(CallSiteOps), "AddRule", typeArguments, parameterExpression2, parameterExpression4), Expression.Call(typeof(CallSiteOps), "MoveRule", typeArguments, parameterExpression9, parameterExpression4, parameterExpression8))));
		arg3 = Expression.Assign(Expression.Field(parameterExpression2, "Target"), Expression.Assign(parameterExpression4, Expression.ArrayAccess(parameterExpression3, parameterExpression8)));
		list.Add(Expression.Assign(parameterExpression8, Expression.Constant(0)));
		list.Add(Expression.Assign(parameterExpression7, Expression.ArrayLength(parameterExpression3)));
		list.Add(Expression.Loop(Expression.Block(arg4, arg3, arg5, expression, unaryExpression), labelTarget2, null));
		list.Add(Expression.Assign(parameterExpression4, Expression.Constant(null, parameterExpression4.Type)));
		ParameterExpression parameterExpression10 = Expression.Variable(typeof(object[]), "args");
		list2.Add(parameterExpression10);
		list.Add(Expression.Assign(parameterExpression10, Expression.NewArrayInit(typeof(object), collection.Map((ParameterExpression p) => Convert(p, typeof(object))))));
		Expression arg6 = Expression.Assign(Expression.Field(parameterExpression2, "Target"), parameterExpression5);
		arg3 = Expression.Assign(Expression.Field(parameterExpression2, "Target"), Expression.Assign(parameterExpression4, Expression.Call(typeof(CallSiteOps), "Bind", typeArguments, Expression.Property(parameterExpression2, "Binder"), parameterExpression2, parameterExpression10)));
		arg5 = Expression.TryFinally(arg2, Expression.IfThen(test, Expression.Call(typeof(CallSiteOps), "AddRule", typeArguments, parameterExpression2, parameterExpression4)));
		list.Add(Expression.Loop(Expression.Block(arg6, arg3, arg5, expression), null, null));
		list.Add(Expression.Default(labelTarget.Type));
		Expression<T> expression2 = Expression.Lambda<T>(Expression.Label(labelTarget, Expression.Block(new ReadOnlyCollection<ParameterExpression>(list2), new ReadOnlyCollection<Expression>(list))), "CallSite.Target", tailCall: true, new ReadOnlyCollection<ParameterExpression>(array));
		return expression2.Compile();
	}

	private static Expression Convert(Expression arg, Type type)
	{
		if (TypeUtils.AreReferenceAssignable(type, arg.Type))
		{
			return arg;
		}
		return Expression.Convert(arg, type);
	}
}
