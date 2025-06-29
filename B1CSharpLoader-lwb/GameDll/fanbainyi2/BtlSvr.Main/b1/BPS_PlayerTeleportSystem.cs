using System;
using b1.EventDelDefine;

namespace b1;

public class BPS_PlayerTeleportSystem : PlayerControllerSystemBase
{
	private IBIC_LevelData levelData;

	private IBPC_PlayerRoleData PlayerRoleData;

	private BGW_EventCollection BGWEvent;

	public override void OnAttach()
	{
		GetPlayerEventCollection().Evt_BPS_TeleportTo += new Del_BPS_TeleportTo(OnPlayerTeleportTo);
		levelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		PlayerRoleData = RequireReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		BGWEvent = BGW_EventCollection.Get(Owner);
	}

	private void OnPlayerTeleportTo(ETeleportTypeV2 TeleportType, ValueType UserData, EPlayerTeleportReason Reason)
	{
		BGW_EventCollection.Get(Owner).Evt_TriggerPlayerTeleport(base.PlayerController, TeleportType, UserData, Reason);
	}
}
