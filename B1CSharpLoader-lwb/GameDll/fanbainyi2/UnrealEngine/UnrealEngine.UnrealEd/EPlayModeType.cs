using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPlayModeType", "UnrealEd", UnrealModuleType.Engine)]
public enum EPlayModeType
{
	PlayMode_InViewPort,
	PlayMode_InEditorFloating,
	PlayMode_InMobilePreview,
	PlayMode_InTargetedMobilePreview,
	PlayMode_InVulkanPreview,
	PlayMode_InNewProcess,
	PlayMode_InVR,
	PlayMode_Simulate,
	PlayMode_QuickLaunch,
	PlayMode_Count
}
