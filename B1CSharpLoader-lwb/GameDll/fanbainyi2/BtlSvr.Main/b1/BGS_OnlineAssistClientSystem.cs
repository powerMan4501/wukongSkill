using b1.EventDelDefine;

namespace b1;

public class BGS_OnlineAssistClientSystem : GameStateSystemBase
{
	private BGC_OnlineAssistData _onlineAssistData;

	private IBPC_RebirthPointData _rebirthPointData;

	private IBPC_PlayerRoleData _playerRoleData;

	public override void OnAttach()
	{
		_onlineAssistData = RequireWritableData<BGC_OnlineAssistData>();
		_rebirthPointData = RequireReadOnlyLocalPlayerControlData<IBPC_RebirthPointData, BPC_RebirthPointData>();
		_playerRoleData = RequireReadOnlyLocalPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(Owner);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_TeamWipeOut += new Del_Void(OnTeamWipeOut);
			bGS_GSEventCollection.Evt_CrusadeSuccess += new Del_Void(OnCrusadeSuccess);
			bGS_GSEventCollection.Evt_FetchTeleportInfoBeforeAssist += new Del_Void_OutIntInt(OnFetchTeleportInfoBeforeAssist);
		}
	}

	private void OnTeamWipeOut()
	{
		FinishAssist();
	}

	private void OnCrusadeSuccess()
	{
		FinishAssist();
	}

	private void OnFetchTeleportInfoBeforeAssist(out int LevelId, out int RebirthPointId)
	{
		LevelId = _playerRoleData.MapId;
		RebirthPointId = _rebirthPointData.GetCurrentRebirthPointID(Owner);
	}

	private void FinishAssist()
	{
		_ = _onlineAssistData.IsHomeOwner;
	}
}
