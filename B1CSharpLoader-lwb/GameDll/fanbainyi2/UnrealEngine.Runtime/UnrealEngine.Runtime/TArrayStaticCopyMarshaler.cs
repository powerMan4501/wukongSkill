using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public static class TArrayStaticCopyMarshaler<T>
{
	private static MarshalingDelegates<T>.FromNative innerFromNative = MarshalingDelegateResolver<T>.FromNative;

	private static MarshalingDelegates<T>.ToNative innerToNative = MarshalingDelegateResolver<T>.ToNative;

	public unsafe static IList<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * FScriptArray.StructSize;
		FScriptArrayHelper fScriptArrayHelper = new FScriptArrayHelper(prop, intPtr);
		FScriptArray* ptr = (FScriptArray*)(void*)intPtr;
		List<T> list = new List<T>(ptr->ArrayNum);
		for (int i = 0; i < ptr->ArrayNum; i++)
		{
			list.Add(innerFromNative(ptr->Data, i, fScriptArrayHelper.InnerPropertyAddress));
		}
		return list;
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IList<T> value)
	{
		FScriptArrayHelper helper = new FScriptArrayHelper(prop);
		TArrayReadWriteMarshaler<T>.ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, innerToNative);
	}
}
