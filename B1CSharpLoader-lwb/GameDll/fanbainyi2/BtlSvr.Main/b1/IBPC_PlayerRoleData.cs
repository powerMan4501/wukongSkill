using CommB1;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_PlayerRoleData
{
	EffectAttrList AttrFloatList { get; }

	ReadOnlyRoleData RoleData { get; }

	ReadOnlyRoleDataClient RoleData_Client { get; }

	int BeginAreaStayTime { get; }

	int LastRebirthPointTime { get; }

	int MapAreaId { get; }

	int MaxMapAreaId { get; }

	int MaxMapId { get; }

	int MapId { get; }

	int DefaultShortcutsPosition { get; }

	BindDictInt_GSUnitBookData UnitBookDataDic { get; }

	int GetGameTotalTime();

	int GetNewGamePlusCount();
}
