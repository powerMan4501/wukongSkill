using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EEmitterDynamicParameterValue", "Engine", UnrealModuleType.Engine)]
public enum EEmitterDynamicParameterValue
{
	EDPV_UserSet,
	EDPV_AutoSet,
	EDPV_VelocityX,
	EDPV_VelocityY,
	EDPV_VelocityZ,
	EDPV_VelocityMag
}
