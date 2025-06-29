using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ERichCurveTangentMode", "Engine", UnrealModuleType.Engine)]
public enum ERichCurveTangentMode : byte
{
	RCTM_Auto,
	RCTM_User,
	RCTM_Break,
	RCTM_None
}
