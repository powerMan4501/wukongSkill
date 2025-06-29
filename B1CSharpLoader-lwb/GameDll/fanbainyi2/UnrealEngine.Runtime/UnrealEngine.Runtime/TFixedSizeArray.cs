using System;

namespace UnrealEngine.Runtime;

public sealed class TFixedSizeArray<T> : TFixedSizeArrayBase<T>
{
	public T this[int index]
	{
		get
		{
			return Get(index);
		}
		set
		{
			Set(index, ref value);
		}
	}

	public TFixedSizeArray(IntPtr address, FFieldAddress property, UObject owner)
		: base(address, property, owner)
	{
	}

	public void SetValues(T[] values)
	{
		if (values != null)
		{
			int num = Math.Min(values.Length, base.Length);
			for (int i = 0; i < num; i++)
			{
				Set(i, ref values[i]);
			}
		}
	}
}
