using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public class NotBlueprintTypeAttribute : UMetaAttribute
{
	public NotBlueprintTypeAttribute()
		: base(MDClass.NotBlueprintType, value: true)
	{
	}
}
