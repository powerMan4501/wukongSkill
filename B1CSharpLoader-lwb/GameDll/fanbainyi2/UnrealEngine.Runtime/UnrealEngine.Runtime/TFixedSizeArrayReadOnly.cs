using System;

namespace UnrealEngine.Runtime;

public sealed class TFixedSizeArrayReadOnly<T> : TFixedSizeArrayBase<T>
{
	public T this[int index] => Get(index);

	public TFixedSizeArrayReadOnly(IntPtr address, FFieldAddress property, UObject owner)
		: base(address, property, owner)
	{
	}
}
