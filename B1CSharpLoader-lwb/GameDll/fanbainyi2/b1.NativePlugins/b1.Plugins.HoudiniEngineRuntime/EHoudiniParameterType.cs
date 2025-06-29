using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniParameterType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniParameterType
{
	Invalid,
	Button,
	ButtonStrip,
	Color,
	ColorRamp,
	File,
	FileDir,
	FileGeo,
	FileImage,
	Float,
	FloatRamp,
	Folder,
	FolderList,
	Input,
	Int,
	IntChoice,
	Label,
	MultiParm,
	Separator,
	String,
	StringChoice,
	StringAssetRef,
	Toggle
}
