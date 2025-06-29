using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperatorsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingOperatorsEditorOnly.ESimplifyType", "ModelingOperatorsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum ESimplifyType
{
	QEM,
	Attribute,
	UEStandard,
	MinimalExistingVertex,
	MinimalPlanar,
	MinimalPolygroup
}
