using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETravelFailure", "Engine", UnrealModuleType.Engine)]
public enum ETravelFailure : byte
{
	NoLevel,
	LoadMapFailure,
	InvalidURL,
	PackageMissing,
	PackageVersion,
	NoDownload,
	TravelFailure,
	CheatCommands,
	PendingNetGameCreateFailure,
	CloudSaveFailure,
	ServerTravelFailure,
	ClientTravelFailure
}
