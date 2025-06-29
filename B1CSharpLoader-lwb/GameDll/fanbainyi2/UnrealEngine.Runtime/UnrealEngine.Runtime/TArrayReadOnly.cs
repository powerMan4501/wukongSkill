using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TArrayReadOnly<T> : TArrayBase<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{
	public T this[int index] => Get(index);

	public TArrayReadOnly(UObject owner, FFieldAddress arrayProperty, IntPtr address, MarshalingDelegates<T>.FromNative fromNative)
		: base(owner, arrayProperty, address, fromNative, (MarshalingDelegates<T>.ToNative)null)
	{
	}
}
