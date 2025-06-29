using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class AbstractAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		typeInfo.ClassFlags |= EClassFlags.Abstract;
	}
}
