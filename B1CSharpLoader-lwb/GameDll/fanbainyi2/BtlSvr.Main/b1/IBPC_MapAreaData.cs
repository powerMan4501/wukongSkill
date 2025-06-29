using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
internal interface IBPC_MapAreaData
{
	GSBindProp<int> CurrentSpriteId { get; }

	GSBindProp<int> CurrentAreaId { get; }

	bool TryGetAreaId(AActor Actor, out int AreaId);

	bool TryGetAreaId(UObject WorldContext, int MapSpriteId, FVector2D MapPosition, out int AreaId);

	bool TryGetMapPositionByPlayer(UObject WorldContext, out int MapSpriteId, out FVector2D MapPosition, out float MapRotation);
}
