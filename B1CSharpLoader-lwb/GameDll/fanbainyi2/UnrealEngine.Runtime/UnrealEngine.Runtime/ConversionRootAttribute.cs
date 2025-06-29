using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ConversionRootAttribute : UMetaAttribute
{
	public ConversionRootAttribute()
		: base(MDClass.IsConversionRoot, value: true)
	{
	}
}
