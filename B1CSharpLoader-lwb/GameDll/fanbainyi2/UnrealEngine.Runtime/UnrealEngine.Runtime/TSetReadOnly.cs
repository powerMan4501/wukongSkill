using System;

namespace UnrealEngine.Runtime;

public class TSetReadOnly<T> : TSetReadWrite<T>
{
	public new bool IsReadOnly => true;

	public TSetReadOnly(UObject owner, FFieldAddress setProperty, IntPtr address, MarshalingDelegates<T>.FromNative fromNative)
		: base(owner, setProperty, address, fromNative, (MarshalingDelegates<T>.ToNative)null)
	{
	}
}
