using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class VisibleAnywhereAttribute : EditorVisibleAttribute
{
	public VisibleAnywhereAttribute()
		: base(EditorVisible.AnywhereReadOnly)
	{
	}
}
