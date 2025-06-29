using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class TSetReadWriteMarshaler<T>
{
	private FFieldAddress property;

	private FScriptSetHelper helper;

	private TSetReadWrite<T>[] wrappers;

	private MarshalingDelegates<T>.FromNative elementFromNative;

	private MarshalingDelegates<T>.ToNative elementToNative;

	public TSetReadWriteMarshaler(int length, FFieldAddress setProperty, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = setProperty;
		helper = new FScriptSetHelper(property.Address);
		wrappers = new TSetReadWrite<T>[length];
		elementFromNative = fromNative;
		elementToNative = toNative;
	}

	public TSetReadWrite<T> FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public TSetReadWrite<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (wrappers[arrayIndex] == null)
		{
			wrappers[arrayIndex] = new TSetReadWrite<T>(null, property, nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptSet)), elementFromNative, elementToNative);
		}
		return wrappers[arrayIndex];
	}

	public void ToNative(IntPtr nativeBuffer, IEnumerable<T> value)
	{
		helper.Update(property);
		ToNativeInternal(nativeBuffer, 0, value, ref helper, elementToNative);
	}

	public void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IEnumerable<T> value)
	{
		helper.Update(property);
		ToNativeInternal(nativeBuffer, arrayIndex, value, ref helper, elementToNative);
	}

	internal unsafe static void ToNativeInternal(IntPtr nativeBuffer, int arrayIndex, IEnumerable<T> value, ref FScriptSetHelper helper, MarshalingDelegates<T>.ToNative elementToNative)
	{
		IntPtr intPtr = (helper.Set = nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptSet)));
		helper.EmptyValues();
		if (value == null)
		{
			return;
		}
		FScriptSet* ptr = (FScriptSet*)(void*)intPtr;
		if (value is IList<T> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				helper.AddElement(list[i], elementToNative);
			}
			return;
		}
		if (value is HashSet<T> hashSet)
		{
			{
				foreach (T item in hashSet)
				{
					helper.AddElement(item, elementToNative);
				}
				return;
			}
		}
		if (value is TSetBase<T> tSetBase)
		{
			{
				foreach (T item2 in tSetBase)
				{
					helper.AddElement(item2, elementToNative);
				}
				return;
			}
		}
		foreach (T item3 in value)
		{
			helper.AddElement(item3, elementToNative);
		}
	}
}
