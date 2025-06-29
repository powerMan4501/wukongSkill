using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Water.EWaterBodyType", "Water", UnrealModuleType.EnginePlugin)]
public enum EWaterBodyType : byte
{
	River,
	Lake,
	Ocean,
	Transition,
	Num
}
