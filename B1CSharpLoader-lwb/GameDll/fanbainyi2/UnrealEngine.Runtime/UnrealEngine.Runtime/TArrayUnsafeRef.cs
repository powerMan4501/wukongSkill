using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[Serializable]
[DebuggerTypeProxy(typeof(TArrayDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class TArrayUnsafeRef<T> : TArrayUnsafe<T>
{
	public TArrayUnsafeRef(IntPtr native)
		: base(native)
	{
		isRef = true;
	}
}
