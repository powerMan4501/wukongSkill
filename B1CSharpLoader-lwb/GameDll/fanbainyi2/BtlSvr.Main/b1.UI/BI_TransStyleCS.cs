using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.GSMUICore.Event;
using b1.Plugins.NiagaraUIRenderer;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyleCS")]
public class BI_TransStyleCS : BUI_Widget
{
	private BGW_UIMgr UIMgr;

	protected MDSBattleMain BattleMainData;

	protected DS_IBUC_PotentialEnergyData PotentialEnergyData;

	protected DS_IBPC_BattleMainInfoData BattleMainInfoData;

	protected BI_TransProgCS TransProg;

	private UImage ImgIcon;

	private UMaterialInstanceDynamic MIFXRing;

	private UNiagaraSystemWidget NSSpark;

	protected int PELevel;

	protected UWidgetAnimation AnimStA;

	protected UWidgetAnimation AnimStB;

	protected UWidgetAnimation AnimStC;

	protected UWidgetAnimation AnimStD;

	protected UWidgetAnimation AnimGain;

	protected UWidgetAnimation AnimReset;

	protected UWidgetAnimation AnimFull;

	protected UWidgetAnimation AnimAct;

	protected UWidgetAnimation AnimReduce;

	protected bool InActiving;

	protected string CurState = "";

	private int BindIdx;

	private static bool ResID_IsValid;

	private static int ResID_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BI_TransStyleCS:ResID")]
	public int ResID
	{
		get
		{
			CheckDestroyed();
			if (!ResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TransStyleCS:ResID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ResID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TransStyleCS:ResID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ResID_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr?.GetMDSBattleMain();
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		UImage uImage = FindChildWidget("UIFX_Ring") as UImage;
		if (uImage != null)
		{
			MIFXRing = uImage.GetDynamicMaterial();
		}
		NSSpark = FindChildWidget("UINS_Spark") as UNiagaraSystemWidget;
		AnimStA = FindWidgetAnimation("StAnimA");
		AnimStB = FindWidgetAnimation("StAnimB");
		AnimStC = FindWidgetAnimation("StAnimC");
		AnimStD = FindWidgetAnimation("StAnimD");
		AnimGain = FindWidgetAnimation("AnimGain");
		AnimReset = FindWidgetAnimation("AnimReset");
		AnimFull = FindWidgetAnimation("AnimFull");
		AnimAct = FindWidgetAnimation("AnimAct");
		AnimReduce = FindWidgetAnimation("AnimReduce");
		TransProg = FindChildWidget("BI_TransProg") as BI_TransProgCS;
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		if (BattleMainInfoData != null)
		{
			GSBindProp<bool> state = BattleMainInfoData.State2;
			state.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(state.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnState2Change));
			GSBindProp<bool> state2 = BattleMainInfoData.State3;
			state2.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(state2.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnState3Change));
		}
	}

	public virtual void OnShowState(bool IsShow)
	{
		NSActive(IsShow);
		PELevel = 0;
		if (IsShow)
		{
			UMaterialParameterCollection uIFXMPC = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.UIFXMPC;
			if (uIFXMPC != null)
			{
				UMaterialLibrary.SetScalarParameterValue(this, uIFXMPC, B1GlobalFNames.GSMIParameter_WaveDash, 0f);
			}
			SwitchToState("StDefault");
			PotentialEnergyData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PotentialEnergyData>(B1ActorTag.CurPlayerActor);
			DS_IBUC_AttrContainer battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
			if (battleData != null)
			{
				BindIdx = battleData.BindFloatAttrsOnSetIdxValue(OnBindPevalueChange);
				OnPevalueChange(EBGUAttrFloat.Pevalue, 0f, battleData.GetFloatValue(EBGUAttrFloat.Pevalue));
			}
			GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
			if (actorEvt != null)
			{
				actorEvt.Evt_UnitCastSkillSuccess = (Del_UnitCastSkillSuccess)Delegate.Combine(actorEvt.Evt_UnitCastSkillSuccess, new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess));
			}
		}
		else
		{
			B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor)?.UnBindFloatAttrsOnSetIdxValue(BindIdx, OnBindPevalueChange);
			GSUIActorMgr.EvtClass actorEvt2 = B1GSUIActorMgr.Get(this).GetActorEvt(1);
			if (actorEvt2 != null)
			{
				actorEvt2.Evt_UnitCastSkillSuccess = (Del_UnitCastSkillSuccess)Delegate.Remove(actorEvt2.Evt_UnitCastSkillSuccess, new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess));
			}
			SwitchToState("StDefault");
		}
	}

	private void NSActive(bool IsActive)
	{
		if (IsActive)
		{
			NSSpark?.ActivateSystem(Reset: true);
		}
		else
		{
			NSSpark?.DeactivateSystem();
		}
		if (TransProg != null)
		{
			TransProg.NSActive(IsActive);
		}
	}

	protected virtual void OnBindPevalueChange(int AttrId, float OldValue, float NewValue)
	{
		if (AttrId == 191)
		{
			OnPevalueChange(EBGUAttrFloat.Pevalue, OldValue, NewValue);
		}
	}

	protected virtual void OnPevalueChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		PELevel = GetCurPELevel(NewValue);
		if (NewValue > OldValue)
		{
			PlayWidgetAnimation(AnimGain);
		}
		DS_IBUC_AttrContainer battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		if (battleData == null)
		{
			return;
		}
		float floatValue = battleData.GetFloatValue(EBGUAttrFloat.PevalueMax);
		if (NewValue >= floatValue)
		{
			if (ResID == 15 && BattleMainData.GetIsActive())
			{
				UIMgr?.PlayUISound("EVT_hud_player_bianshen_shuangtoushu_full");
			}
			SwitchToState("StA");
			StateAdd();
		}
		if (OldValue >= floatValue && !InActiving)
		{
			SwitchToState("StDefault");
		}
		if (NewValue <= 0f && !InActiving)
		{
			SwitchToState("StDefault");
		}
		if (TransProg != null)
		{
			TransProg.OnPevalueChange(OldValue, NewValue, NewValue / floatValue);
		}
	}

	protected void SwitchToState(string State)
	{
		if (!(CurState == State))
		{
			CurState = State;
			string animName = "";
			switch (State)
			{
			case "StDefault":
				animName = "AnimReset";
				break;
			case "StA":
				animName = "StAnimA";
				break;
			case "StB":
				animName = "StAnimB";
				break;
			case "StC":
				animName = "StAnimC";
				break;
			case "StD":
				animName = "StAnimD";
				break;
			}
			GSAnimKeyToState("AKBState", State);
			PlayAnimation(animName);
			if (TransProg != null)
			{
				TransProg.PlayAKBState(State);
				TransProg.PlayAnimation(animName);
			}
		}
	}

	protected void StateAdd()
	{
		UMaterialParameterCollection uIFXMPC = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.UIFXMPC;
		if (uIFXMPC != null)
		{
			float scalarParameterValue = UMaterialLibrary.GetScalarParameterValue(this, uIFXMPC, B1GlobalFNames.GSMIParameter_WaveDash);
			float toValue = scalarParameterValue + 0.68f;
			GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
			gSMUIEventSequence.AddEvent(new GSMUITweenSetMPCParam(this, uIFXMPC, B1GlobalFNames.GSMIParameter_WaveDash, scalarParameterValue, toValue, 0.85f));
			AppendGSMUIEvent(gSMUIEventSequence);
		}
	}

	protected virtual void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (InActiving)
		{
			return;
		}
		int num = BattleMainData.GetSpellIDBySkillID(MappingSkillID);
		if (num == 0)
		{
			return;
		}
		SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(num);
		if (spellDesc != null && spellDesc.Type == SpellType.QiShu && ResID == 15)
		{
			InActiving = true;
			GSAnimKeyToState("AKBState", "StB");
			PlayWidgetAnimation(AnimStB);
			StateAdd();
			if (TransProg != null)
			{
				TransProg.PlayAKBState("StB");
				TransProg.PlayAnimStB();
			}
		}
	}

	private void OnState2Change(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateState();
	}

	private void OnState3Change(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateState();
	}

	private void UpdateState()
	{
		if (InActiving)
		{
			if (!BattleMainInfoData.State2.Value && !BattleMainInfoData.State3.Value)
			{
				InActiving = false;
				float floatValue = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor).GetFloatValue(EBGUAttrFloat.Pevalue);
				OnPevalueChange(EBGUAttrFloat.Pevalue, floatValue, floatValue);
				ToStateDefault();
			}
			return;
		}
		if (BattleMainInfoData.State2.Value)
		{
			InActiving = true;
			ToState2();
		}
		if (BattleMainInfoData.State3.Value)
		{
			InActiving = true;
			ToState3();
		}
	}

	protected virtual void ToStateDefault()
	{
	}

	protected virtual void ToState2()
	{
	}

	protected virtual void ToState3()
	{
	}

	public void UpdateIcon(int TransformID)
	{
		string text = "";
		switch (TransformID)
		{
		case 1:
			text = "Texture2D'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerStyle/ICON_hudstyle_ling_frozen.ICON_hudstyle_ling_frozen'";
			break;
		case 2:
			text = "Texture2D'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerStyle/ICON_hudstyle_ling_thunder.ICON_hudstyle_ling_thunder'";
			break;
		case 3:
			text = "Texture2D'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerStyle/ICON_hudstyle_ling_fire.ICON_hudstyle_ling_fire'";
			break;
		case 4:
			text = "Texture2D'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerStyle/ICON_hudstyle_ling_posion.ICON_hudstyle_ling_posion'";
			break;
		}
		if (text.Length > 0)
		{
			UIAssetLoadHelper.AsyncLoadTexForImage(this, ImgIcon, text);
		}
	}

	protected int GetCurPELevel(float CurPEValue)
	{
		int num = 0;
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (item.Key > num && CurPEValue >= item.Value.LevelValue)
			{
				num = item.Key;
			}
		}
		return num;
	}

	protected bool IsPELevelValue(float CurPEValue)
	{
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (CurPEValue == item.Value.LevelValue)
			{
				return true;
			}
		}
		return false;
	}

	public void ActiveProg(bool IsActive)
	{
		if (TransProg != null)
		{
			TransProg.SetVisibility((!IsActive) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor)?.UnBindFloatAttrsOnSetIdxValue(BindIdx, OnBindPevalueChange);
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_UnitCastSkillSuccess = (Del_UnitCastSkillSuccess)Delegate.Remove(actorEvt.Evt_UnitCastSkillSuccess, new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess));
		}
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		if (BattleMainInfoData != null)
		{
			GSBindProp<bool> state = BattleMainInfoData.State2;
			state.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Remove(state.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnState2Change));
			GSBindProp<bool> state2 = BattleMainInfoData.State3;
			state2.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Remove(state2.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnState3Change));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyleCS");
		ResID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ResID", Classes.FIntProperty);
	}

	static BI_TransStyleCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyleCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyleCS));
	}
}
