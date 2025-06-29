using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class VisibleInstanceOnlyAttribute : EditorVisibleAttribute
{
	public VisibleInstanceOnlyAttribute()
		: base(EditorVisible.InstanceReadOnly)
	{
	}
}
