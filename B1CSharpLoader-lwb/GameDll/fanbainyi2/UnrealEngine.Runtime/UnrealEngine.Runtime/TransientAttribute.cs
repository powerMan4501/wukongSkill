using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class TransientAttribute : ManagedUnrealAttributeBase
{
	public bool IsTransient { get; set; }

	public TransientAttribute(bool isTransient)
	{
		IsTransient = isTransient;
	}

	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		if (IsTransient)
		{
			typeInfo.ClassFlags |= EClassFlags.Transient;
		}
		else
		{
			typeInfo.ClassFlags &= ~EClassFlags.Transient;
		}
	}
}
