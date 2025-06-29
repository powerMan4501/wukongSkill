using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.FollowPartnerSpawnType")]
public enum EFollowPartnerSpawnType : byte
{
	BySceneItem,
	ByEqs
}
