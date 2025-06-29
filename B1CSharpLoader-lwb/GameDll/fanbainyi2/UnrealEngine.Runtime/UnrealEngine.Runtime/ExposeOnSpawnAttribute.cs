using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class ExposeOnSpawnAttribute : ManagedUnrealAttributeBase
{
	public override bool HasMetaData => true;

	public override void SetMetaData(Dictionary<FName, string> metadata)
	{
		metadata[UMeta.GetKeyName(MDProp.ExposeOnSpawn)] = "true";
	}

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		propertyInfo.Flags |= EPropertyFlags.ExposeOnSpawn;
	}
}
