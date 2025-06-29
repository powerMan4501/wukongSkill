using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EConfigIniFileNames", "UnrealExtent", UnrealModuleType.Game)]
public enum EConfigIniFileNames : byte
{
	GEngineIni,
	GGameIni,
	GGameUserSettingsIni,
	GEditorIni,
	GEditorKeyBindingsIni,
	GEditorLayoutIni,
	GEditorSettingsIni,
	GEditorPerProjectIni,
	GCompatIni,
	GLightmassIni,
	GScalabilityIni,
	GHardwareIni,
	GInputIni,
	GRuntimeOptionsIni,
	GInstallBundleIni,
	GDeviceProfilesIni,
	GSGameVersionIni
}
