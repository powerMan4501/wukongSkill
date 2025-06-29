using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class TSetReadOnlyMarshaler<T>
{
	private FFieldAddress property;

	private TSetReadOnly<T>[] wrappers;

	private MarshalingDelegates<T>.FromNative elementFromNative;

	public TSetReadOnlyMarshaler(int length, FFieldAddress setProperty, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = setProperty;
		wrappers = new TSetReadOnly<T>[length];
		elementFromNative = fromNative;
	}

	public TSetReadOnly<T> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public TSetReadOnly<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (wrappers[arrayIndex] == null)
		{
			wrappers[arrayIndex] = new TSetReadOnly<T>(null, property, nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptSet)), elementFromNative);
		}
		return wrappers[arrayIndex];
	}

	public void ToNative(IntPtr nativeBuffer, IReadOnlyCollection<T> value)
	{
		ToNative(nativeBuffer, 0, IntPtr.Zero, value);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IReadOnlyCollection<T> value)
	{
		throw new NotImplementedException("Read-only TSet cannot write to native memory.");
	}
}
