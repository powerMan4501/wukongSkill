using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class VisibleDefaultsOnlyAttribute : EditorVisibleAttribute
{
	public VisibleDefaultsOnlyAttribute()
		: base(EditorVisible.DefaultsReadOnly)
	{
	}
}
