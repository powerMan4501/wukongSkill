using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public struct TMapCopyMarshaler<TKey, TValue>
{
	private FFieldAddress property;

	private FScriptMapHelper helper;

	private MarshalingDelegates<TKey>.FromNative keyFromNative;

	private MarshalingDelegates<TKey>.ToNative keyToNative;

	private MarshalingDelegates<TValue>.FromNative valueFromNative;

	private MarshalingDelegates<TValue>.ToNative valueToNative;

	public TMapCopyMarshaler(int length, FFieldAddress mapProperty, MarshalingDelegates<TKey>.FromNative keyFromNative, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.FromNative valueFromNative, MarshalingDelegates<TValue>.ToNative valueToNative)
	{
		property = mapProperty;
		helper = new FScriptMapHelper(property.Address);
		this.keyFromNative = keyFromNative;
		this.keyToNative = keyToNative;
		this.valueFromNative = valueFromNative;
		this.valueToNative = valueToNative;
	}

	public Dictionary<TKey, TValue> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public unsafe Dictionary<TKey, TValue> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * FScriptMap.StructSize;
		helper.Map = intPtr;
		FScriptMap* ptr = (FScriptMap*)(void*)intPtr;
		Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
		int maxIndex = ptr->GetMaxIndex();
		for (int i = 0; i < maxIndex; i++)
		{
			if (ptr->IsValidIndex(i))
			{
				helper.GetPairPtr(i, out var keyPtr, out var valuePtr);
				dictionary.Add(keyFromNative(keyPtr, 0, helper.KeyPropertyAddress), valueFromNative(valuePtr, 0, helper.ValuePropertyAddress));
			}
		}
		return dictionary;
	}

	public void ToNative(IntPtr nativeBuffer, IDictionary<TKey, TValue> value)
	{
		helper.Update(property);
		TMapReadWriteMarshaler<TKey, TValue>.ToNativeInternal(nativeBuffer, 0, value, ref helper, keyToNative, valueToNative);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IDictionary<TKey, TValue> value)
	{
		helper.Update(property);
		TMapReadWriteMarshaler<TKey, TValue>.ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, keyToNative, valueToNative);
	}
}
