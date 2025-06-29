using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PBIK;

[UEnum]
[UMetaPath("/Script/PBIK.EPBIKRootBehavior", "PBIK", UnrealModuleType.EnginePlugin)]
public enum EPBIKRootBehavior
{
	PrePull,
	PinToInput,
	Free
}
