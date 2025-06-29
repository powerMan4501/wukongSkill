using UnrealEngine.Runtime;

namespace b1.Plugins.ConsoleVariableManager;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ConsoleVariableManager.EConsoleVariablePriority", "ConsoleVariableManager", UnrealModuleType.GamePlugin)]
public enum EConsoleVariablePriority : byte
{
	None = 0,
	Original = 1,
	SetByCode = 2,
	GameSettings = 10,
	CLSVolume = 20,
	SceneVolume = 30,
	Vfx = 40,
	UI = 50,
	Default = 100
}
