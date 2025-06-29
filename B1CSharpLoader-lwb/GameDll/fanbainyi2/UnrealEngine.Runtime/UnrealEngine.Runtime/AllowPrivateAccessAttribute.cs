using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class AllowPrivateAccessAttribute : UMetaAttribute
{
	public AllowPrivateAccessAttribute()
		: base(MDProp.AllowPrivateAccess, value: true)
	{
	}
}
