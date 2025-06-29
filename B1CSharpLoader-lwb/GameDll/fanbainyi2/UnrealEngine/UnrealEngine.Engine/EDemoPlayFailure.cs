using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EDemoPlayFailure", "Engine", UnrealModuleType.Engine)]
public enum EDemoPlayFailure : byte
{
	Generic,
	DemoNotFound,
	Corrupt,
	InvalidVersion,
	InitBase,
	GameSpecificHeader,
	ReplayStreamerInternal,
	LoadMap,
	Serialization
}
