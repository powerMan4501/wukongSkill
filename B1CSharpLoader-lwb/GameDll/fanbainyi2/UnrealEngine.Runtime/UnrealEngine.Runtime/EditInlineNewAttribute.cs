using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class EditInlineNewAttribute : ManagedUnrealAttributeBase
{
	public bool Enabled { get; set; }

	public EditInlineNewAttribute()
		: this(enabled: true)
	{
	}

	public EditInlineNewAttribute(bool enabled)
	{
		Enabled = enabled;
	}

	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		if (Enabled)
		{
			typeInfo.ClassFlags |= EClassFlags.EditInlineNew;
		}
		else
		{
			typeInfo.ClassFlags &= ~EClassFlags.EditInlineNew;
		}
	}
}
