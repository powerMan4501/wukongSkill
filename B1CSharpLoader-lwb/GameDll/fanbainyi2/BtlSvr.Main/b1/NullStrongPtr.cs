using System;
using UnrealEngine.Runtime;

namespace b1;

public class NullStrongPtr
{
	private WeakReference<TStrongObjectPtrBase> Ptr;

	private UObject Obj;

	public NullStrongPtr(TStrongObjectPtrBase InPtr)
	{
		Ptr = new WeakReference<TStrongObjectPtrBase>(InPtr);
		Obj = InPtr.GetUObject();
	}
}
