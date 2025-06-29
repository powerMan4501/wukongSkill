using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.GSInput;
using b1.UI.Comm;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutBaseCS")]
public class BI_ShortcutBaseCS : BUI_StateWidget
{
	private UCanvasPanel NormalCon;

	private UImage ImgIcon;

	private UMaterialInstanceDynamic MIIcon;

	private UWidgetAnimation AnimReady;

	private UWidgetAnimation AnimCosted;

	private UWidgetAnimation AnimNSItemHide;

	private UWidgetAnimation AnimNSSkillHide;

	private UWidgetAnimation AnimNSAWeaponHide;

	private DS_IBUC_AttrContainer AttrContainer;

	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private B1GSUIActorMgr UIActorMgr;

	private int BaseID;

	private bool IsTransSpell;

	private bool ChangeIcon;

	private float CDTimePercent;

	private bool IsEnergyFullAnim;

	private bool IsPassive;

	public List<UImage> SyncImgList = new List<UImage>();

	public bool IsSelectItem;

	private int BindIdx;

	private int NumChangeBindIdx;

	private int GSStatID;

	private EnShortcutType CurShortcutType;

	private static bool ShowInputType_IsValid;

	private static int ShowInputType_Offset;

	private static FFieldAddress ShowInputType_PropertyAddress;

	private static bool ShortcutType_IsValid;

	private static int ShortcutType_Offset;

	private static FFieldAddress ShortcutType_PropertyAddress;

	private static bool CurPosIdx_IsValid;

	private static int CurPosIdx_Offset;

	[BlueprintReadWrite]
	[Category("GSProperty")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("在哪种输入类型")]
	[USharpPath("/Script/b1-Managed.BI_ShortcutBaseCS:ShowInputType")]
	public EGSInputType ShowInputType
	{
		get
		{
			CheckDestroyed();
			if (!ShowInputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutBaseCS:ShowInputType");
				return EGSInputType.None;
			}
			return EnumMarshaler<EGSInputType>.FromNative(IntPtr.Add(base.Address, ShowInputType_Offset), 0, ShowInputType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowInputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutBaseCS:ShowInputType");
			}
			else
			{
				EnumMarshaler<EGSInputType>.ToNative(IntPtr.Add(base.Address, ShowInputType_Offset), 0, ShowInputType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[Tooltip("快捷类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_ShortcutBaseCS:ShortcutType")]
	public EnShortcutType ShortcutType
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutBaseCS:ShortcutType");
				return EnShortcutType.INIT;
			}
			return EnumMarshaler<EnShortcutType>.FromNative(IntPtr.Add(base.Address, ShortcutType_Offset), 0, ShortcutType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutBaseCS:ShortcutType");
			}
			else
			{
				EnumMarshaler<EnShortcutType>.ToNative(IntPtr.Add(base.Address, ShortcutType_Offset), 0, ShortcutType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Tooltip("PosIdx")]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BI_ShortcutBaseCS:CurPosIdx")]
	public int CurPosIdx
	{
		get
		{
			CheckDestroyed();
			if (!CurPosIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutBaseCS:CurPosIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurPosIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurPosIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutBaseCS:CurPosIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurPosIdx_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr?.GetMDSBattleMain();
		UIActorMgr = B1GSUIActorMgr.Get(this);
		NormalCon = FindChildWidget("StNormal") as UCanvasPanel;
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		MIIcon = ImgIcon.GetDynamicMaterial();
		MIIcon.SetScalarParameterValue(B1GlobalFNames.Percent, 1f);
		AnimReady = FindWidgetAnimation("AnimReady");
		AnimCosted = FindWidgetAnimation("AnimCosted");
		AnimNSItemHide = FindWidgetAnimation("AnimUINSItem_Hide");
		AnimNSSkillHide = FindWidgetAnimation("AnimUINSSkill_Hide");
		AnimNSAWeaponHide = FindWidgetAnimation("AnimUINSAWeapon_Hide");
		CurShortcutType = ShortcutType;
		InitEventBind(CurShortcutType, CurShortcutType);
		UpdateIconType(IsForce: true);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_TriggerShortcut += new Del_BGS_BoolInt(OnTriggerShortcut);
		}
		GSStatID = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_ShortcutBaseCS");
	}

	public void OnInit(EGSInputType _ShowInputType, EnShortcutType _ShortcutType, int _CurPosIdx)
	{
		InitEventBind(CurShortcutType, _ShortcutType);
		ShowInputType = _ShowInputType;
		ShortcutType = _ShortcutType;
		CurShortcutType = _ShortcutType;
		CurPosIdx = _CurPosIdx;
	}

	public void OnChangeShortcutType(EnShortcutType _ShortcutType)
	{
		InitEventBind(CurShortcutType, _ShortcutType);
		ShortcutType = _ShortcutType;
		CurShortcutType = _ShortcutType;
	}

	private void EventUnbind(EnShortcutType LastType)
	{
		switch (LastType)
		{
		case EnShortcutType.SPELL:
			if (BattleMainData.ShortcutSpellList[CurPosIdx] == SpellType.BianShen)
			{
				UIActorMgr.GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor)?.UnBindFloatAttrsOnSetIdxValue(BindIdx, OnBindEnergyChange);
			}
			break;
		case EnShortcutType.INIT:
		case EnShortcutType.ITEM:
		case EnShortcutType.TRANSSPELL:
			break;
		}
	}

	private void InitEventBind(EnShortcutType LastType, EnShortcutType CurType)
	{
		if (LastType != CurType)
		{
			EventUnbind(LastType);
		}
		IsTransSpell = false;
		switch (CurType)
		{
		case EnShortcutType.SPELL:
			if (BattleMainData.ShortcutSpellList[CurPosIdx] == SpellType.BianShen)
			{
				IsTransSpell = true;
				AttrContainer = UIActorMgr.GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
				if (AttrContainer != null)
				{
					OnEnergyChange(EBGUAttrFloat.CurEnergy, AttrContainer.GetFloatValue(EBGUAttrFloat.CurEnergy), AttrContainer.GetFloatValue(EBGUAttrFloat.CurEnergy));
					BindIdx = AttrContainer.BindFloatAttrsOnSetIdxValue(OnBindEnergyChange);
				}
			}
			break;
		case EnShortcutType.INIT:
		case EnShortcutType.ITEM:
		case EnShortcutType.TRANSSPELL:
			break;
		}
	}

	protected override void OnSwitchState(WidgetUIStat State)
	{
		base.OnSwitchState(State);
		UpdateSyncImage();
		StopNSAnim();
	}

	protected override void OnForbidStateChange(bool IsForbid)
	{
		base.OnForbidStateChange(IsForbid);
		UpdateSyncImage();
		StopNSAnim();
	}

	public void UpdateSyncImage()
	{
		bool flag = !IsDisable && !IsForbid && GetCurState() == WidgetUIStat.NorReady;
		foreach (UImage syncImg in SyncImgList)
		{
			if (!(syncImg == null))
			{
				UMaterialInstanceDynamic dynamicMaterial = syncImg.GetDynamicMaterial();
				if (dynamicMaterial != null)
				{
					dynamicMaterial.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_BlockState, flag ? 0f : 1f);
				}
			}
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(GSStatID);
		}
		base.OnUIGSInnerTickImpl(InDeltaTime);
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		TickItemState();
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		TickSkillState();
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		TickSpellCD(InDeltaTime);
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
	}

	private void TickItemState()
	{
		if (CurShortcutType == EnShortcutType.ITEM && BaseID != 0 && BattleMainInfoData.GetUseItemInfo(out var UseItemInfo))
		{
			SwitchState(UseItemInfo.IsDisabled);
		}
	}

	private void TickSkillState()
	{
		if ((CurShortcutType != EnShortcutType.SPELL && CurShortcutType != EnShortcutType.TRANSSPELL) || BaseID == 0)
		{
			return;
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		FUIMagicSpellInfo MagicSpellInfo;
		bool magicSpellInfo = BattleMainInfoData.GetMagicSpellInfo(BaseID, out MagicSpellInfo);
		_ = DebugConfig.UITickProfileLevel;
		_ = 2;
		if (magicSpellInfo)
		{
			_ = DebugConfig.UITickProfileLevel;
			_ = 2;
			SetDisable(MagicSpellInfo.IsDisabled);
			_ = DebugConfig.UITickProfileLevel;
			_ = 2;
			_ = DebugConfig.UITickProfileLevel;
			_ = 2;
			SetLockState(MagicSpellInfo.IsLocked);
			_ = DebugConfig.UITickProfileLevel;
			_ = 2;
			CDTimePercent = MagicSpellInfo.CDTimePercent;
			if (CDTimePercent > 0f && GetCurState() != WidgetUIStat.NorInCD && GetCurState() != WidgetUIStat.LockInCD)
			{
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
				BattleMainData.TriggerShowState(EnMainShowState.SHOW);
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
				SwitchState(IsLock ? WidgetUIStat.LockInCD : WidgetUIStat.NorInCD);
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
			}
		}
		if (CurShortcutType == EnShortcutType.SPELL)
		{
			SetForbidState(MagicSpellInfo.IsForbid);
		}
	}

	private void TickSpellCD(float DeltaTime)
	{
		if ((GetCurState() != WidgetUIStat.NorInCD && GetCurState() != WidgetUIStat.LockInCD) || (CurShortcutType != EnShortcutType.SPELL && CurShortcutType != EnShortcutType.TRANSSPELL) || IsTransSpell)
		{
			return;
		}
		if (IsAnimationPlaying(AnimReady))
		{
			StopAnimation(AnimReady);
		}
		if (CDTimePercent == 0f)
		{
			if (IsCanPerform())
			{
				UIMgr.PlayUISound("EVT_hud_player_fashu_full");
			}
			MIIcon = ImgIcon.GetDynamicMaterial();
			MIIcon.SetScalarParameterValue(B1GlobalFNames.Percent, 1f);
			if (IsLock)
			{
				SwitchState(WidgetUIStat.LockReady);
				return;
			}
			if (IsCanPerform())
			{
				PlayWidgetAnimation(AnimReady);
			}
			SwitchState(WidgetUIStat.NorReady);
		}
		else
		{
			MIIcon = ImgIcon.GetDynamicMaterial();
			MIIcon.SetScalarParameterValue(B1GlobalFNames.Percent, 1f - CDTimePercent);
		}
	}

	public void OnShowState(bool IsShow)
	{
	}

	public void UpdateNormal(int baseID)
	{
		IsPassive = false;
		ResetState();
		BaseID = baseID;
		if (BaseID == 0)
		{
			SwitchState(WidgetUIStat.Empty);
		}
		else
		{
			if (IsTransSpell)
			{
				if (CurShortcutType == EnShortcutType.SPELL)
				{
					if (AttrContainer != null)
					{
						float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.CurEnergy);
						float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.TransEnergyMax);
						if (floatValue < floatValue2)
						{
							SwitchState(WidgetUIStat.NorInCD);
						}
						else
						{
							SwitchState(WidgetUIStat.NorReady);
						}
					}
				}
				else
				{
					SwitchState(WidgetUIStat.NorReady);
				}
			}
			else
			{
				SwitchState(WidgetUIStat.NorReady);
			}
			UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetItemIconGPath(BaseID));
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(BaseID);
			if (spellDesc != null)
			{
				IsPassive = spellDesc.IsPassive == YesNoType.Yes;
			}
		}
		UpdateIconType();
	}

	private void OnBindEnergyChange(int AttrId, float OldValue, float NewValue)
	{
		if (AttrId == 188)
		{
			OnEnergyChange(EBGUAttrFloat.CurEnergy, OldValue, NewValue);
		}
	}

	public void ForceUpdateEnergy()
	{
		if (AttrContainer != null)
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.CurEnergy);
			OnEnergyChange(EBGUAttrFloat.CurEnergy, floatValue, floatValue);
		}
	}

	private void OnEnergyChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (BaseID == 0)
		{
			return;
		}
		DS_IBUC_AttrContainer battleData = UIActorMgr.GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		if (battleData == null || battleData.GetFloatValue(EBGUAttrFloat.TransEnergyMax) <= 0f)
		{
			return;
		}
		float value = NewValue / battleData.GetFloatValue(EBGUAttrFloat.TransEnergyMax);
		MIIcon = ImgIcon.GetDynamicMaterial();
		MIIcon?.SetScalarParameterValue(B1GlobalFNames.Percent, value);
		if (IsAnimationPlaying(AnimReady))
		{
			StopAnimation(AnimReady);
		}
		float floatValue = battleData.GetFloatValue(EBGUAttrFloat.TransEnergyMax);
		if (NewValue >= floatValue)
		{
			SwitchState(WidgetUIStat.NorReady);
			if (IsCanPerform())
			{
				PlayWidgetAnimation(AnimReady);
				UIMgr.PlayUISound("EVT_hud_player_bianshen_full");
			}
		}
		else
		{
			IsEnergyFullAnim = false;
		}
		if (GetCurState() != WidgetUIStat.NorInCD && GetCurState() != WidgetUIStat.LockInCD && NewValue < floatValue)
		{
			SwitchState(WidgetUIStat.NorInCD);
		}
	}

	private void EnergyFull()
	{
		SwitchState(WidgetUIStat.NorReady);
		if (!IsDisable && !IsEnergyFullAnim)
		{
			PlayWidgetAnimation(AnimReady);
			IsEnergyFullAnim = true;
		}
	}

	private void StopNSAnim()
	{
		if (IsAnimationPlaying(AnimNSItemHide))
		{
			StopAnimation(AnimNSItemHide);
		}
		if (IsAnimationPlaying(AnimNSSkillHide))
		{
			StopAnimation(AnimNSSkillHide);
		}
		if (IsAnimationPlaying(AnimNSAWeaponHide))
		{
			StopAnimation(AnimNSAWeaponHide);
		}
	}

	public void PlayNSItemHideAnim()
	{
		PlayWidgetAnimation(AnimNSItemHide);
	}

	public void PlayNSSkillHideAnim()
	{
		if (BattleMainData.ShortcutSpellList[CurPosIdx] == SpellType.BianShen)
		{
			PlayWidgetAnimation(AnimNSAWeaponHide);
			UIMgr.PlayUISound("EVT_ui_hud_hint_bianshen_firstget");
		}
		else
		{
			PlayWidgetAnimation(AnimNSSkillHide);
		}
	}

	public void SetDisable(bool IsDisable)
	{
		if (base.IsDisable != IsDisable)
		{
			SwitchState(IsDisable);
		}
	}

	public bool GetIsDisable()
	{
		return IsDisable;
	}

	public void SetLockState(bool IsLock)
	{
		if (base.IsLock != IsLock)
		{
			SwitchLockState(IsLock);
		}
	}

	private void OnTriggerShortcut(bool IsSpell, int PosIdx)
	{
		if (IsSpell)
		{
			if ((CurShortcutType != EnShortcutType.SPELL && CurShortcutType != EnShortcutType.TRANSSPELL) || (uint)BattleMainData.ShortcutSpellList[CurPosIdx] != (byte)PosIdx || !IsCanPerform())
			{
				return;
			}
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(BaseID);
			if (spellDesc != null && spellDesc.IsPassive != YesNoType.Yes && !IsDisable && !IsForbid)
			{
				PlayWidgetAnimation(AnimCosted);
				if (GetCurState() != WidgetUIStat.NorReady)
				{
					UIMgr.PlayUISound("EVT_ui_hud_hint_fashu_nocd");
				}
			}
		}
		else if (CurShortcutType == EnShortcutType.ITEM && CurPosIdx == PosIdx && IsCanPerform() && !IsDisable && !IsForbid)
		{
			PlayWidgetAnimation(AnimCosted);
			if (GetCurState() != WidgetUIStat.NorReady && IsSelectItem)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_fashu_item_unfull");
			}
		}
	}

	public int GetBaseID()
	{
		return BaseID;
	}

	private bool IsCanPerform()
	{
		if (BattleMainData.GetIsActive())
		{
			return ShowInputType == BGW_EnhancedInputMgrV2.GetCurrentInputType();
		}
		return false;
	}

	private void UpdateIconType(bool IsForce = false)
	{
		GSAnimKeyToState("AKBIconType", IsPassive ? "Passive" : "Default", IsForce);
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		EventUnbind(CurShortcutType);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_TriggerShortcut -= new Del_BGS_BoolInt(OnTriggerShortcut);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutBaseCS");
		NativeReflection.GetPropertyRef(ref ShowInputType_PropertyAddress, unrealStruct, "ShowInputType");
		ShowInputType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowInputType");
		ShowInputType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowInputType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ShortcutType_PropertyAddress, unrealStruct, "ShortcutType");
		ShortcutType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutType");
		ShortcutType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutType", Classes.FEnumProperty);
		CurPosIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurPosIdx");
		CurPosIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurPosIdx", Classes.FIntProperty);
	}

	static BI_ShortcutBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutBaseCS));
	}
}
