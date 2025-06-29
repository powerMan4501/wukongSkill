using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

[NeedToUI]
public interface IBUC_BattleStateData
{
	List<Entity> AlreadySetOwnerAsTargetUnitList { get; }

	List<Entity> CanSetOwnerAsTargetUnitList { get; }

	bool IsUnitInBattle();

	bool IsUnitInBattleAssignPlayer(AActor PlayerActor);

	bool PlayerHasBeTarget();
}
