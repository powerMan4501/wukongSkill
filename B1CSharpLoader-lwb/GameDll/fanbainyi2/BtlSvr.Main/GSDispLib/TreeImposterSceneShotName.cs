using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TreeImposterSceneShotName")]
public enum TreeImposterSceneShotName : byte
{
	BaseColor,
	NormalWS,
	Specular,
	Roughness,
	OpacityMask
}
