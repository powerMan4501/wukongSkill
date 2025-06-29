using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FractureEditor.EInspectedAttributeEnum", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EInspectedAttributeEnum : byte
{
	Volume = 0,
	Level = 1,
	InitialDynamicState = 3,
	Size = 4
}
