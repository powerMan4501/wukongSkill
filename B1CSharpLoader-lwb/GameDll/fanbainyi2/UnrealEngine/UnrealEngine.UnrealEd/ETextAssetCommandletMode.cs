using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ETextAssetCommandletMode", "UnrealEd", UnrealModuleType.Engine)]
public enum ETextAssetCommandletMode
{
	ResaveText,
	ResaveBinary,
	RoundTrip,
	LoadBinary,
	LoadText,
	FindMismatchedSerializers,
	GenerateSchema
}
