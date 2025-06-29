using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BossBar")]
public class BUI_BossBar : BUI_EnemyBloodBarPure
{
	private UWidgetAnimation ShowOut;

	public BUI_BarCSharp HPBar;

	private bool HasShow;

	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	private static bool GSInit_IsValid;

	private static IntPtr GSInit_FunctionAddress;

	private static int GSInit_ParamsSize;

	private static bool GSInit_InOwnerCharacter_IsValid;

	private static int GSInit_InOwnerCharacter_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BossBar:OwnerCharacter")]
	public AActor OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BossBar:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BossBar:OwnerCharacter");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, OwnerCharacter_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	public override void DoShowIn(AActor Owner)
	{
		if (!HasShow)
		{
			InitValue();
			SetVisibility(ESlateVisibility.Visible);
			if (ShowOut == null)
			{
				ShowOut = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "ShowOut");
			}
			PlayAnimation(ShowOut, 0f, 1, EUMGSequencePlayMode.Reverse);
			HasShow = true;
		}
	}

	[BlueprintCallable]
	[UFunction]
	public override void DoShowOut()
	{
		if (ShowOut == null)
		{
			ShowOut = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "ShowOut");
		}
		PlayAnimation(ShowOut);
		BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OwnerCharacter).FloatAttrs.UnBindOnSetIdxValue(OnBindHPChanged);
		OwnerCharacter = null;
		HasShow = false;
	}

	[UFunction]
	[BlueprintCallable]
	public override void DoFreeOwner()
	{
		OwnerCharacter = null;
	}

	[UFunction]
	[BlueprintCallable]
	public override void DoGSInit(AActor InOwnerCharacter)
	{
		HasShow = false;
		GSInit(InOwnerCharacter);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BossBar:GSInit")]
	public void GSInit(AActor InOwnerCharacter)
	{
		OwnerCharacter = InOwnerCharacter;
		InitValue();
		BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OwnerCharacter).FloatAttrs.UnBindOnSetIdxValue(OnBindHPChanged);
	}

	public void OnBindHPChanged(int AttrId, float OldValue, float NewValue)
	{
		if (AttrId == 151)
		{
			OnHPChanged(EBGUAttrFloat.Hp, OldValue, NewValue);
		}
	}

	public void OnHPChanged(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (HPBar == null)
		{
			HPBar = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.HPBar) as BUI_BarCSharp;
		}
		HPBar.ValueDecrease(FMath.Abs(NewValue - OldValue));
	}

	private void InitValue()
	{
		float inMaxValue = BGUFunctionLibraryCS.BGUGetFloatAttr(OwnerCharacter, EBGUAttrFloat.HpMax);
		float inCurValue = BGUFunctionLibraryCS.BGUGetFloatAttr(OwnerCharacter, EBGUAttrFloat.Hp);
		if (HPBar == null)
		{
			HPBar = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.HPBar) as BUI_BarCSharp;
		}
		HPBar.InitSetCurAndMaxValue(inMaxValue, inCurValue, InIsReCalcMaxLen: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BossBar:GSInit")]
	private static void GSInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BossBar bUI_BossBar = GCHelper.Find<BUI_BossBar>(obj);
		AActor inOwnerCharacter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSInit_InOwnerCharacter_Offset));
		bUI_BossBar.GSInit(inOwnerCharacter);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BossBar");
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwnerCharacter", Classes.FObjectProperty);
		GSInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSInit");
		GSInit_ParamsSize = NativeReflection.GetFunctionParamsSize(GSInit_FunctionAddress);
		GSInit_InOwnerCharacter_Offset = NativeReflection.GetPropertyOffset(GSInit_FunctionAddress, "InOwnerCharacter");
		GSInit_InOwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(GSInit_FunctionAddress, "InOwnerCharacter", Classes.FObjectProperty);
		GSInit_IsValid = GSInit_FunctionAddress != IntPtr.Zero && GSInit_InOwnerCharacter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BossBar:GSInit", GSInit_IsValid);
	}

	static BUI_BossBar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BossBar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BossBar));
	}
}
