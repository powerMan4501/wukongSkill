using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class TooltipAttribute : UMetaAttribute
{
	public TooltipAttribute(string tooltip)
		: base(MD.ToolTip, tooltip)
	{
	}
}
