using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_EnemyBar")]
internal class BUI_EnemyBar : BUI_EnemyBloodBarPure
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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_EnemyBar:OwnerCharacter")]
	public AActor OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EnemyBar:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EnemyBar:OwnerCharacter");
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
			SetVisibility(ESlateVisibility.Visible);
			if (ShowOut == null)
			{
				ShowOut = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "ShowOut");
			}
			PlayAnimation(ShowOut, 0f, 1, EUMGSequencePlayMode.Reverse);
			HasShow = true;
		}
	}

	[UFunction]
	[BlueprintCallable]
	public override void DoShowOut()
	{
		if (!(OwnerCharacter == null) && !BGUFunctionLibraryCS.BGUIsUnitDead(OwnerCharacter))
		{
			if (ShowOut == null)
			{
				ShowOut = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "ShowOut");
			}
			PlayAnimation(ShowOut);
			BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OwnerCharacter).FloatAttrs.UnBindOnSetIdxValue(OnBindOnSetIdxValueChanged);
			OwnerCharacter = null;
			HasShow = false;
		}
	}

	public void HiddenBloodBar()
	{
		if (ShowOut == null)
		{
			ShowOut = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "ShowOut");
		}
		PlayAnimation(ShowOut);
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
		SetVisibility(ESlateVisibility.Hidden);
		GSInit(InOwnerCharacter);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_EnemyBar:GSInit")]
	public void GSInit(AActor InOwnerCharacter)
	{
		OwnerCharacter = InOwnerCharacter;
		InitValue();
		BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OwnerCharacter).FloatAttrs.BindOnSetIdxValue(OnBindOnSetIdxValueChanged);
	}

	public void OnHPChanged(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (HPBar == null)
		{
			HPBar = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.HPBar) as BUI_BarCSharp;
		}
		float num = NewValue - OldValue;
		HPBar.SetVisibility(ESlateVisibility.Visible);
		if (num < 0f)
		{
			DoShowIn(OwnerCharacter);
			HPBar.ValueDecrease(FMath.Abs(num));
		}
		else
		{
			HPBar.ValueIncrease(FMath.Abs(num));
		}
	}

	public void OnHPMaxChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		InitValue();
	}

	public void OnBindOnSetIdxValueChanged(int AttrId, float OldValue, float NewValue)
	{
		switch (AttrId)
		{
		case 151:
			OnHPChanged(EBGUAttrFloat.Hp, OldValue, NewValue);
			break;
		case 1:
			OnHPMaxChange(EBGUAttrFloat.HpMax, OldValue, NewValue);
			break;
		}
	}

	private void InitValue()
	{
		float inMaxValue = BGUFunctionLibraryCS.BGUGetFloatAttr(OwnerCharacter, EBGUAttrFloat.HpMax);
		float inCurValue = BGUFunctionLibraryCS.BGUGetFloatAttr(OwnerCharacter, EBGUAttrFloat.Hp);
		HPBar = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.HPBar) as BUI_BarCSharp;
		HPBar.InitSetCurAndMaxValue(inMaxValue, inCurValue, InIsReCalcMaxLen: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_EnemyBar:GSInit")]
	private static void GSInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.Comm.BUI_EnemyBar bUI_EnemyBar = GCHelper.Find<b1.UI.Comm.BUI_EnemyBar>(obj);
		AActor inOwnerCharacter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSInit_InOwnerCharacter_Offset));
		bUI_EnemyBar.GSInit(inOwnerCharacter);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_EnemyBar");
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwnerCharacter", Classes.FObjectProperty);
		GSInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSInit");
		GSInit_ParamsSize = NativeReflection.GetFunctionParamsSize(GSInit_FunctionAddress);
		GSInit_InOwnerCharacter_Offset = NativeReflection.GetPropertyOffset(GSInit_FunctionAddress, "InOwnerCharacter");
		GSInit_InOwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(GSInit_FunctionAddress, "InOwnerCharacter", Classes.FObjectProperty);
		GSInit_IsValid = GSInit_FunctionAddress != IntPtr.Zero && GSInit_InOwnerCharacter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_EnemyBar:GSInit", GSInit_IsValid);
	}

	static BUI_EnemyBar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.Comm.BUI_EnemyBar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.Comm.BUI_EnemyBar));
	}
}
