using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class BlueprintableAttribute : UMetaAttribute
{
	public BlueprintableAttribute()
		: base(MDClass.Blueprintable, value: true)
	{
	}
}
