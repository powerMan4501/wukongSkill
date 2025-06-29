using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class NotReplicatedAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		propertyInfo.Flags |= EPropertyFlags.RepSkip;
	}
}
