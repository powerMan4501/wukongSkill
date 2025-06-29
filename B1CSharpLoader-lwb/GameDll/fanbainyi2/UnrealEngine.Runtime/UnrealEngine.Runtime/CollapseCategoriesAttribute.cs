using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class CollapseCategoriesAttribute : ManagedUnrealAttributeBase
{
	public bool Collapse { get; set; }

	public CollapseCategoriesAttribute(bool collapse)
	{
		Collapse = collapse;
	}

	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		if (Collapse)
		{
			typeInfo.ClassFlags |= EClassFlags.CollapseCategories;
		}
		else
		{
			typeInfo.ClassFlags &= ~EClassFlags.CollapseCategories;
		}
	}
}
