using UnrealEngine.Runtime;

namespace UnrealEngine.WindowsTargetPlatform;

[UEnum]
[UMetaPath("/Script/WindowsTargetPlatform.EDefaultGraphicsRHI", "WindowsTargetPlatform", UnrealModuleType.Engine)]
public enum EDefaultGraphicsRHI
{
	DefaultGraphicsRHI_Default,
	DefaultGraphicsRHI_DX11,
	DefaultGraphicsRHI_DX12,
	DefaultGraphicsRHI_Vulkan
}
