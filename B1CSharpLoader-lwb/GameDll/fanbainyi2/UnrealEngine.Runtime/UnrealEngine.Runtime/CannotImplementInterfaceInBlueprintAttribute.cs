using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Interface)]
public class CannotImplementInterfaceInBlueprintAttribute : UMetaAttribute
{
	public CannotImplementInterfaceInBlueprintAttribute()
		: base(MDInterface.CannotImplementInterfaceInBlueprint, value: true)
	{
	}
}
