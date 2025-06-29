using UnrealEngine.Runtime;

namespace UnrealEngine.UMGEditor;

[UEnum]
[UMetaPath("/Script/UMGEditor.EThumbnailPreviewSizeMode", "UMGEditor", UnrealModuleType.Engine)]
public enum EThumbnailPreviewSizeMode
{
	MatchDesignerMode,
	FillScreen,
	Custom,
	Desired
}
