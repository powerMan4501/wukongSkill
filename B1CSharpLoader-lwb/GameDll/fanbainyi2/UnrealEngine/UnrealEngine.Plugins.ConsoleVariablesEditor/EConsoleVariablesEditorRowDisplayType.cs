using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConsoleVariablesEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ConsoleVariablesEditor.EConsoleVariablesEditorRowDisplayType", "ConsoleVariablesEditor", UnrealModuleType.EnginePlugin)]
public enum EConsoleVariablesEditorRowDisplayType : byte
{
	ShowCurrentValue,
	ShowLastEnteredValue
}
