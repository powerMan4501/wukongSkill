using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ESlateParentWindowSearchMethod", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateParentWindowSearchMethod : byte
{
	ActiveWindow,
	MainWindow
}
