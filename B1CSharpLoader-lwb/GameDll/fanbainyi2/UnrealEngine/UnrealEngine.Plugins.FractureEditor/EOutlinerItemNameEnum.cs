using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FractureEditor.EOutlinerItemNameEnum", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EOutlinerItemNameEnum : byte
{
	BoneName,
	BoneIndex
}
