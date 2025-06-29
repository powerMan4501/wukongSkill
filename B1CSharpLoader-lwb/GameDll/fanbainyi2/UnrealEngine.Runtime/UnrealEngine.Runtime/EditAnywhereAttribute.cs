using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class EditAnywhereAttribute : EditorVisibleAttribute
{
	public EditAnywhereAttribute()
		: base(EditorVisible.Anywhere)
	{
	}
}
