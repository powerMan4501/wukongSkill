using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System;

[Serializable]
[NonVersionable]
[__DynamicallyInvokable]
public struct Nullable<T> where T : struct
{
	private bool hasValue;

	internal T value;

	[__DynamicallyInvokable]
	public bool HasValue
	{
		[NonVersionable]
		[__DynamicallyInvokable]
		get
		{
			return hasValue;
		}
	}

	[__DynamicallyInvokable]
	public T Value
	{
		[__DynamicallyInvokable]
		get
		{
			if (!hasValue)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_NoValue);
			}
			return value;
		}
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public Nullable(T value)
	{
		this.value = value;
		hasValue = true;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public T GetValueOrDefault()
	{
		return value;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public T GetValueOrDefault(T defaultValue)
	{
		if (!hasValue)
		{
			return defaultValue;
		}
		return value;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object other)
	{
		if (!hasValue)
		{
			return other == null;
		}
		if (other == null)
		{
			return false;
		}
		return value.Equals(other);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		if (!hasValue)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		if (!hasValue)
		{
			return "";
		}
		return value.ToString();
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static implicit operator T?(T value)
	{
		return value;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static explicit operator T(T? value)
	{
		return value.Value;
	}
}
[ComVisible(true)]
[__DynamicallyInvokable]
public static class Nullable
{
	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static int Compare<T>(T? n1, T? n2) where T : struct
	{
		if (n1.HasValue)
		{
			if (n2.HasValue)
			{
				return Comparer<T>.Default.Compare(n1.value, n2.value);
			}
			return 1;
		}
		if (n2.HasValue)
		{
			return -1;
		}
		return 0;
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static bool Equals<T>(T? n1, T? n2) where T : struct
	{
		if (n1.HasValue)
		{
			if (n2.HasValue)
			{
				return EqualityComparer<T>.Default.Equals(n1.value, n2.value);
			}
			return false;
		}
		if (n2.HasValue)
		{
			return false;
		}
		return true;
	}

	[__DynamicallyInvokable]
	public static Type GetUnderlyingType(Type nullableType)
	{
		if ((object)nullableType == null)
		{
			throw new ArgumentNullException("nullableType");
		}
		Type result = null;
		if (nullableType.IsGenericType && !nullableType.IsGenericTypeDefinition)
		{
			Type genericTypeDefinition = nullableType.GetGenericTypeDefinition();
			if ((object)genericTypeDefinition == typeof(Nullable<>))
			{
				result = nullableType.GetGenericArguments()[0];
			}
		}
		return result;
	}
}
