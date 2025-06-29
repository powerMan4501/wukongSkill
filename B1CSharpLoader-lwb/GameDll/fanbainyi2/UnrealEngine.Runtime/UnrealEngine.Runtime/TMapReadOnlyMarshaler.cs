using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TMapReadOnlyMarshaler<TKey, TValue>
{
	private FFieldAddress property;

	private TMapReadOnly<TKey, TValue>[] wrappers;

	private MarshalingDelegates<TKey>.FromNative keyFromNative;

	private MarshalingDelegates<TValue>.FromNative valueFromNative;

	public TMapReadOnlyMarshaler(int length, FFieldAddress mapProperty, MarshalingDelegates<TKey>.FromNative keyFromNative, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.FromNative valueFromNative, MarshalingDelegates<TValue>.ToNative valueToNative)
	{
		property = mapProperty;
		wrappers = new TMapReadOnly<TKey, TValue>[length];
		this.keyFromNative = keyFromNative;
		this.valueFromNative = valueFromNative;
	}

	public TMapReadOnly<TKey, TValue> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public TMapReadOnly<TKey, TValue> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (wrappers[arrayIndex] == null)
		{
			wrappers[arrayIndex] = new TMapReadOnly<TKey, TValue>(null, property, nativeBuffer + arrayIndex * FScriptMap.StructSize, keyFromNative, valueFromNative);
		}
		return wrappers[arrayIndex];
	}

	public void ToNative(IntPtr nativeBuffer, IReadOnlyDictionary<TKey, TValue> value)
	{
		ToNative(nativeBuffer, 0, IntPtr.Zero, value);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IReadOnlyDictionary<TKey, TValue> value)
	{
		throw new NotImplementedException("Read-only TMap cannot write to native memory.");
	}
}
