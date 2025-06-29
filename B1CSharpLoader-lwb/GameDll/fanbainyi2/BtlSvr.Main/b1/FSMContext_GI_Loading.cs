using ArchiveB1;
using UnrealEngine.Engine;

namespace b1;

public class FSMContext_GI_Loading : FSMContextBase
{
	public BGWGameInstanceCS GameInst;

	public int ArchiveId = -1;

	public FUStBEDArchivesData ArchivesData;

	public ReadArchiveResult ArchiveResult;

	public ELevelTravelType LevelTravelType;

	public ELoadingUIFadeInReason Reason;

	public int TargetLevelId;

	public TeleportTemplateBase TeleportTemplate;

	public TravelLevelTemplateBase TravelLevelTemplate;

	public int SeqID = 10000010;

	public PastMemoriesOne Memories;

	public APlayerController Controller;

	public GMTravelParams GMTravelParams;

	public bool BattleLevelTravelNeedWaitCameraBlend;

	public FSMContext_GI_Loading(BGWGameInstanceCS GameInst)
	{
		this.GameInst = GameInst;
	}

	public bool TryGetTargetLevelId(out int LevelId)
	{
		LevelId = 0;
		switch (Reason)
		{
		case ELoadingUIFadeInReason.None:
			LevelId = BGUFuncLibMap.GetCurLevelId(GameInst);
			break;
		case ELoadingUIFadeInReason.CombatTeleport:
			if (TeleportTemplate != null)
			{
				LevelId = TeleportTemplate.GetTargetLevelId();
			}
			break;
		case ELoadingUIFadeInReason.NonCombatTeleport:
			if (TargetLevelId > 0)
			{
				LevelId = TargetLevelId;
			}
			else if (ArchivesData != null)
			{
				LevelId = ArchivesData.PersistentECSData.BPCData.BPCPlayerRoleData.MapId;
			}
			break;
		case ELoadingUIFadeInReason.OnlineDisconnect:
			LevelId = BGUFuncLibMap.GetLevelIdByName(UGSE_OnlineFuncLib.GetGameDefaultMap());
			break;
		}
		return LevelId != 0;
	}

	public bool LevelTravalUseSeamless()
	{
		if (!DebugConfig.OpenSeamlessLevelTravel || TeleportTemplate == null)
		{
			return false;
		}
		return TeleportTemplate.CanUseSeamlessLevelTravel();
	}
}
