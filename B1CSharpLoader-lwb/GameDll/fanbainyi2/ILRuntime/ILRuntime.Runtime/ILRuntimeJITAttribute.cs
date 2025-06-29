using System;

namespace ILRuntime.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
public class ILRuntimeJITAttribute : Attribute
{
	private int flags;

	public int Flags => flags;

	public ILRuntimeJITAttribute()
	{
		flags = 1;
	}

	public ILRuntimeJITAttribute(int flags)
	{
		this.flags = flags;
	}
}
