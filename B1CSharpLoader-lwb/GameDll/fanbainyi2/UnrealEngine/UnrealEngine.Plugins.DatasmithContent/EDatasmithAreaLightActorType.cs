using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.EDatasmithAreaLightActorType", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithAreaLightActorType : byte
{
	Point,
	Spot,
	Rect
}
