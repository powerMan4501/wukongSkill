using System;

namespace UnrealEngine.Runtime;

public abstract class TStrongObjectPtrBase
{
	public IntPtr ThisAddr;

	public abstract UObject GetUObject();

	public abstract string GetCacheName();

	public abstract bool IsValid();

	public abstract void SetNull();

	public abstract void GCClear();
}
