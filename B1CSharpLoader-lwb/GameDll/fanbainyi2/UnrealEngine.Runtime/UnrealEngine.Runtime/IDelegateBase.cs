using System;

namespace UnrealEngine.Runtime;

public abstract class IDelegateBase
{
	public abstract void FromNative(IntPtr address);

	public abstract void ToNative(IntPtr address);
}
