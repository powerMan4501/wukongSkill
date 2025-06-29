using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class BlueprintVisibleAttribute : ManagedUnrealAttributeBase
{
	public bool ReadOnly { get; set; }

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		propertyInfo.Flags |= EPropertyFlags.BlueprintVisible;
		if (ReadOnly)
		{
			propertyInfo.Flags |= EPropertyFlags.BlueprintReadOnly;
		}
	}
}
