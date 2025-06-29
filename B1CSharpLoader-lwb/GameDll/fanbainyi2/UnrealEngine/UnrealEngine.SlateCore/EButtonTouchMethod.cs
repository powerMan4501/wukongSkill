using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EButtonTouchMethod", "SlateCore", UnrealModuleType.Engine)]
public enum EButtonTouchMethod : byte
{
	DownAndUp,
	Down,
	PreciseTap
}
