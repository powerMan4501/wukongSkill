using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[UMetaPath("/Script/UMG.EDesignPreviewSizeMode", "UMG", UnrealModuleType.Engine)]
public enum EDesignPreviewSizeMode
{
	FillScreen,
	Custom,
	CustomOnScreen,
	Desired,
	DesiredOnScreen
}
