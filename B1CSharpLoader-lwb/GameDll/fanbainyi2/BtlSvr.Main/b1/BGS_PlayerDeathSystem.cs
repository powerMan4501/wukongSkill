using b1.EventDelDefine;
using BtlShare;

namespace b1;

public class BGS_PlayerDeathSystem : GameModeSystemBase
{
	private BGC_PlayerDeathData _playerDeathData;

	private IBPC_PlayerRoleData _playerRoleData;

	public override void OnAttach()
	{
		_playerDeathData = RequireWritableGameStateData<BGC_PlayerDeathData>();
		_playerRoleData = RequireReadOnlyLocalPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		GetGameEventCollection().Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
	}

	private void OnUnitDead(string FinalGuid, EDeadReason DeadReason)
	{
		if (BGU_DataUtil.GetActorByGuid(Owner, FinalGuid) is BGUCharacterCS bGUCharacterCS && bGUCharacterCS.IsPlayerControlled() && bGUCharacterCS.IsLocallyControlled())
		{
			_playerDeathData.PlayerDeathCount++;
			int? num = _playerRoleData?.RoleData?.RoleCs?.Chapter?.CurChapter;
			if (num.HasValue)
			{
				_playerDeathData.ChapterDeathDict[num.Value] = ((!_playerDeathData.ChapterDeathDict.TryGetValue(num.Value, out var OutValue)) ? 1 : (OutValue + 1));
			}
		}
	}
}
