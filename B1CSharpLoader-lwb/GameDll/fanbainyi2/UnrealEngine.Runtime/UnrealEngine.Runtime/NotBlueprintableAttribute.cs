using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class NotBlueprintableAttribute : UMetaAttribute
{
	public NotBlueprintableAttribute()
		: base(MDClass.NotBlueprintable, value: true)
	{
	}
}
