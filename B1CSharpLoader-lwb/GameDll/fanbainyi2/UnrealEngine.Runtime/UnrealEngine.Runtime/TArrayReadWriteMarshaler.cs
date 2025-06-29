using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TArrayReadWriteMarshaler<T>
{
	private FFieldAddress property;

	private FScriptArrayHelper helper;

	private TArrayReadWrite<T>[] wrappers;

	private MarshalingDelegates<T>.FromNative innerFromNative;

	private MarshalingDelegates<T>.ToNative innerToNative;

	public TArrayReadWriteMarshaler(int length, FFieldAddress arrayProperty, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = arrayProperty;
		helper = new FScriptArrayHelper(property.Address);
		wrappers = new TArrayReadWrite<T>[length];
		innerFromNative = fromNative;
		innerToNative = toNative;
	}

	public TArrayReadWrite<T> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public TArrayReadWrite<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (wrappers[arrayIndex] == null)
		{
			wrappers[arrayIndex] = new TArrayReadWrite<T>(null, property, nativeBuffer + arrayIndex * FScriptArray.StructSize, innerFromNative, innerToNative);
		}
		return wrappers[arrayIndex];
	}

	public void ToNative(IntPtr nativeBuffer, IList<T> value)
	{
		helper.Update(property);
		ToNativeInternal(nativeBuffer, 0, value, ref helper, innerToNative);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IList<T> value)
	{
		helper.Update(property);
		ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, innerToNative);
	}

	internal unsafe static void ToNativeInternal(IntPtr nativeBuffer, int arrayIndex, IList<T> value, ref FScriptArrayHelper helper, MarshalingDelegates<T>.ToNative innerToNative)
	{
		IntPtr intPtr = (helper.Array = nativeBuffer + arrayIndex * FScriptArray.StructSize);
		helper.EmptyAndAddZeroedValues(value?.Count ?? 0);
		if (value != null)
		{
			FScriptArray* ptr = (FScriptArray*)(void*)intPtr;
			for (int i = 0; i < value.Count; i++)
			{
				innerToNative(ptr->Data, i, helper.InnerPropertyAddress, value[i]);
			}
		}
	}
}
