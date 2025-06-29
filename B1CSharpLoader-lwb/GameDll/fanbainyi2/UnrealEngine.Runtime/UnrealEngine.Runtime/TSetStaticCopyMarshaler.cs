using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public static class TSetStaticCopyMarshaler<T>
{
	private static MarshalingDelegates<T>.FromNative elementFromNative = MarshalingDelegateResolver<T>.FromNative;

	private static MarshalingDelegates<T>.ToNative elementToNative = MarshalingDelegateResolver<T>.ToNative;

	public unsafe static ISet<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptSet));
		FScriptSetHelper fScriptSetHelper = new FScriptSetHelper(prop, intPtr);
		FScriptSet* ptr = (FScriptSet*)(void*)intPtr;
		HashSet<T> hashSet = new HashSet<T>();
		int maxIndex = ptr->GetMaxIndex();
		for (int i = 0; i < maxIndex; i++)
		{
			if (ptr->IsValidIndex(i))
			{
				hashSet.Add(elementFromNative(fScriptSetHelper.GetElementPtr(i), 0, fScriptSetHelper.ElementPropertyAddress));
			}
		}
		return hashSet;
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ISet<T> value)
	{
		FScriptSetHelper helper = new FScriptSetHelper(prop);
		TSetReadWriteMarshaler<T>.ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, elementToNative);
	}
}
