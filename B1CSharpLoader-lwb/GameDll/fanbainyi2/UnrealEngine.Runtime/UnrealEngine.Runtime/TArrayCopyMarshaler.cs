using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public struct TArrayCopyMarshaler<T>
{
	private FFieldAddress property;

	private FScriptArrayHelper helper;

	private MarshalingDelegates<T>.FromNative innerFromNative;

	private MarshalingDelegates<T>.ToNative innerToNative;

	public TArrayCopyMarshaler(int length, FFieldAddress arrayProperty, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = arrayProperty;
		helper = new FScriptArrayHelper(property.Address);
		innerFromNative = fromNative;
		innerToNative = toNative;
	}

	public List<T> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public unsafe List<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * FScriptArray.StructSize;
		helper.Update(property);
		helper.Array = intPtr;
		FScriptArray* ptr = (FScriptArray*)(void*)intPtr;
		List<T> list = new List<T>(ptr->ArrayNum);
		for (int i = 0; i < ptr->ArrayNum; i++)
		{
			list.Add(innerFromNative(ptr->Data, i, helper.InnerPropertyAddress));
		}
		return list;
	}

	public void ToNative(IntPtr nativeBuffer, IList<T> value)
	{
		helper.Update(property);
		TArrayReadWriteMarshaler<T>.ToNativeInternal(nativeBuffer, 0, value, ref helper, innerToNative);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IList<T> value)
	{
		helper.Update(property);
		TArrayReadWriteMarshaler<T>.ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, innerToNative);
	}
}
