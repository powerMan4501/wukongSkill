using System;
using B1UI.GSUI;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransCS")]
public class BI_TransCS : BUI_Widget
{
	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private DSTransCS DataStore;

	private UCanvasPanel ShortcutSpellCon;

	private BI_ShortcutSpellCS ShortcutSpell;

	private UCanvasPanel HpCon;

	private BI_ProgBarCS EnergyProg;

	private BI_HpProgBarCS HpProg;

	private UCanvasPanel TransStyleCon;

	private BI_TransStyleCS TransStyle;

	private UCanvasPanel TransStateRoot;

	private UCanvasPanel MKStateRoot;

	private UImage ImgHPBar;

	private int BindIdx;

	private int BindIdx2;

	private DS_IBUC_AttrContainer AttrContainer;

	private DS_IBPC_PlayerTagData PlayerTagData;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr.GetMDSBattleMain();
		HpProg = FindChildWidget("HpBar") as BI_HpProgBarCS;
		EnergyProg = FindChildWidget("EnergyBar") as BI_ProgBarCS;
		DataStore = new DSTransCS(this, HpProg.UseAbnormalFx);
		HpCon = FindChildWidget("HpCon") as UCanvasPanel;
		HpProg.InitDataStore(DataStore.HpProgBar);
		EnergyProg.InitDataStore(DataStore.EnergyProg);
		ShortcutSpellCon = FindChildWidget("ShortcutSpellCon") as UCanvasPanel;
		ShortcutSpell = FindChildWidget("BI_ShortcutSkill") as BI_ShortcutSpellCS;
		ShortcutSpell.OnChangeShortcutType(EnShortcutType.TRANSSPELL);
		TransStateRoot = FindChildWidget("TransStateRoot") as UCanvasPanel;
		MKStateRoot = FindChildWidget("MKStateRoot") as UCanvasPanel;
		ImgHPBar = FindChildWidget("ImgHPBar") as UImage;
		TransStyleCon = FindChildWidget("TransStyleCon") as UCanvasPanel;
		AttrContainer = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		if (AttrContainer != null)
		{
			BindIdx = AttrContainer.BindFloatAttrsOnSetIdxValue(OnBindEnergyChange);
		}
		PlayerTagData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_PlayerTagData>(B1ActorTag.LocalPlayerState);
		DS_IBUC_PlayerSpellConfData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor);
		if (battleData != null)
		{
			BindIdx2 = battleData.BindCurrentTransFormIDChange(CurrentTransFormIDChange);
		}
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow)
		{
			DS_IBUC_ConfigInfoData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_ConfigInfoData>(B1ActorTag.CurPlayerActor, IsNeedUpdate: true);
			DS_IBPC_TransData battleData2 = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_TransData>(B1ActorTag.LocalPlayerState);
			if (battleData != null && battleData2 != null)
			{
				int resID = battleData.ResID;
				HpCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
				UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgHPBar, GSUIResPathUtil.GetTransHPBarPath(resID));
				EnergyProg.UpdateActiveState(Active: true);
				ShortcutSpellCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
				TransStyle?.ActiveProg(IsActive: true);
				if (resID == GameDBRuntime.GetCommLogicCfgValue(CommCfgType.XuehouDefaultResid) && battleData2.IsPlotTrans())
				{
					EnergyProg.UpdateActiveState(Active: false);
					ShortcutSpellCon.SetVisibility(ESlateVisibility.Collapsed);
					TransStyle?.ActiveProg(IsActive: false);
				}
				else if (resID == GameDBRuntime.GetCommLogicCfgValue(CommCfgType.FtxdDefaultResid))
				{
					EnergyProg.UpdateActiveState(Active: false);
				}
				else if (resID == GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenDefaultResid))
				{
					HpCon.SetVisibility(ESlateVisibility.Collapsed);
					EnergyProg.UpdateActiveState(Active: false);
				}
			}
		}
		ShortcutSpell.OnShowState(IsShow);
		TransStyle?.OnShowState(IsShow);
		SetVisibility((!IsShow) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public void CheckResID(UObject WorldContext)
	{
		BGUCharacterCS bGUCharacterCS = UGameplayStatics.GetPlayerCharacter(WorldContext, 0) as BGUCharacterCS;
		if (bGUCharacterCS != null && DataStore.TransResId != bGUCharacterCS.GetResID())
		{
			UpdateTrans(bGUCharacterCS.GetResID());
		}
	}

	public void UpdateTrans(int ResID)
	{
		if (TransStyle != null)
		{
			TransStyle.DestroyUI();
		}
		TransStyle = UGSE_UMGFuncLib.CreateUserWidget(this, GSUIResPathUtil.GetTransStylePath(ResID)) as BI_TransStyleCS;
		if (!(TransStyle == null))
		{
			GSUIPanelSlotHelper.SetSlotToFullScreen(TransStyleCon.AddChild(TransStyle) as UCanvasPanelSlot);
			TransStyle.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			DataStore.TransResId = ResID;
			TransStyle?.OnShowState(IsShow: false);
		}
	}

	public int GetTransResID()
	{
		return DataStore.TransResId;
	}

	public void OnTriggerActive(bool IsActive)
	{
		if (ShortcutSpell != null)
		{
			ShortcutSpell.OnTriggerActive(IsActive);
		}
	}

	private void OnBindEnergyChange(int AttrId, float OldValue, float NewValue)
	{
		if (AttrId == 188)
		{
			OnEnergyChange(EBGUAttrFloat.CurEnergy, OldValue, NewValue);
		}
	}

	private void OnEnergyChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (AttrContainer != null && PlayerTagData != null)
		{
			if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			}
			else if (NewValue >= AttrContainer.GetFloatValue(EBGUAttrFloat.TransEnergyMax))
			{
				BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			}
		}
	}

	private void CurrentTransFormIDChange(int OldValue, int NewValue)
	{
		if (TransStyle != null && TransStyle.ResID == 22)
		{
			TransStyle.UpdateIcon(NewValue);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor)?.UnBindFloatAttrsOnSetIdxValue(BindIdx, OnBindEnergyChange);
		B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor)?.UnBindCurrentTransFormIDChange(BindIdx2, CurrentTransFormIDChange);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransCS");
	}

	static BI_TransCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransCS));
	}
}
