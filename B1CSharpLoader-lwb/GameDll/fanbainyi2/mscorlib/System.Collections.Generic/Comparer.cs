using System.Runtime.CompilerServices;
using System.Security;

namespace System.Collections.Generic;

[Serializable]
[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
[__DynamicallyInvokable]
public abstract class Comparer<T> : IComparer, IComparer<T>
{
	private static readonly Comparer<T> defaultComparer = CreateComparer();

	[__DynamicallyInvokable]
	public static Comparer<T> Default
	{
		[__DynamicallyInvokable]
		get
		{
			return defaultComparer;
		}
	}

	[__DynamicallyInvokable]
	public static Comparer<T> Create(Comparison<T> comparison)
	{
		if (comparison == null)
		{
			throw new ArgumentNullException("comparison");
		}
		return new ComparisonComparer<T>(comparison);
	}

	[SecuritySafeCritical]
	private static Comparer<T> CreateComparer()
	{
		RuntimeType runtimeType = (RuntimeType)typeof(T);
		if (typeof(IComparable<T>).IsAssignableFrom(runtimeType))
		{
			return (Comparer<T>)RuntimeTypeHandle.CreateInstanceForAnotherGenericParameter((RuntimeType)typeof(GenericComparer<int>), runtimeType);
		}
		if (runtimeType.IsGenericType && runtimeType.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			RuntimeType runtimeType2 = (RuntimeType)runtimeType.GetGenericArguments()[0];
			if (typeof(IComparable<>).MakeGenericType(runtimeType2).IsAssignableFrom(runtimeType2))
			{
				return (Comparer<T>)RuntimeTypeHandle.CreateInstanceForAnotherGenericParameter((RuntimeType)typeof(NullableComparer<int>), runtimeType2);
			}
		}
		return new ObjectComparer<T>();
	}

	[__DynamicallyInvokable]
	public abstract int Compare(T x, T y);

	[__DynamicallyInvokable]
	int IComparer.Compare(object x, object y)
	{
		if (x == null)
		{
			if (y != null)
			{
				return -1;
			}
			return 0;
		}
		if (y == null)
		{
			return 1;
		}
		if (x is T && y is T)
		{
			return Compare((T)x, (T)y);
		}
		ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
		return 0;
	}

	[__DynamicallyInvokable]
	protected Comparer()
	{
	}
}
