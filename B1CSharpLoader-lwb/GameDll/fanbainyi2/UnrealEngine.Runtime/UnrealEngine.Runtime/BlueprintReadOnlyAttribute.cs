using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class BlueprintReadOnlyAttribute : BlueprintVisibleAttribute
{
	public BlueprintReadOnlyAttribute()
	{
		base.ReadOnly = true;
	}
}
