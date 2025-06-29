using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EFractureBrickBond", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EFractureBrickBond
{
	Stretcher,
	Stack,
	English,
	Header,
	Flemish
}
