using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public struct TSetCopyMarshaler<T>
{
	private FFieldAddress property;

	private FScriptSetHelper helper;

	private MarshalingDelegates<T>.FromNative elementFromNative;

	private MarshalingDelegates<T>.ToNative elementToNative;

	public TSetCopyMarshaler(int length, FFieldAddress setProperty, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = setProperty;
		helper = new FScriptSetHelper(property.Address);
		elementFromNative = fromNative;
		elementToNative = toNative;
	}

	public HashSet<T> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public unsafe HashSet<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptSet));
		helper.Update(property);
		helper.Set = intPtr;
		FScriptSet* ptr = (FScriptSet*)(void*)intPtr;
		HashSet<T> hashSet = new HashSet<T>();
		int maxIndex = ptr->GetMaxIndex();
		for (int i = 0; i < maxIndex; i++)
		{
			if (ptr->IsValidIndex(i))
			{
				hashSet.Add(elementFromNative(helper.GetElementPtr(i), 0, helper.ElementPropertyAddress));
			}
		}
		return hashSet;
	}

	public void ToNative(IntPtr nativeBuffer, IEnumerable<T> value)
	{
		helper.Update(property);
		TSetReadWriteMarshaler<T>.ToNativeInternal(nativeBuffer, 0, value, ref helper, elementToNative);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IEnumerable<T> value)
	{
		helper.Update(property);
		TSetReadWriteMarshaler<T>.ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, elementToNative);
	}
}
