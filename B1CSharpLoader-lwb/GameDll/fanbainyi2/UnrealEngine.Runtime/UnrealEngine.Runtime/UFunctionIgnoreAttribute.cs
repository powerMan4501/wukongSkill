using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method)]
public class UFunctionIgnoreAttribute : ManagedUnrealAttributeBase
{
	public UFunctionIgnoreAttribute()
	{
		base.InvalidTarget = true;
	}
}
