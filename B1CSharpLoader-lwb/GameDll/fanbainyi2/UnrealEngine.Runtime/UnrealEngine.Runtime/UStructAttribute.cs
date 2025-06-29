using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class UStructAttribute : ManagedUnrealAttributeBase
{
	public bool ForceBlittable { get; set; }

	public bool Atomic { get; set; }

	public int Flags { get; set; }

	public override void ProcessStruct(ManagedUnrealTypeInfo typeInfo)
	{
		typeInfo.StructFlags |= (EStructFlags)Flags;
		if (ForceBlittable)
		{
			typeInfo.BlittableKind = ManagedUnrealBlittableKind.ForceBlittable;
		}
		if (Atomic)
		{
			typeInfo.StructFlags |= EStructFlags.Atomic;
		}
		typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.UStruct;
	}
}
