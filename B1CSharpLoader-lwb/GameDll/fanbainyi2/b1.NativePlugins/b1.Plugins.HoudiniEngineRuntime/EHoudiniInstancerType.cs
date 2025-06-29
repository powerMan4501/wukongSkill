using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniInstancerType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniInstancerType
{
	Invalid,
	ObjectInstancer,
	PackedPrimitive,
	AttributeInstancer,
	OldSchoolAttributeInstancer,
	GeometryCollection
}
