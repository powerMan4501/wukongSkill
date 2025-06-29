using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EModuleType", "Engine", UnrealModuleType.Engine)]
public enum EModuleType
{
	EPMT_General,
	EPMT_TypeData,
	EPMT_Beam,
	EPMT_Trail,
	EPMT_Spawn,
	EPMT_Required,
	EPMT_Event,
	EPMT_Light,
	EPMT_SubUV
}
