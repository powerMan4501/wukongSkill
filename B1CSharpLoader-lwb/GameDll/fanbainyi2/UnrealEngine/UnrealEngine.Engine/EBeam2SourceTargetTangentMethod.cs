using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.Beam2SourceTargetTangentMethod", "Engine", UnrealModuleType.Engine)]
public enum EBeam2SourceTargetTangentMethod
{
	PEB2STTM_Direct,
	PEB2STTM_UserSet,
	PEB2STTM_Distribution,
	PEB2STTM_Emitter
}
