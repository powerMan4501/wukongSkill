using b1.BGW;
using B1UI.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public struct FLoadingTipsInfo
{
	private readonly UTexture2D _cacheImageObject;

	private readonly FSMContext_GI_Loading _loadingContext;

	private int? _cacheCurrentLevelId;

	private int? _cacheTargetLevelId;

	private UObject WorldContext => _loadingContext.GameInst;

	private int CurrentLevelId
	{
		get
		{
			int? cacheCurrentLevelId = _cacheCurrentLevelId;
			if (!cacheCurrentLevelId.HasValue)
			{
				int? num = (_cacheCurrentLevelId = BGUFuncLibMap.GetCurLevelId(WorldContext));
				return num.Value;
			}
			return cacheCurrentLevelId.GetValueOrDefault();
		}
	}

	private int TargetLevelId
	{
		get
		{
			if (!_cacheTargetLevelId.HasValue)
			{
				switch (_loadingContext.Reason)
				{
				case ELoadingUIFadeInReason.CombatTeleport:
					if (_loadingContext.TeleportTemplate != null)
					{
						int targetLevelId = _loadingContext.TeleportTemplate.GetTargetLevelId();
						_cacheTargetLevelId = ((targetLevelId != -1) ? targetLevelId : CurrentLevelId);
					}
					break;
				case ELoadingUIFadeInReason.NonCombatTeleport:
					if (_loadingContext.TargetLevelId > 0)
					{
						_cacheTargetLevelId = _loadingContext.TargetLevelId;
					}
					else if (_loadingContext.ArchivesData != null)
					{
						_cacheTargetLevelId = _loadingContext.ArchivesData.PersistentECSData?.BPCData?.BPCPlayerRoleData?.MapId;
					}
					break;
				case ELoadingUIFadeInReason.OnlineDisconnect:
					_cacheTargetLevelId = BGUFuncLibMap.GetLevelIdByName(UGSE_OnlineFuncLib.GetGameDefaultMap());
					break;
				}
			}
			int? cacheTargetLevelId = _cacheTargetLevelId;
			if (!cacheTargetLevelId.HasValue)
			{
				int? num = (_cacheTargetLevelId = -1);
				return num.Value;
			}
			return cacheTargetLevelId.GetValueOrDefault();
		}
	}

	public FLoadingTipsInfo(FSMContext_GI_Loading LoadingContext)
	{
		this = default(FLoadingTipsInfo);
		_loadingContext = LoadingContext;
		_cacheCurrentLevelId = null;
		_cacheTargetLevelId = null;
		if (CurrentLevelId != TargetLevelId && TargetLevelId != -1)
		{
			int imageId = GameDBRuntime.GetLevelDesc(TargetLevelId)?.TravelLevelLoadingScreenImageId ?? 0;
			_cacheImageObject = GetImageObjectById(imageId);
		}
	}

	private ELoadingTipsType GetLoadingTipsTeleportType()
	{
		switch (_loadingContext.Reason)
		{
		case ELoadingUIFadeInReason.CombatTeleport:
			return ELoadingTipsType.BattleTeleport;
		case ELoadingUIFadeInReason.NonCombatTeleport:
			if (BGUFuncLibMap.IsMainMenuLevelId(TargetLevelId, WorldContext))
			{
				return ELoadingTipsType.StartUpTeleport;
			}
			if (BGUFuncLibMap.IsPartyLevel(TargetLevelId, WorldContext))
			{
				return ELoadingTipsType.PartyTeleport;
			}
			return ELoadingTipsType.BattleTeleport;
		case ELoadingUIFadeInReason.OnlineDisconnect:
			return ELoadingTipsType.DisconnectTeleport;
		default:
			return ELoadingTipsType.None;
		}
	}

	public UTexture2D GetImageObj(int ImageId)
	{
		if (!(_cacheImageObject != null))
		{
			return GetImageObjectById(ImageId);
		}
		return _cacheImageObject;
	}

	public UTexture2D GetImageObjectById(int ImageId)
	{
		return BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UTexture2D>(GSUIResPathUtil.GetLoadTipsImagePath(ImageId), EUIResourceLoadType.NoCache);
	}

	public void SetBattleParamData(FLoadingTipsBattleParam BattleParam)
	{
		BattleParam.LevelId = TargetLevelId;
		if (_loadingContext.TeleportTemplate is TeleportTemplateRebirthPointBase teleportTemplateRebirthPointBase)
		{
			BattleParam.RebirthPointId = teleportTemplateRebirthPointBase.GetRebirthPointId();
		}
		if (BattleParam.LoadingTipsType == ELoadingTipsType.None)
		{
			BattleParam.LoadingTipsType = GetLoadingTipsTeleportType();
		}
	}
}
