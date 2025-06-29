using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSEArteries.GSArteriesIteractType", "GSEArteries", UnrealModuleType.GamePlugin)]
public enum EGSArteriesIteractType : byte
{
	Spline,
	Box,
	BoxWithSpline
}
