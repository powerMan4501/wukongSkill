using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContentEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/VariantManagerContentEditor.EVariantManagerTestEnum", "VariantManagerContentEditor", UnrealModuleType.EnginePlugin)]
public enum EVariantManagerTestEnum : byte
{
	None = 0,
	FirstOption = 1,
	SecondOption = 3,
	ThirdOption = 45
}
