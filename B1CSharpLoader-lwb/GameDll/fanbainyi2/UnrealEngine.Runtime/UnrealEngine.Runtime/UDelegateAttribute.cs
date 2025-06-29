using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class UDelegateAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessDelegate(ManagedUnrealTypeInfo typeInfo)
	{
		typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.UDelegate;
	}
}
