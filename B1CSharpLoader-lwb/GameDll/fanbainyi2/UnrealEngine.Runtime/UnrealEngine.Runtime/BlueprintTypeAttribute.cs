using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public class BlueprintTypeAttribute : UMetaAttribute
{
	public BlueprintTypeAttribute()
		: base(MDClass.BlueprintType, value: true)
	{
	}
}
