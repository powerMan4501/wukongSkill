using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class PlaceableAttribute : ManagedUnrealAttributeBase
{
	public bool IsPlacable { get; set; }

	public PlaceableAttribute(bool isPlacable)
	{
		IsPlacable = isPlacable;
	}

	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		if (IsPlacable && typeInfo.ClassFlags.HasFlag(EClassFlags.NotPlaceable))
		{
			base.InvalidTarget = true;
			base.InvalidTargetReason = "The 'placeable' specifier is only allowed on classes which have a base class that's marked as not placeable. Classes are assumed to be placeable by default.";
		}
		else if (!IsPlacable)
		{
			typeInfo.ClassFlags |= EClassFlags.NotPlaceable;
		}
	}
}
