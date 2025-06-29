using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TArrayReadOnlyMarshaler<T>
{
	private FFieldAddress property;

	private TArrayReadOnly<T>[] wrappers;

	private MarshalingDelegates<T>.FromNative innerFromNative;

	public TArrayReadOnlyMarshaler(int length, FFieldAddress arrayProperty, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = arrayProperty;
		wrappers = new TArrayReadOnly<T>[length];
		innerFromNative = fromNative;
	}

	public TArrayReadOnly<T> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public TArrayReadOnly<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (wrappers[arrayIndex] == null)
		{
			wrappers[arrayIndex] = new TArrayReadOnly<T>(null, property, nativeBuffer + arrayIndex * FScriptArray.StructSize, innerFromNative);
		}
		return wrappers[arrayIndex];
	}

	public void ToNative(IntPtr nativeBuffer, IReadOnlyList<T> value)
	{
		ToNative(nativeBuffer, 0, IntPtr.Zero, value);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IReadOnlyList<T> value)
	{
		throw new NotImplementedException("Read-only TArray cannot write to native memory.");
	}
}
