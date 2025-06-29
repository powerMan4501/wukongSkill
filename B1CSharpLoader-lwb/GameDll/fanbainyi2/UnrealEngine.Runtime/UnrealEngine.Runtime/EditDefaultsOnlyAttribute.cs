using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class EditDefaultsOnlyAttribute : EditorVisibleAttribute
{
	public EditDefaultsOnlyAttribute()
		: base(EditorVisible.Defaults)
	{
	}
}
