using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Interface)]
public class UInterfaceAttribute : ManagedUnrealAttributeBase
{
	public uint Flags { get; set; }

	public override void ProcessInterface(ManagedUnrealTypeInfo typeInfo)
	{
		typeInfo.ClassFlags |= (EClassFlags)(Flags | 0x4000 | 1);
		typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.UInterface;
	}
}
