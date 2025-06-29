using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class DisplayNameAttribute : UMetaAttribute
{
	public DisplayNameAttribute(string displayName)
		: base(MD.DisplayName, displayName)
	{
	}
}
