using System;
using UnrealEngine.Runtime;

namespace b1;

public class LeakStrongPtr
{
	private WeakReference<TStrongObjectPtrBase> Ptr;

	private UObject Obj;

	public LeakStrongPtr(TStrongObjectPtrBase InPtr)
	{
		Ptr = new WeakReference<TStrongObjectPtrBase>(InPtr);
		Obj = InPtr.GetUObject();
	}
}
