using System;
using System.Collections.Generic;
using b1.GSMUI.GSWidget;
using b1.Plugins.NiagaraUIRenderer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_HpProgBarCS")]
public class BI_HpProgBarCS : BI_ProgBarCS
{
	private UImage ProgBG;

	private UMaterialInstanceDynamic ProcBGMat;

	private UWidget ShieldRoot;

	private IProcBar ProgShield;

	private UWidgetAnimation HurtPointAnim;

	private Dictionary<EAbnormalStateType, UNiagaraSystemWidget> HurtFX_Map = new Dictionary<EAbnormalStateType, UNiagaraSystemWidget>();

	private Dictionary<EAbnormalStateType, UNiagaraSystemWidget> EdgeFX_Map = new Dictionary<EAbnormalStateType, UNiagaraSystemWidget>();

	private Dictionary<EAbnormalStateType, UWidgetAnimation> AnimLoopDebuff_Map = new Dictionary<EAbnormalStateType, UWidgetAnimation>();

	private int BindShieldBarActivedIdx;

	private int BindShieldBarPercentIdx;

	private static bool UseAbnormalFx_IsValid;

	private static int UseAbnormalFx_Offset;

	private static FFieldAddress UseAbnormalFx_PropertyAddress;

	private static bool ZeroHide_IsValid;

	private static int ZeroHide_Offset;

	private static FFieldAddress ZeroHide_PropertyAddress;

	private static bool NeedBgPercent_IsValid;

	private static int NeedBgPercent_Offset;

	private static FFieldAddress NeedBgPercent_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[Tooltip("是否使用异常状态特效")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_HpProgBarCS:UseAbnormalFx")]
	public bool UseAbnormalFx
	{
		get
		{
			CheckDestroyed();
			if (!UseAbnormalFx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_HpProgBarCS:UseAbnormalFx");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAbnormalFx_Offset), 0, UseAbnormalFx_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAbnormalFx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_HpProgBarCS:UseAbnormalFx");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAbnormalFx_Offset), 0, UseAbnormalFx_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty")]
	[Tooltip("是否归0时隐藏")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_HpProgBarCS:ZeroHide")]
	public bool ZeroHide
	{
		get
		{
			CheckDestroyed();
			if (!ZeroHide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_HpProgBarCS:ZeroHide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ZeroHide_Offset), 0, ZeroHide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ZeroHide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_HpProgBarCS:ZeroHide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ZeroHide_Offset), 0, ZeroHide_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("是否需要背景进度")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_HpProgBarCS:NeedBgPercent")]
	public bool NeedBgPercent
	{
		get
		{
			CheckDestroyed();
			if (!NeedBgPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_HpProgBarCS:NeedBgPercent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedBgPercent_Offset), 0, NeedBgPercent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedBgPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_HpProgBarCS:NeedBgPercent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedBgPercent_Offset), 0, NeedBgPercent_PropertyAddress.Address, value);
			}
		}
	}

	protected DSHpProgBar HpDataStore => DataStore as DSHpProgBar;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ProgBG = FindChildWidget("ProgBG") as UImage;
		ProcBGMat = ProgBG?.GetDynamicMaterial();
		ShieldRoot = FindChildWidget("ShieldRoot");
		ProgShield = FindAndConstructIProcBar("ProgShield");
		if (ProgShield != null)
		{
			ProgShield.SetMaxValue(1f, IsImmediately: true);
			ProgShield.SetValue(1f, IsImmediately: true);
		}
		if (ProgShield is UWidget uWidget)
		{
			uWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		if (UseAbnormalFx)
		{
			UNiagaraSystemWidget value = FindChildWidget("UINS_HurtFX_Burn") as UNiagaraSystemWidget;
			UNiagaraSystemWidget value2 = FindChildWidget("UINS_HurtFX_Poison") as UNiagaraSystemWidget;
			UNiagaraSystemWidget value3 = FindChildWidget("UINS_HurtFX_Thunder") as UNiagaraSystemWidget;
			UNiagaraSystemWidget value4 = FindChildWidget("UINS_HurtPoint") as UNiagaraSystemWidget;
			HurtFX_Map.Add(EAbnormalStateType.Abnormal_Burn, value);
			HurtFX_Map.Add(EAbnormalStateType.Abnormal_Poison, value2);
			HurtFX_Map.Add(EAbnormalStateType.Abnormal_Thunder, value3);
			HurtFX_Map.Add(EAbnormalStateType.None, value4);
			UNiagaraSystemWidget value5 = FindChildWidget("UINS_DebuffEdge_Burn") as UNiagaraSystemWidget;
			UNiagaraSystemWidget value6 = FindChildWidget("UINS_DebuffEdge_Poison") as UNiagaraSystemWidget;
			UNiagaraSystemWidget value7 = FindChildWidget("UINS_DebuffEdge_Thunder") as UNiagaraSystemWidget;
			EdgeFX_Map.Add(EAbnormalStateType.Abnormal_Burn, value5);
			EdgeFX_Map.Add(EAbnormalStateType.Abnormal_Poison, value6);
			EdgeFX_Map.Add(EAbnormalStateType.Abnormal_Thunder, value7);
			UWidgetAnimation value8 = FindWidgetAnimation("AnimLoopDebuff_Burn");
			UWidgetAnimation value9 = FindWidgetAnimation("AnimLoopDebuff_Poison");
			UWidgetAnimation value10 = FindWidgetAnimation("AnimLoopDebuff_Thunder");
			AnimLoopDebuff_Map.Add(EAbnormalStateType.Abnormal_Burn, value8);
			AnimLoopDebuff_Map.Add(EAbnormalStateType.Abnormal_Poison, value9);
			AnimLoopDebuff_Map.Add(EAbnormalStateType.Abnormal_Thunder, value10);
		}
	}

	public override void BindEvent()
	{
		base.BindEvent();
		if (!(DataStore is DSHpProgBar))
		{
			return;
		}
		foreach (KeyValuePair<EAbnormalStateType, UNiagaraSystemWidget> item in EdgeFX_Map)
		{
			if (!item.Value.IsNullOrDestroyed())
			{
				HpDataStore.SetNeedShowAbnormalState(item.Key);
			}
		}
		BindValueToCustom(HpDataStore.CurAbnormalStateType, OnChangeCurAbnormalStateType);
		BindValueToCustom(HpDataStore.UnitBarInfoData, OnChangeUnitBarInfoData);
	}

	protected override void OnChangePercent(EChangeReason Reason, float OldValue, float NewValue)
	{
		if (NeedBgPercent)
		{
			ProcBGMat?.SetScalarParameterValue(B1GlobalFNames.GSScalarParameter_Percent, NewValue);
		}
		base.OnChangePercent(Reason, OldValue, NewValue);
	}

	private void OnChangeUnitBarInfoData(EChangeReason Reason, DS_IBUC_UnitBarInfoData OldValue, DS_IBUC_UnitBarInfoData NewValue)
	{
		if (OldValue != null)
		{
			OldValue.UnBindBossShieldBarActivedChange(BindShieldBarActivedIdx, OnChangeShieldActived);
			OldValue.UnBindShieldBarPercentChange(BindShieldBarPercentIdx, OnChangeShieldBarPercent);
			OnChangeShieldActived(OldValue: false, NewValue: false);
			OnChangeShieldBarPercent(1f, 1f);
		}
		if (NewValue != null)
		{
			BindShieldBarActivedIdx = NewValue.BindBossShieldBarActivedChange(OnChangeShieldActived);
			BindShieldBarPercentIdx = NewValue.BindShieldBarPercentChange(OnChangeShieldBarPercent);
		}
	}

	private void OnChangeShieldActived(bool OldValue, bool NewValue)
	{
		ShieldRoot?.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnChangeShieldBarPercent(float OldValue, float NewValue)
	{
		ProgShield?.SetValue(NewValue);
	}

	public void ClearAbnormalState()
	{
		HpDataStore.AbnormalStack.Clear();
		HpDataStore.UpdateAbnormalState();
	}

	private void OnChangeCurAbnormalStateType(EChangeReason Reason, EAbnormalStateType OldValue, EAbnormalStateType NewValue)
	{
		if (EdgeFX_Map.ContainsKey(OldValue))
		{
			EdgeFX_Map[OldValue]?.GSSetNiagaraValInt("Spawn", 0);
			EdgeFX_Map[OldValue].DeactivateSystem();
		}
		if (EdgeFX_Map.ContainsKey(NewValue))
		{
			EdgeFX_Map[NewValue]?.GSSetNiagaraValInt("Spawn", 1);
			EdgeFX_Map[NewValue]?.GSPlayFX();
		}
		ProgBar.GetMainMat()?.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_DebuffType, (int)NewValue);
		if (NewValue != EAbnormalStateType.None)
		{
			GSAnimKeyToState("AKBDebuffMain", "Actived");
		}
		else
		{
			GSAnimKeyToState("AKBDebuffMain", "Deactive");
		}
	}

	private void PlayDebuffHurtAnim(EAbnormalStateType AbnormalStateType)
	{
		if (HurtFX_Map.ContainsKey(AbnormalStateType))
		{
			HurtFX_Map[AbnormalStateType]?.ActivateSystem(Reset: true);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_HpProgBarCS");
		NativeReflection.GetPropertyRef(ref UseAbnormalFx_PropertyAddress, unrealStruct, "UseAbnormalFx");
		UseAbnormalFx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseAbnormalFx");
		UseAbnormalFx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseAbnormalFx", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ZeroHide_PropertyAddress, unrealStruct, "ZeroHide");
		ZeroHide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ZeroHide");
		ZeroHide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ZeroHide", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedBgPercent_PropertyAddress, unrealStruct, "NeedBgPercent");
		NeedBgPercent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedBgPercent");
		NeedBgPercent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedBgPercent", Classes.FBoolProperty);
	}

	static BI_HpProgBarCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_HpProgBarCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_HpProgBarCS));
	}
}
