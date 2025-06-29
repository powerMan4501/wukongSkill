using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EScreenOrientation", "Engine", UnrealModuleType.Engine)]
public enum EScreenOrientation : byte
{
	Unknown,
	Portrait,
	PortraitUpsideDown,
	LandscapeLeft,
	LandscapeRight,
	FaceUp,
	FaceDown
}
