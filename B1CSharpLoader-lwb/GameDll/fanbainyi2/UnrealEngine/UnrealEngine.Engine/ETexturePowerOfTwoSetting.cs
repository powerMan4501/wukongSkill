using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETexturePowerOfTwoSetting", "Engine", UnrealModuleType.Engine)]
public enum ETexturePowerOfTwoSetting
{
	None,
	PadToPowerOfTwo,
	PadToSquarePowerOfTwo
}
