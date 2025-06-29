using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
public class CategoryAttribute : UMetaAttribute
{
	public CategoryAttribute(string category)
		: base(MD.Category, category)
	{
	}
}
