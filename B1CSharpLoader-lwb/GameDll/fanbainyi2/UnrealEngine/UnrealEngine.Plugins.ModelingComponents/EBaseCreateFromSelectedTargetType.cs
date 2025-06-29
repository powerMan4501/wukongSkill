using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[UMetaPath("/Script/ModelingComponents.EBaseCreateFromSelectedTargetType", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum EBaseCreateFromSelectedTargetType
{
	NewObject,
	FirstInputObject,
	LastInputObject
}
