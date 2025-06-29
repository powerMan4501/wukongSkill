using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TMapReadWriteMarshaler<TKey, TValue>
{
	private FFieldAddress property;

	private FScriptMapHelper helper;

	private TMapReadWrite<TKey, TValue>[] wrappers;

	private MarshalingDelegates<TKey>.FromNative keyFromNative;

	private MarshalingDelegates<TKey>.ToNative keyToNative;

	private MarshalingDelegates<TValue>.FromNative valueFromNative;

	private MarshalingDelegates<TValue>.ToNative valueToNative;

	public TMapReadWriteMarshaler(int length, FFieldAddress mapProperty, MarshalingDelegates<TKey>.FromNative keyFromNative, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.FromNative valueFromNative, MarshalingDelegates<TValue>.ToNative valueToNative)
	{
		property = mapProperty;
		helper = new FScriptMapHelper(property.Address);
		wrappers = new TMapReadWrite<TKey, TValue>[length];
		this.keyFromNative = keyFromNative;
		this.keyToNative = keyToNative;
		this.valueFromNative = valueFromNative;
		this.valueToNative = valueToNative;
	}

	public TMapReadWrite<TKey, TValue> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public TMapReadWrite<TKey, TValue> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (wrappers[arrayIndex] == null)
		{
			wrappers[arrayIndex] = new TMapReadWrite<TKey, TValue>(null, property, nativeBuffer + arrayIndex * FScriptMap.StructSize, keyFromNative, keyToNative, valueFromNative, valueToNative);
		}
		return wrappers[arrayIndex];
	}

	public void ToNative(IntPtr nativeBuffer, IDictionary<TKey, TValue> value)
	{
		helper.Update(property);
		ToNativeInternal(nativeBuffer, 0, value, ref helper, keyToNative, valueToNative);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IDictionary<TKey, TValue> value)
	{
		helper.Update(property);
		ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, keyToNative, valueToNative);
	}

	internal unsafe static void ToNativeInternal(IntPtr nativeBuffer, int arrayIndex, IDictionary<TKey, TValue> value, ref FScriptMapHelper helper, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.ToNative valueToNative)
	{
		IntPtr intPtr = (helper.Map = nativeBuffer + arrayIndex * FScriptMap.StructSize);
		helper.EmptyValues();
		if (value == null)
		{
			return;
		}
		FScriptMap* ptr = (FScriptMap*)(void*)intPtr;
		if (value is Dictionary<TKey, TValue> dictionary)
		{
			{
				foreach (KeyValuePair<TKey, TValue> item in dictionary)
				{
					helper.AddPair(item.Key, item.Value, keyToNative, valueToNative);
				}
				return;
			}
		}
		if (value is TMapBase<TKey, TValue> tMapBase)
		{
			{
				foreach (KeyValuePair<TKey, TValue> item2 in tMapBase)
				{
					helper.AddPair(item2.Key, item2.Value, keyToNative, valueToNative);
				}
				return;
			}
		}
		foreach (KeyValuePair<TKey, TValue> item3 in value)
		{
			helper.AddPair(item3.Key, item3.Value, keyToNative, valueToNative);
		}
	}
}
