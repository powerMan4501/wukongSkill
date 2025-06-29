using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class UClassIgnoreAttribute : ManagedUnrealAttributeBase
{
	public UClassIgnoreAttribute()
	{
		base.InvalidTarget = true;
	}
}
