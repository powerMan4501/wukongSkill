using UnrealEngine.Runtime;

namespace UnrealEngine.AutomationTest;

[UEnum]
[UMetaPath("/Script/AutomationTest.ERHI_Flags", "AutomationTest", UnrealModuleType.Engine)]
public enum ERHI_Flags
{
	DirectX11 = 1,
	DirectX12 = 2,
	Vulkan = 4,
	NUM = 5
}
