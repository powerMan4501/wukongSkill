using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EConsoleVariableFlags : uint
{
	Default = 0u,
	Cheat = 1u,
	ReadOnly = 4u,
	Unregistered = 8u,
	CreatedFromIni = 0x10u,
	RenderThreadSafe = 0x20u,
	Scalability = 0x40u,
	ScalabilityGroup = 0x80u,
	Preview = 0x100u,
	SetByMask = 0xFF000000u,
	SetByConstructor = 0u,
	SetByScalability = 0x1000000u,
	SetByGameSetting = 0x2000000u,
	SetByProjectSetting = 0x3000000u,
	SetBySystemSettingsIni = 0x4000000u,
	SetByDeviceProfile = 0x5000000u,
	SetByGameOverride = 0x6000000u,
	SetByConsoleVariablesIni = 0x7000000u,
	SetByCommandline = 0x8000000u,
	SetByCode = 0x9000000u,
	SetByConsole = 0xA000000u
}
