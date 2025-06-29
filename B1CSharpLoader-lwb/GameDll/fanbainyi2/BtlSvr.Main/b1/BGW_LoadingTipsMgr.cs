using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.AsyncLoadingScreen;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_LoadingTipsMgr")]
public class BGW_LoadingTipsMgr : GameInstanceSystemBaseUObj
{
	private class FLoadingScreenTimeTracker
	{
		private bool _stopTimer;

		private float _timer;

		private bool _haveReport;

		private readonly float _maxOpenTime;

		private readonly float _maxShowTipsTime;

		private readonly BGWGameInstanceCS _gameInstance;

		private readonly IConsoleVariable _disableLoadingScreen;

		public FLoadingScreenTimeTracker(BGWGameInstanceCS GameInstance)
		{
			_gameInstance = GameInstance;
			_stopTimer = true;
			_timer = 0f;
			_haveReport = false;
			_maxOpenTime = DebugConfig.LoadingMaxTime;
			_maxShowTipsTime = DebugConfig.LoadingMaxTimeShowTips;
			_disableLoadingScreen = IConsoleManager.Get().FindConsoleVariable("r.GSDisableLoadingScreen");
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(_gameInstance);
			bGW_EventCollection.Evt_PostLoadingScreenOpen = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadingScreenOpen, new Del_Void(OnLoadingScreenOpen));
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(_gameInstance);
			bGW_EventCollection2.Evt_PostLoadingScreenClose = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_PostLoadingScreenClose, new Del_Void(OnLoadingScreenClose));
			BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(_gameInstance);
			bGW_EventCollection3.Evt_PostLoadingScreenWaitUserInputBegin = (Del_Void)Delegate.Combine(bGW_EventCollection3.Evt_PostLoadingScreenWaitUserInputBegin, new Del_Void(OnLoadingScreenWaitUserInputBegin));
			BGW_EventCollection bGW_EventCollection4 = BGW_EventCollection.Get(_gameInstance);
			bGW_EventCollection4.Evt_PostLoadingScreenWaitUserInputEnd = (Del_Void)Delegate.Combine(bGW_EventCollection4.Evt_PostLoadingScreenWaitUserInputEnd, new Del_Void(OnLoadingScreenWaitUserInputEnd));
		}

		private void OnLoadingScreenOpen()
		{
			_stopTimer = false;
			_haveReport = false;
			_timer = 0f;
		}

		private void OnLoadingScreenClose()
		{
			if (_timer > _maxShowTipsTime)
			{
				BGW_UIEventCollection.Get(_gameInstance).Evt_UI_ShowLoadingExceedTimeTips();
			}
			_stopTimer = true;
			_timer = 0f;
		}

		private void OnLoadingScreenWaitUserInputBegin()
		{
			_stopTimer = true;
		}

		private void OnLoadingScreenWaitUserInputEnd()
		{
			_stopTimer = false;
		}

		public void OnTick(float DeltaTime)
		{
			if (!_stopTimer && !(_disableLoadingScreen == null) && _disableLoadingScreen.GetInt() != 1)
			{
				_timer += DeltaTime;
				if (!_haveReport && !GSEUtil.Ensure(_timer < _maxOpenTime, $"Loading Screen has opened for more than {_maxOpenTime} seconds"))
				{
					_haveReport = true;
				}
			}
		}
	}

	public static WeakReference<BGW_LoadingTipsMgr> InstanceRef;

	private FLoadingScreenPreview _loadingScreenPreviewCache;

	private FLoadingScreenTimeTracker _loadingScreenTimeTracker;

	public FLoadingColorAlphaTracker LoadingColorAlphaTracker;

	private List<int> _cachedImageIdList;

	private b1.IBIC_DreamTeleportData _dreamTeleportData;

	private Dictionary<EBossRushLoadingType, Dictionary<string, string>> _bossRushWidgetToMaskDict = new Dictionary<EBossRushLoadingType, Dictionary<string, string>>
	{
		{
			EBossRushLoadingType.ReChallengeBoss,
			new Dictionary<string, string>
			{
				{ "RechallengeMask", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/MASK_loadingbossrush_solo.MASK_loadingbossrush_solo'" },
				{ "ImgTitleTxtRechallenge", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_loadingbossrush_titletxt_solo.IMG_loadingbossrush_titletxt_solo'" },
				{ "ImgCoreRechallenge", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_bossrushdifficulty_loading_bg.IMG_bossrushdifficulty_loading_bg'" },
				{ "ImgCoreSubTitle", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_bossrushdifficulty_subtitle.IMG_bossrushdifficulty_subtitle'" },
				{ "ImgTitleRechallenge", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_bossrushdifficulty_bar.IMG_bossrushdifficulty_bar'" }
			}
		},
		{
			EBossRushLoadingType.BossIterations,
			new Dictionary<string, string>
			{
				{ "IterationsMask", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/MASK_loadingbossrush_combo.MASK_loadingbossrush_combo'" },
				{ "ImgTitleTxtIterations", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_loadingbossrush_titletxt_combo.IMG_loadingbossrush_titletxt_combo'" },
				{ "ImgCoreIterations", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_bossrushdifficulty_loading_bg.IMG_bossrushdifficulty_loading_bg'" },
				{ "ImgCoreDebuffBg", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_bossrushend_debuff_bg.IMG_bossrushend_debuff_bg'" },
				{ "ImgTitleIterations", "Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/IMG_bossrushdifficulty_bar.IMG_bossrushdifficulty_bar'" }
			}
		}
	};

	private FLoadingScreenPreview LoadingScreenPreview => _loadingScreenPreviewCache ?? (_loadingScreenPreviewCache = new FLoadingScreenPreview(this));

	private APlayerController LocalPlayerController => UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);

	public FLoadingTipsBattleParam BattleParam { get; set; }

	public FLoadingTipsRoleDataParam RoleDataParam
	{
		get
		{
			FLoadingTipsRoleDataParam fLoadingTipsRoleDataParam = new FLoadingTipsRoleDataParam();
			ReadOnlyRoleData RoleData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(LocalPlayerController)?.RoleData;
			if (RoleData == null)
			{
				return fLoadingTipsRoleDataParam;
			}
			fLoadingTipsRoleDataParam.IsConfigureWinePartner = !RoleData.RoleCs.Bag.WineList.Any((ReadOnlyRoleWine wine) => wine.WineId == RoleData.RoleCs.Actor.Wear.WineId && wine.ItemList.Any((ReadOnlyWinePartner winePartner) => winePartner.ItemId == 0));
			fLoadingTipsRoleDataParam.IsAllShortcutConfigureItem = RoleData.RoleCs.Actor.Wear.ShortcutsList.Count >= 4 && !RoleData.RoleCs.Actor.Wear.ShortcutsList.Any((ReadOnlyShortcutItem ShortcutItem) => ShortcutItem.ItemId == 0);
			fLoadingTipsRoleDataParam.TalentPointNum = RoleData.RoleCs.Actor.Progress.TalenPoint;
			fLoadingTipsRoleDataParam.SpiritNum = RoleData.RoleCs.Bag.MoneyList.FirstOrDefault((ReadOnlyRoleMoney MoneyItem) => MoneyItem.MoneyType == MoneyType.Spirit)?.MoneyValue ?? 0;
			foreach (ReadOnlyWearEquip equip in RoleData.RoleCs.Actor.Wear.EquipList)
			{
				fLoadingTipsRoleDataParam.EquipQuality += (int)(GameDBRuntime.GetItemDesc(equip.Id)?.Quality ?? ItemQuality.Init);
			}
			fLoadingTipsRoleDataParam.CompletedTaskList = RoleData.RoleCs.Task.QuestList.Select((ReadOnlyQuestStageOne item) => item.Id).ToList();
			foreach (ReadOnlyRoleItem item in RoleData.RoleCs.Bag.ItemList)
			{
				if (item.Num != 0)
				{
					fLoadingTipsRoleDataParam.PlayerItemList.Add(item.ItemId);
				}
			}
			foreach (int spell in RoleData.RoleCs.Actor.Progress.SpellList)
			{
				fLoadingTipsRoleDataParam.PlayerItemList.Add(spell);
			}
			foreach (ReadOnlyLegacyAbility legacy in RoleData.RoleCs.Actor.Progress.LegacyList)
			{
				fLoadingTipsRoleDataParam.PlayerItemList.Add(legacy.LegacyId);
			}
			foreach (ReadOnlyTalentOne talen in RoleData.RoleCs.Actor.Progress.TalenList)
			{
				fLoadingTipsRoleDataParam.TalentList.Add(talen.Id);
			}
			foreach (int interactionFunc in RoleData.RoleCs.Interaction.InteractionFuncList)
			{
				fLoadingTipsRoleDataParam.FuncIdList.Add(interactionFunc);
			}
			return fLoadingTipsRoleDataParam;
		}
	}

	public FLoadingTipsRuntimeParam RuntimeParam { get; set; }

	public override bool bTickEnabled => true;

	public override void OnInit()
	{
		InstanceRef = new WeakReference<BGW_LoadingTipsMgr>(this);
		_loadingScreenTimeTracker = new FLoadingScreenTimeTracker(BGWGameInstanceCS.Get(this));
		LoadingColorAlphaTracker = new FLoadingColorAlphaTracker(this);
		_dreamTeleportData = RequireReadonlyGameInstanceData<b1.IBIC_DreamTeleportData, BIC_DreamTeleportData>();
		BattleParam = new FLoadingTipsBattleParam();
		RuntimeParam = new FLoadingTipsRuntimeParam();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_BGW_PlayerActorDeadForLoadingTips = (BGW_EventCollection.Del_BGW_PlayerActorDead)Delegate.Combine(bGW_EventCollection.Evt_BGW_PlayerActorDeadForLoadingTips, new BGW_EventCollection.Del_BGW_PlayerActorDead(OnPlayerActorDeadForLoadingTips));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_BGW_PreFetchLoadingTips = (BGW_EventCollection.Del_BGW_PreFecthLoadingTips)Delegate.Combine(bGW_EventCollection2.Evt_BGW_PreFetchLoadingTips, new BGW_EventCollection.Del_BGW_PreFecthLoadingTips(OnPreFetchLoadingTips));
		BGW_EventCollection.Get(this).Evt_BGW_PostFecthLoadingTipsFinish = OnPostFetchLoadingTipsFinish;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		_loadingScreenTimeTracker.OnTick(DeltaTime);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		InstanceRef = null;
		_loadingScreenPreviewCache?.Dispose();
	}

	public void ToggleLoadingScreenPreview()
	{
		LoadingScreenPreview.Toggle();
	}

	public void OpenLoadingScreenPreview()
	{
		LoadingScreenPreview.Open();
	}

	public void CloseLoadingScreenPreview()
	{
		LoadingScreenPreview.Close();
	}

	public int GetLoadingScreenPreviewTipsCount()
	{
		return LoadingScreenPreview.GetCount();
	}

	public void SwitchLoadingScreenPreview()
	{
		LoadingScreenPreview.SetNext();
	}

	private void OnPlayerActorDeadForLoadingTips(FLoadingTipsPlayerDeadInfo PlayerDeadInfo)
	{
		PlayerDeadInfo.SetBattleParamData(BattleParam);
	}

	public static BGW_LoadingTipsMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_LoadingTipsMgr>(WorldContext);
	}

	public void OnPreFetchLoadingTips(FLoadingTipsInfo LoadingTipsInfo)
	{
		LoadingTipsInfo.SetBattleParamData(BattleParam);
		_cachedImageIdList = new List<int>();
		if (_dreamTeleportData.TryGetTeleportTipsId(out var TeleportLoadingTips))
		{
			RegisterLoadingTips(TeleportLoadingTips.Select(GameDBRuntime.GetLoadingTipsDesc));
		}
		else
		{
			List<LoadingTipsDesc> loadingTipsDescEnumerable = LoadingTipsRandomMgr.FetchLoadingTipsV2(BattleParam, RoleDataParam, RuntimeParam);
			RegisterLoadingTips(loadingTipsDescEnumerable);
		}
		string path = "Texture2D'/Game/00MainHZ/UIDev/Loading/LoadTips/MASK_loadingtips.MASK_loadingtips'";
		UTexture2D maskTexture = BGW_PreloadAssetMgr.Get(this).RequestSyncLoadForUIResource<UTexture2D>(path, EUIResourceLoadType.NoCache);
		BGWGameInstanceCS.Get(this).RegisterLoadingTipsMask(maskTexture);
		void RegisterLoadingTips(IEnumerable<LoadingTipsDesc> LoadingTipsDescEnumerable)
		{
			List<LoadingTipsDesc> list = LoadingTipsDescEnumerable.ToList();
			int num = list.Count();
			foreach (LoadingTipsDesc item in list)
			{
				if (item != null)
				{
					UTexture2D uTexture2D = ((num == 1) ? LoadingTipsInfo.GetImageObjectById(item.ImageId) : LoadingTipsInfo.GetImageObj(item.ImageId));
					if (uTexture2D != null)
					{
						BGWGameInstanceCS.Get(this).RegisterLoadingTipsInfo(new b1.Plugins.AsyncLoadingScreen.FLoadingTipsInfo
						{
							DurTime = item.KeepTime,
							ImageObj = uTexture2D,
							Tips = item.Content.ToFTextFillPre("LoadingTips_Desc"),
							Title = item.Title.ToFText(),
							TipsId = item.Id
						});
						if (!_cachedImageIdList.Contains(item.ImageId))
						{
							_cachedImageIdList.Add(item.ImageId);
						}
					}
				}
			}
		}
	}

	public void OnPostFetchLoadingTipsFinish()
	{
		RuntimeParam.LastUsedLoadingTips = BGWGameInstanceCS.Get(this).GetLastUseTips();
		BattleParam.Reset();
	}

	public void DumpWidgetMaskTexture(ref FBossRushInfo BossRushInfo)
	{
		if (_bossRushWidgetToMaskDict.TryGetValue(BossRushInfo.LoadingType, out var value))
		{
			BossRushInfo.Masks = value.ToDictionary((KeyValuePair<string, string> Pair) => new FName(Pair.Key), (KeyValuePair<string, string> Pair) => BGW_PreloadAssetMgr.Get(this).RequestSyncLoadForUIResource<UTexture2D>(Pair.Value, EUIResourceLoadType.NoCache));
		}
	}

	public FLoadingTipsRoleDataParam TraitRoleDataParam()
	{
		return RoleDataParam;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_LoadingTipsMgr");
	}

	static BGW_LoadingTipsMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_LoadingTipsMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_LoadingTipsMgr));
	}
}
