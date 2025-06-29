using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ClassGroupAttribute : UMetaAttribute
{
	public ClassGroupAttribute(string group)
		: base(MDClass.ClassGroupNames, group)
	{
	}
}
