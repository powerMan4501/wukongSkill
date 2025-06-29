using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class UClassAttribute : ManagedUnrealAttributeBase
{
	public ClassFlags Flags { get; set; }

	public string Config { get; set; }

	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.UClass;
		typeInfo.ClassFlags |= (EClassFlags)(int)Flags;
		if (!string.IsNullOrEmpty(Config))
		{
			typeInfo.ClassConfigName = Config;
		}
	}
}
