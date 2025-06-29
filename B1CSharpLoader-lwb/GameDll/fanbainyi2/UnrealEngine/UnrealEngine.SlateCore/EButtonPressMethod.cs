using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EButtonPressMethod", "SlateCore", UnrealModuleType.Engine)]
public enum EButtonPressMethod : byte
{
	DownAndUp,
	ButtonPress,
	ButtonRelease
}
