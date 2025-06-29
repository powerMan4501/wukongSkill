using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EButtonClickMethod", "SlateCore", UnrealModuleType.Engine)]
public enum EButtonClickMethod : byte
{
	DownAndUp,
	MouseDown,
	MouseUp,
	PreciseClick
}
