using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AssociationUnitSpawnType")]
public enum EAssociationUnitSpawnType : byte
{
	[DisplayName("通过场景物件指定位置")]
	BySceneItem,
	[DisplayName("通过EQS指定位置")]
	ByEQS
}
