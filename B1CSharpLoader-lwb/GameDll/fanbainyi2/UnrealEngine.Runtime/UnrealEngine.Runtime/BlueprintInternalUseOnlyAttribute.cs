using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Method)]
public class BlueprintInternalUseOnlyAttribute : UMetaAttribute
{
	public BlueprintInternalUseOnlyAttribute()
		: base(MDStruct.BlueprintInternalUseOnly, value: true)
	{
	}
}
