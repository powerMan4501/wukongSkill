using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_AreaBasicData
{
	EAreaType AreaType { get; }

	FAreaUnitFilter UnitFilter { get; }

	bool IngnorePlayerTrans { get; }

	bool bAutoEnableOverlap { get; }

	bool bNotifyGraph { get; }

	HashSet<Entity> InnerEntityList { get; }

	bool bIsEntityInner(Entity _Entity);

	bool IsLocalPlayer(ACharacter Character);
}
