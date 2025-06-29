using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class ShortTooltipAttribute : UMetaAttribute
{
	public ShortTooltipAttribute(string tooltip)
		: base(MD.ShortTooltip, tooltip)
	{
	}
}
