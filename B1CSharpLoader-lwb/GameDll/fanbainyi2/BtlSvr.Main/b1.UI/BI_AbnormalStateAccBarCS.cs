using System;
using b1.Plugins.NiagaraUIRenderer;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBarCS")]
public class BI_AbnormalStateAccBarCS : BUI_Widget
{
	private enum ShowAnimState
	{
		Min,
		Show,
		Full,
		Clear
	}

	private BGW_UIMgr UIMgr;

	private BI_ProgBarCS ProgBar;

	private UWidgetAnimation AccBar_ShowAnim;

	private UWidgetAnimation AccBar_FullAnim;

	private UWidgetAnimation AccBar_ClearAnim;

	private float CurAccValue;

	private float CurMaxAccValue;

	private EBGUAttrFloat AttrID;

	private EBGUAttrFloat AttrMaxID;

	private bool IsFull;

	private UNiagaraSystemWidget FullFX;

	private DS_IBUC_AttrContainer AttrContainer;

	private MDSBattleMain BattleMainData;

	private int AttrIDBindIdx;

	private int AttrMaxIDBindIdx;

	private ShowAnimState AnimState;

	private static bool AbnormalStateType_IsValid;

	private static int AbnormalStateType_Offset;

	private static FFieldAddress AbnormalStateType_PropertyAddress;

	[UProperty]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBarCS:AbnormalStateType")]
	public EAbnormalStateType AbnormalStateType
	{
		get
		{
			CheckDestroyed();
			if (!AbnormalStateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBarCS:AbnormalStateType");
				return EAbnormalStateType.None;
			}
			return EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(base.Address, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbnormalStateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBarCS:AbnormalStateType");
			}
			else
			{
				EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(base.Address, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr?.GetMDSBattleMain();
		AccBar_ShowAnim = FindWidgetAnimation("AccBar_ShowAnim");
		AccBar_FullAnim = FindWidgetAnimation("AccBar_FullAnim");
		AccBar_ClearAnim = FindWidgetAnimation("AccBar_ClearAnim");
		string widgetName = "";
		switch (AbnormalStateType)
		{
		case EAbnormalStateType.Abnormal_Freeze:
			widgetName = "UINS_Debuff_Core_Freeze";
			AttrID = EBGUAttrFloat.FreezeAbnormalAcc;
			AttrMaxID = EBGUAttrFloat.FreezeAbnormalAccMax;
			break;
		case EAbnormalStateType.Abnormal_Burn:
			widgetName = "UINS_Debuff_Core_Burn";
			AttrID = EBGUAttrFloat.BurnAbnormalAcc;
			AttrMaxID = EBGUAttrFloat.BurnAbnormalAccMax;
			break;
		case EAbnormalStateType.Abnormal_Poison:
			widgetName = "UINS_Debuff_Core_Poison";
			AttrID = EBGUAttrFloat.PoisonAbnormalAcc;
			AttrMaxID = EBGUAttrFloat.PoisonAbnormalAccMax;
			break;
		case EAbnormalStateType.Abnormal_Thunder:
			widgetName = "UINS_Debuff_Core_Thunder";
			AttrID = EBGUAttrFloat.ThunderAbnormalAcc;
			AttrMaxID = EBGUAttrFloat.ThunderAbnormalAccMax;
			break;
		case EAbnormalStateType.Abnormal_Yin:
			widgetName = "UINS_Debuff_Core_Yin";
			AttrID = EBGUAttrFloat.YinAbnormalAcc;
			AttrMaxID = EBGUAttrFloat.YinAbnormalAccMax;
			break;
		case EAbnormalStateType.Abnormal_Yang:
			widgetName = "UINS_Debuff_Core_Yang";
			AttrID = EBGUAttrFloat.YangAbnormalAcc;
			AttrMaxID = EBGUAttrFloat.YangAbnormalAccMax;
			break;
		}
		FullFX = FindChildWidget(widgetName) as UNiagaraSystemWidget;
		FullFX.SetRenderOpacity(1f);
		ProgBar = FindChildWidget("BI_ProgBar") as BI_ProgBarCS;
		DSAttrProgBar dSAttrProgBar = new DSAttrProgBar(this, AttrID, AttrMaxID);
		dSAttrProgBar.Init(B1ActorTag.CurPlayerActor);
		ProgBar.InitDataStore(dSAttrProgBar);
		AttrContainer = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		if (AttrContainer != null)
		{
			InitValue(AttrContainer.GetFloatValue(AttrID), AttrContainer.GetFloatValue(AttrMaxID));
			AttrIDBindIdx = AttrContainer.BindFloatAttrsOnSetIdxValue(OnBindOnSetIdxValueChange);
		}
	}

	private void InitValue(float CurValue, float CurMaxValue)
	{
		CurAccValue = CurValue;
		CurMaxAccValue = CurMaxValue;
	}

	private void ChangeValue(EBGUAttrFloat EBGUAttrFloat, float RealOrgValue, float RealNewValue)
	{
		BattleMainData.TriggerShowState(EnMainShowState.SHOW);
		float num = RealOrgValue / CurMaxAccValue;
		float num2 = RealNewValue / CurMaxAccValue;
		CurAccValue = RealNewValue;
		if (num2 > 0f && num2 < 1f)
		{
			if (AnimState != ShowAnimState.Show)
			{
				AnimState = ShowAnimState.Show;
				PlayAnim_Show();
			}
		}
		else if (num2 >= 1f)
		{
			AnimState = ShowAnimState.Full;
			ProgBar.SetBlockChange(IsBlock: true);
		}
		else if (num2 <= 0f && num > 0f && num < 1f)
		{
			AnimState = ShowAnimState.Clear;
		}
	}

	private void ChangeMaxValue(EBGUAttrFloat EBGUAttrFloat, float RealOrgValue, float RealNewValue)
	{
		CurMaxAccValue = RealNewValue;
	}

	private void OnBindOnSetIdxValueChange(int AttrId, float OldValue, float NewValue)
	{
		if (AttrId == (int)AttrID)
		{
			ChangeValue(AttrID, OldValue, NewValue);
		}
		if (AttrId == (int)AttrMaxID)
		{
			ChangeMaxValue(AttrMaxID, OldValue, NewValue);
		}
	}

	private void SetBarPercent(UMaterialInstanceDynamic BarMatInst, float CurValue, float CurMaxValue)
	{
		if (!(BarMatInst == null))
		{
			float num = CurValue / CurMaxValue;
			if (!(num <= 0f) || !IsFull)
			{
				BarMatInst?.SetScalarParameterValue(B1Names.GSMaskMatPercent, num);
			}
		}
	}

	private void PlayAnim_Show()
	{
		IsFull = false;
		if (!(AccBar_ShowAnim == null))
		{
			if (IsAnimationPlaying(AccBar_ClearAnim))
			{
				StopAnimation(AccBar_ClearAnim);
			}
			if (IsAnimationPlaying(AccBar_FullAnim))
			{
				StopAnimation(AccBar_FullAnim);
			}
			PlayWidgetAnimation(AccBar_ShowAnim);
		}
	}

	private void PlayAnim_Full()
	{
		IsFull = true;
		if (!(AccBar_FullAnim == null))
		{
			PlayWidgetAnimation(AccBar_FullAnim);
			FullFX?.GSPlayFX();
			AnimState = ShowAnimState.Min;
		}
	}

	private void PlayAnim_Clear()
	{
		IsFull = false;
		if (!(AccBar_ClearAnim == null))
		{
			PlayWidgetAnimation(AccBar_ClearAnim);
			AnimState = ShowAnimState.Min;
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (AnimState != ShowAnimState.Min && !IsPlayingAnimation())
		{
			switch (AnimState)
			{
			case ShowAnimState.Full:
				PlayAnim_Full();
				ProgBar.SetBlockChange(IsBlock: false);
				break;
			case ShowAnimState.Clear:
				PlayAnim_Clear();
				break;
			case ShowAnimState.Min:
			case ShowAnimState.Show:
				break;
			}
		}
	}

	public bool GetCanTick()
	{
		return AnimState != ShowAnimState.Min;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		if (AttrContainer != null)
		{
			AttrContainer.UnBindFloatAttrsOnSetIdxValue(AttrIDBindIdx, OnBindOnSetIdxValueChange);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_AbnormalStateAccBarCS");
		NativeReflection.GetPropertyRef(ref AbnormalStateType_PropertyAddress, unrealStruct, "AbnormalStateType");
		AbnormalStateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnormalStateType");
		AbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnormalStateType", Classes.FEnumProperty);
	}

	static BI_AbnormalStateAccBarCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_AbnormalStateAccBarCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_AbnormalStateAccBarCS));
	}
}
