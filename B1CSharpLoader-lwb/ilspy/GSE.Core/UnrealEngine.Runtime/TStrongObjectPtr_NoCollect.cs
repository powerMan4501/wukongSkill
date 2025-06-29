using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class TStrongObjectPtr_NoCollect<T> : TStrongObjectPtr<T> where T : UObject
{
	public TStrongObjectPtr_NoCollect(T Obj)
	{
		ThisAddr = Native_TStrongObjectPtr.New();
		Set(Obj);
		StrongPtrLeakDetection.JoinDetection(this);
	}

	public TStrongObjectPtr_NoCollect()
	{
		ThisAddr = Native_TStrongObjectPtr.New();
		StrongPtrLeakDetection.JoinDetection(this);
	}
}
