using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.GeoAreaState")]
public enum EGeoAreaState : byte
{
	Disable,
	Explored,
	Actived
}
