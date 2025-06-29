using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Interface)]
public class UInterfaceIgnoreAttribute : ManagedUnrealAttributeBase
{
	public UInterfaceIgnoreAttribute()
	{
		base.InvalidTarget = true;
	}
}
