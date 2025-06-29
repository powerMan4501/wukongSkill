using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBGC_GlobalBattleStateData
{
	Dictionary<string, BGUCharacterCS> CanForceLeaveBattleUnits { get; }

	List<Entity> GetInBattleUnitByBloodBarType(EBGUBloodBarType BloodBarType);

	List<Entity> GetAllInBattleUnitByBloodBarType();

	bool IsBossRoomMonster(string UnitGuid);

	bool IsInBossRoom();
}
