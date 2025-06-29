using System;
using b1.BGW;
using b1.GSMUI.GSWidget;
using b1.Plugins.NiagaraUIRenderer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransProgCS")]
public class BI_TransProgCS : BUI_Widget
{
	protected IProcBar ProgBar;

	private UMaterialInstanceDynamic MIProg;

	private UMaterialInstanceDynamic MIFXProg;

	private UNiagaraSystemWidget NSSpark;

	private UWidgetAnimation AnimStA;

	private UWidgetAnimation AnimStB;

	private UWidgetAnimation AnimStC;

	private UWidgetAnimation AnimStD;

	private UWidgetAnimation AnimCosted;

	private UWidgetAnimation AnimReset;

	private UWidgetAnimation AnimIncrease;

	private UWidgetAnimation AnimFull;

	private UWidgetAnimation AnimAct;

	private UWidgetAnimation AnimReduce;

	private static bool IsProgLevel_IsValid;

	private static int IsProgLevel_Offset;

	private static FFieldAddress IsProgLevel_PropertyAddress;

	[Tooltip("内循环进度条是否为等级式")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BI_TransProgCS:IsProgLevel")]
	public bool IsProgLevel
	{
		get
		{
			CheckDestroyed();
			if (!IsProgLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TransProgCS:IsProgLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsProgLevel_Offset), 0, IsProgLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsProgLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TransProgCS:IsProgLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsProgLevel_Offset), 0, IsProgLevel_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UImage uImage = FindChildWidget("ProgMainImg") as UImage;
		MIProg = uImage.GetDynamicMaterial();
		if (IsProgLevel)
		{
			MIProg.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Level, 0f);
		}
		else
		{
			MIProg.SetScalarParameterValue(B1GlobalFNames.GSScalarParameter_Percent, 0f);
			MIFXProg = (FindChildWidget("UIFX_Highlight") as UImage)?.GetDynamicMaterial();
			ProgBar = FindAndConstructIProcBar("ProgBar");
		}
		NSSpark = FindChildWidget("UINS_Spark") as UNiagaraSystemWidget;
		AnimStA = FindWidgetAnimation("StAnimA");
		AnimStB = FindWidgetAnimation("StAnimB");
		AnimStC = FindWidgetAnimation("StAnimC");
		AnimStD = FindWidgetAnimation("StAnimD");
		AnimCosted = FindWidgetAnimation("AnimCosted");
		AnimReset = FindWidgetAnimation("AnimReset");
		AnimIncrease = FindWidgetAnimation("AnimIncrease");
		AnimFull = FindWidgetAnimation("AnimFull");
		AnimAct = FindWidgetAnimation("AnimAct");
		AnimReduce = FindWidgetAnimation("AnimReduce");
		GSAnimKeyToState("AKBState", "StDefault");
	}

	public void OnPevalueChange(float OldValue, float NewValue, float Percent)
	{
		if (NewValue < OldValue)
		{
			PlayWidgetAnimation(AnimCosted);
		}
		if (IsProgLevel)
		{
			MIProg.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Level, NewValue);
			return;
		}
		SetValue(Percent);
		MIFXProg?.SetScalarParameterValue(B1GlobalFNames.GSScalarParameter_Percent, Percent);
		if (NewValue > OldValue)
		{
			PlayWidgetAnimation(AnimIncrease);
		}
	}

	public void SetValue(float NewValue, bool IsImmediately = false)
	{
		UMaterialParameterCollection uIFXMPC = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.UIFXMPC;
		if (uIFXMPC != null)
		{
			UMaterialLibrary.SetScalarParameterValue(this, uIFXMPC, B1GlobalFNames.GSMIParameter_TransProgPercent, NewValue);
		}
		ProgBar.SetValue(NewValue, IsImmediately);
	}

	public void PlayAKBState(string State)
	{
		GSAnimKeyToState("AKBState", State);
	}

	public void PlayAnimStA()
	{
		PlayWidgetAnimation(AnimStA);
	}

	public void PlayAnimStB()
	{
		PlayWidgetAnimation(AnimStB);
	}

	public void PlayAnimStC()
	{
		PlayWidgetAnimation(AnimStC);
	}

	public void PlayAnimStD()
	{
		PlayWidgetAnimation(AnimStD);
	}

	public void NSActive(bool IsActive)
	{
		if (IsActive)
		{
			NSSpark?.ActivateSystem(Reset: true);
		}
		else
		{
			NSSpark?.DeactivateSystem();
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_TransProgCS");
		NativeReflection.GetPropertyRef(ref IsProgLevel_PropertyAddress, unrealStruct, "IsProgLevel");
		IsProgLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsProgLevel");
		IsProgLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsProgLevel", Classes.FBoolProperty);
	}

	static BI_TransProgCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransProgCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransProgCS));
	}
}
