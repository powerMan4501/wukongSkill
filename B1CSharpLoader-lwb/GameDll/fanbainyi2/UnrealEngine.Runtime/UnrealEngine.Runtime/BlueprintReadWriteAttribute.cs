using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class BlueprintReadWriteAttribute : BlueprintVisibleAttribute
{
	public BlueprintReadWriteAttribute()
	{
		base.ReadOnly = false;
	}
}
