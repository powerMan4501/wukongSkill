using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public static class TMapStaticCopyMarshaler<TKey, TValue>
{
	private static MarshalingDelegates<TKey>.FromNative keyFromNative = MarshalingDelegateResolver<TKey>.FromNative;

	private static MarshalingDelegates<TKey>.ToNative keyToNative = MarshalingDelegateResolver<TKey>.ToNative;

	private static MarshalingDelegates<TValue>.FromNative valueFromNative = MarshalingDelegateResolver<TValue>.FromNative;

	private static MarshalingDelegates<TValue>.ToNative valueToNative = MarshalingDelegateResolver<TValue>.ToNative;

	public unsafe static IDictionary<TKey, TValue> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * FScriptMap.StructSize;
		FScriptMapHelper fScriptMapHelper = new FScriptMapHelper(prop, intPtr);
		FScriptMap* ptr = (FScriptMap*)(void*)intPtr;
		Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
		int maxIndex = ptr->GetMaxIndex();
		for (int i = 0; i < maxIndex; i++)
		{
			if (ptr->IsValidIndex(i))
			{
				fScriptMapHelper.GetPairPtr(i, out var keyPtr, out var valuePtr);
				dictionary.Add(keyFromNative(keyPtr, 0, fScriptMapHelper.KeyPropertyAddress), valueFromNative(valuePtr, 0, fScriptMapHelper.ValuePropertyAddress));
			}
		}
		return dictionary;
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IDictionary<TKey, TValue> value)
	{
		FScriptMapHelper helper = new FScriptMapHelper(prop);
		TMapReadWriteMarshaler<TKey, TValue>.ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, keyToNative, valueToNative);
	}
}
