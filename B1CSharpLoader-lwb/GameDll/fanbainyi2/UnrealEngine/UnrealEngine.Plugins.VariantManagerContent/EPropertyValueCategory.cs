using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UEnum]
[UMetaPath("/Script/VariantManagerContent.EPropertyValueCategory", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public enum EPropertyValueCategory
{
	Undefined = 0,
	Generic = 1,
	RelativeLocation = 2,
	RelativeRotation = 4,
	RelativeScale3D = 8,
	Visibility = 0x10,
	Material = 0x20,
	Color = 0x40,
	Option = 0x80
}
