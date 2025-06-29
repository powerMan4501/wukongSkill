using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETimelineSigType", "Engine", UnrealModuleType.Engine)]
public enum ETimelineSigType
{
	ETS_EventSignature,
	ETS_FloatSignature,
	ETS_VectorSignature,
	ETS_LinearColorSignature,
	ETS_InvalidSignature
}
