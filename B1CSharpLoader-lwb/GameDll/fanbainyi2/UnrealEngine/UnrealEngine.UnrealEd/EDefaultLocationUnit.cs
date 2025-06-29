using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EDefaultLocationUnit", "UnrealEd", UnrealModuleType.Engine)]
public enum EDefaultLocationUnit
{
	Micrometers,
	Millimeters,
	Centimeters,
	Meters,
	Kilometers,
	Inches,
	Feet,
	Yards,
	Miles,
	Invalid
}
