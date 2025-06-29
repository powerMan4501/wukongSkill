using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.EDatasmithAreaLightActorShape", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithAreaLightActorShape : byte
{
	Rectangle,
	Disc,
	Sphere,
	Cylinder,
	None
}
