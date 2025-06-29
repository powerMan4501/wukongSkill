using System;
using UnrealEngine.Runtime;

namespace b1;

public class UnTraceStrongPtr
{
	private WeakReference<TStrongObjectPtrBase> Ptr;

	private UObject Obj;

	public UnTraceStrongPtr(TStrongObjectPtrBase InPtr)
	{
		Ptr = new WeakReference<TStrongObjectPtrBase>(InPtr);
		Obj = InPtr.GetUObject();
	}
}
