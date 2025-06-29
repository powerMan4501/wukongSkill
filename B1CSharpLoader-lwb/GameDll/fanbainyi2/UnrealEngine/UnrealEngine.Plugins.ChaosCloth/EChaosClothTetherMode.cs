using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosCloth;

[UEnum]
[UMetaPath("/Script/ChaosCloth.EChaosClothTetherMode", "ChaosCloth", UnrealModuleType.EnginePlugin)]
public enum EChaosClothTetherMode
{
	FastTetherFastLength,
	AccurateTetherFastLength,
	AccurateTetherAccurateLength,
	MaxChaosClothTetherMode
}
