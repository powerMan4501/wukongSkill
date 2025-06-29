using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class ReplicatedAttribute : ManagedUnrealAttributeBase
{
	public string ReplicatedUsing { get; set; }

	public ReplicatedAttribute()
	{
	}

	public ReplicatedAttribute(string replicatedUsing)
	{
		ReplicatedUsing = replicatedUsing;
	}

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		propertyInfo.Flags |= EPropertyFlags.Net;
		if (!string.IsNullOrEmpty(ReplicatedUsing))
		{
			propertyInfo.Flags |= EPropertyFlags.RepNotify;
			propertyInfo.RepNotifyName = ReplicatedUsing;
		}
	}
}
