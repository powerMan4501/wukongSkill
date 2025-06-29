using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EClearSceneOptions", "Engine", UnrealModuleType.Engine)]
public enum EClearSceneOptions
{
	NoClear,
	HardwareClear,
	QuadAtMaxZ
}
