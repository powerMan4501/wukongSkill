using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace System.Runtime.CompilerServices;

[global::__DynamicallyInvokable]
public abstract class CallSiteBinder
{
	private sealed class LambdaSignature<T> where T : class
	{
		internal static readonly LambdaSignature<T> Instance = new LambdaSignature<T>();

		internal readonly ReadOnlyCollection<ParameterExpression> Parameters;

		internal readonly LabelTarget ReturnLabel;

		private LambdaSignature()
		{
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsSubclassOf(typeof(MulticastDelegate)))
			{
				throw Error.TypeParameterIsNotDelegate(typeFromHandle);
			}
			MethodInfo method = typeFromHandle.GetMethod("Invoke");
			ParameterInfo[] parametersCached = method.GetParametersCached();
			if (parametersCached[0].ParameterType != typeof(CallSite))
			{
				throw Error.FirstArgumentMustBeCallSite();
			}
			ParameterExpression[] array = new ParameterExpression[parametersCached.Length - 1];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Expression.Parameter(parametersCached[i + 1].ParameterType, "$arg" + i);
			}
			Parameters = new TrueReadOnlyCollection<ParameterExpression>(array);
			ReturnLabel = Expression.Label(method.GetReturnType());
		}
	}

	private static readonly LabelTarget _updateLabel = Expression.Label("CallSiteBinder.UpdateLabel");

	internal Dictionary<Type, object> Cache;

	[global::__DynamicallyInvokable]
	public static LabelTarget UpdateLabel
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _updateLabel;
		}
	}

	[global::__DynamicallyInvokable]
	protected CallSiteBinder()
	{
	}

	[global::__DynamicallyInvokable]
	public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

	[global::__DynamicallyInvokable]
	public virtual T BindDelegate<T>(CallSite<T> site, object[] args) where T : class
	{
		return null;
	}

	internal T BindCore<T>(CallSite<T> site, object[] args) where T : class
	{
		T val = BindDelegate(site, args);
		if (val != null)
		{
			return val;
		}
		LambdaSignature<T> instance = LambdaSignature<T>.Instance;
		Expression expression = Bind(args, instance.Parameters, instance.ReturnLabel);
		if (expression == null)
		{
			throw Error.NoOrInvalidRuleProduced();
		}
		if (!AppDomain.CurrentDomain.IsHomogenous)
		{
			throw Error.HomogenousAppDomainRequired();
		}
		Expression<T> expression2 = Stitch(expression, instance);
		T val2 = expression2.Compile();
		CacheTarget(val2);
		return val2;
	}

	[global::__DynamicallyInvokable]
	protected void CacheTarget<T>(T target) where T : class
	{
		GetRuleCache<T>().AddRule(target);
	}

	private static Expression<T> Stitch<T>(Expression binding, LambdaSignature<T> signature) where T : class
	{
		Type typeFromHandle = typeof(CallSite<T>);
		ReadOnlyCollectionBuilder<Expression> readOnlyCollectionBuilder = new ReadOnlyCollectionBuilder<Expression>(3);
		readOnlyCollectionBuilder.Add(binding);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(CallSite), "$site");
		ParameterExpression[] array = signature.Parameters.AddFirst(parameterExpression);
		Expression item = Expression.Label(UpdateLabel);
		readOnlyCollectionBuilder.Add(item);
		LabelTarget returnLabel = signature.ReturnLabel;
		MethodCallExpression test = Expression.Call(typeof(CallSiteOps).GetMethod("SetNotMatched"), array.First());
		DefaultExpression ifTrue = Expression.Default(signature.ReturnLabel.Type);
		MemberExpression expression = Expression.Property(Expression.Convert(parameterExpression, typeFromHandle), typeof(CallSite<T>).GetProperty("Update"));
		Expression[] list = array;
		readOnlyCollectionBuilder.Add(Expression.Label(returnLabel, Expression.Condition(test, ifTrue, Expression.Invoke(expression, new TrueReadOnlyCollection<Expression>(list)))));
		return new Expression<T>(Expression.Block(readOnlyCollectionBuilder), "CallSite.Target", tailCall: true, new TrueReadOnlyCollection<ParameterExpression>(array));
	}

	internal RuleCache<T> GetRuleCache<T>() where T : class
	{
		if (Cache == null)
		{
			Interlocked.CompareExchange(ref Cache, new Dictionary<Type, object>(), null);
		}
		Dictionary<Type, object> cache = Cache;
		object value;
		lock (cache)
		{
			if (!cache.TryGetValue(typeof(T), out value))
			{
				value = (cache[typeof(T)] = new RuleCache<T>());
			}
		}
		return value as RuleCache<T>;
	}
}
