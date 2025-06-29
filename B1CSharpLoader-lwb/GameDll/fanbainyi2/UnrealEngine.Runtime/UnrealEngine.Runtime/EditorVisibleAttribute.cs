using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class EditorVisibleAttribute : ManagedUnrealAttributeBase
{
	public EditorVisible Visible { get; set; }

	public EditorVisibleAttribute(EditorVisible visible)
	{
		Visible = visible;
	}

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		switch (Visible)
		{
		case EditorVisible.Anywhere:
			propertyInfo.Flags |= EPropertyFlags.Edit;
			break;
		case EditorVisible.Instance:
			propertyInfo.Flags |= EPropertyFlags.Edit | EPropertyFlags.DisableEditOnTemplate;
			break;
		case EditorVisible.Defaults:
			propertyInfo.Flags |= EPropertyFlags.Edit | EPropertyFlags.DisableEditOnInstance;
			break;
		case EditorVisible.AnywhereReadOnly:
			propertyInfo.Flags |= EPropertyFlags.Edit | EPropertyFlags.EditConst;
			break;
		case EditorVisible.InstanceReadOnly:
			propertyInfo.Flags |= EPropertyFlags.Edit | EPropertyFlags.DisableEditOnTemplate | EPropertyFlags.EditConst;
			break;
		case EditorVisible.DefaultsReadOnly:
			propertyInfo.Flags |= EPropertyFlags.Edit | EPropertyFlags.DisableEditOnInstance | EPropertyFlags.EditConst;
			break;
		}
	}
}
