using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FStringUnsafe : IDisposable
{
	public FScriptArray Array;

	internal bool isPooled;

	public string Value
	{
		get
		{
			return FStringMarshaler.FromArray(Array, destroy: false);
		}
		set
		{
			FStringMarshaler.ToArray(ref Array, value);
		}
	}

	public FStringUnsafe(FScriptArray array)
	{
		Array = array;
	}

	public FStringUnsafe(string value)
	{
		Value = value;
	}

	public FStringUnsafe()
	{
		Value = string.Empty;
	}

	public void Dispose()
	{
		Native_FScriptArray.Destroy(ref Array);
		if (isPooled)
		{
			FStringPool.Return(this);
		}
	}

	public override string ToString()
	{
		return Value;
	}
}
