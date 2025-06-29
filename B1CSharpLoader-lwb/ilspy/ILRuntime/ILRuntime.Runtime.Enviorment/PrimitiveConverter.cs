using System;

namespace ILRuntime.Runtime.Enviorment;

public static class PrimitiveConverter<T>
{
	public static Func<T, int> ToInteger;

	public static Func<int, T> FromInteger;

	public static Func<T, long> ToLong;

	public static Func<long, T> FromLong;

	public static Func<T, float> ToFloat;

	public static Func<float, T> FromFloat;

	public static Func<T, double> ToDouble;

	public static Func<double, T> FromDouble;

	public static int CheckAndInvokeToInteger(T val)
	{
		if (ToInteger != null)
		{
			return ToInteger(val);
		}
		throw new InvalidCastException($"Cannot cast {typeof(T).FullName} to System.Int32");
	}

	public static T CheckAndInvokeFromInteger(int val)
	{
		if (FromInteger != null)
		{
			return FromInteger(val);
		}
		throw new InvalidCastException($"Cannot cast System.Int32 to {typeof(T).FullName}");
	}

	public static long CheckAndInvokeToLong(T val)
	{
		if (ToLong != null)
		{
			return ToLong(val);
		}
		throw new InvalidCastException($"Cannot cast {typeof(T).FullName} to System.Int64");
	}

	public static T CheckAndInvokeFromLong(long val)
	{
		if (FromLong != null)
		{
			return FromLong(val);
		}
		throw new InvalidCastException($"Cannot cast System.Int64 to {typeof(T).FullName}");
	}

	public static float CheckAndInvokeToFloat(T val)
	{
		if (ToFloat != null)
		{
			return ToFloat(val);
		}
		throw new InvalidCastException($"Cannot cast {typeof(T).FullName} to System.Single");
	}

	public static T CheckAndInvokeFromFloat(float val)
	{
		if (FromFloat != null)
		{
			return FromFloat(val);
		}
		throw new InvalidCastException($"Cannot cast System.Single to {typeof(T).FullName}");
	}

	public static double CheckAndInvokeToDouble(T val)
	{
		if (ToDouble != null)
		{
			return ToDouble(val);
		}
		throw new InvalidCastException($"Cannot cast {typeof(T).FullName} to System.Double");
	}

	public static T CheckAndInvokeFromDouble(double val)
	{
		if (FromDouble != null)
		{
			return FromDouble(val);
		}
		throw new InvalidCastException($"Cannot cast System.Double to {typeof(T).FullName}");
	}
}
