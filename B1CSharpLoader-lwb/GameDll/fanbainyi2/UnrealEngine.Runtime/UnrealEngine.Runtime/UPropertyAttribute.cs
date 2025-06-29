using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class UPropertyAttribute : ManagedUnrealAttributeBase
{
	public int FixedSizeArrayDim { get; set; }

	public bool IsFixedSizeArray => FixedSizeArrayDim > 1;

	public PropFlags Flags { get; set; }

	public override bool HasMetaData => Flags.HasFlag(PropFlags.Instanced);

	public UPropertyAttribute()
	{
	}

	public UPropertyAttribute(PropFlags flags)
	{
		Flags = flags;
	}

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		propertyInfo.FixedSizeArrayDim = FixedSizeArrayDim;
		propertyInfo.AdditionalFlags |= ManagedUnrealPropertyFlags.UProperty;
		propertyInfo.Flags |= (EPropertyFlags)Flags;
		base.ProcessProperty(propertyInfo);
	}

	public override void SetMetaData(Dictionary<FName, string> metadata)
	{
		if (Flags.HasFlag(PropFlags.Instanced))
		{
			metadata[UMeta.GetKeyName(MDProp.EditInline)] = "true";
		}
	}
}
