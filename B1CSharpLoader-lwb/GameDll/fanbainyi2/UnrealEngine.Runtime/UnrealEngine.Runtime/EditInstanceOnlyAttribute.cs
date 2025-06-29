using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class EditInstanceOnlyAttribute : EditorVisibleAttribute
{
	public EditInstanceOnlyAttribute()
		: base(EditorVisible.Instance)
	{
	}
}
