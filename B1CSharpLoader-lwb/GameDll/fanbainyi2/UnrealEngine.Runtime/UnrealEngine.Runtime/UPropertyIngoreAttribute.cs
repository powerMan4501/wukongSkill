using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class UPropertyIngoreAttribute : ManagedUnrealAttributeBase
{
	public UPropertyIngoreAttribute()
	{
		base.InvalidTarget = true;
	}
}
