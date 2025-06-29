using System;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ButtonSpecialNone")]
public class BUI_ButtonSpecialNone : BUI_ButtonNone
{
	private UIDataHelper SpecialNoneUIDataMap;

	private UIDataHelper SpecialNormalUIDataMap;

	private static bool SpecialNoneUIDataConfigMap_IsValid;

	private static int SpecialNoneUIDataConfigMap_Offset;

	private static FFieldAddress SpecialNoneUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> SpecialNoneUIDataConfigMap_Marshaler;

	private static bool SpecialNormalUIDataConfigMap_IsValid;

	private static int SpecialNormalUIDataConfigMap_Offset;

	private static FFieldAddress SpecialNormalUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> SpecialNormalUIDataConfigMap_Marshaler;

	private static bool IsSpecial_IsValid;

	private static int IsSpecial_Offset;

	private static FFieldAddress IsSpecial_PropertyAddress;

	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[DisplayName("特殊状态空UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpecialNone:SpecialNoneUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> SpecialNoneUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!SpecialNoneUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpecialNone:SpecialNoneUIDataConfigMap");
				return null;
			}
			if (SpecialNoneUIDataConfigMap_Marshaler == null)
			{
				SpecialNoneUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, SpecialNoneUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return SpecialNoneUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialNoneUIDataConfigMap_Offset));
		}
	}

	[Category("GSProperty")]
	[DisplayName("特殊状态UI配置")]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpecialNone:SpecialNormalUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> SpecialNormalUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!SpecialNormalUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpecialNone:SpecialNormalUIDataConfigMap");
				return null;
			}
			if (SpecialNormalUIDataConfigMap_Marshaler == null)
			{
				SpecialNormalUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, SpecialNormalUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return SpecialNormalUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialNormalUIDataConfigMap_Offset));
		}
	}

	[Category("GSProperty")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpecialNone:IsSpecial")]
	public bool IsSpecial
	{
		get
		{
			CheckDestroyed();
			if (!IsSpecial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpecialNone:IsSpecial");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSpecial_Offset), 0, IsSpecial_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSpecial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpecialNone:IsSpecial");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSpecial_Offset), 0, IsSpecial_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
		IsSpecial = false;
	}

	public override void InitUIData()
	{
		base.InitUIData();
		BUI_ButtonSpecialNone bUI_ButtonSpecialNone = GetDefaultObj() as BUI_ButtonSpecialNone;
		if (bUI_ButtonSpecialNone != null)
		{
			SpecialNormalUIDataMap = InitUIData(bUI_ButtonSpecialNone.SpecialNormalUIDataConfigMap);
			SpecialNoneUIDataMap = InitUIData(bUI_ButtonSpecialNone.SpecialNoneUIDataConfigMap);
		}
		else
		{
			BGW_LogUtil.LogError("[InitUIData] Name = " + GetFullName() + " Init Fail");
		}
	}

	protected override UIDataHelper GetDataHelperImpl()
	{
		if (IsSpecial)
		{
			if (base.IsNone)
			{
				return SpecialNoneUIDataMap;
			}
			return SpecialNormalUIDataMap;
		}
		if (base.IsNone)
		{
			return NoneUIDataMap;
		}
		return NormalUIDataMap;
	}

	public void SetIsSpecial(bool InIsSpecial)
	{
		IsSpecial = InIsSpecial;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	protected override void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		BUI_ButtonSpecialNone bUI_ButtonSpecialNone = base.Parent as BUI_ButtonSpecialNone;
		if (bUI_ButtonSpecialNone != null)
		{
			base.IsNone = bUI_ButtonSpecialNone.IsNone;
			IsSpecial = bUI_ButtonSpecialNone.IsSpecial;
		}
		base.GSParentButtonUIStat = BtnStat;
		base.GSButtonUIStat = BtnStat;
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	protected override void StopUIStatAnim()
	{
		StopAnimation("GSAnimNormal");
		StopAnimation("GSAnimHovered");
		StopAnimation("GSAnimFocused");
		StopAnimation("GSAnimLockNormal");
		StopAnimation("GSAnimLockHovered");
		StopAnimation("GSAnimLockFocused");
		StopAnimation("GSAnimActived");
		StopAnimation("GSAnimLockActived");
		StopAnimation("GSAnimNormalSpecial");
		StopAnimation("GSAnimHoveredSpecial");
		StopAnimation("GSAnimFocusedSpecial");
		StopAnimation("GSAnimLockNormalSpecial");
		StopAnimation("GSAnimLockHoveredSpecial");
		StopAnimation("GSAnimLockFocusedSpecial");
		StopAnimation("GSAnimActivedSpecial");
		StopAnimation("GSAnimLockActivedSpecial");
	}

	protected override void CalUIStatAnim(ButtonUIStat InGSButtonUIStat)
	{
		string btnStatAnim = string.Empty;
		string btnStatAKBState = string.Empty;
		if (IsSpecial)
		{
			switch (InGSButtonUIStat)
			{
			case ButtonUIStat.Normal:
				btnStatAKBState = "NormalSp";
				btnStatAnim = "GSAnimNormalSpecial";
				break;
			case ButtonUIStat.Hovered:
				btnStatAKBState = "HoveredSp";
				btnStatAnim = "GSAnimHoveredSpecial";
				break;
			case ButtonUIStat.Focused:
				btnStatAKBState = "FocusedSp";
				btnStatAnim = "GSAnimFocusedSpecial";
				break;
			case ButtonUIStat.LockNormal:
				btnStatAKBState = "LockNormalSp";
				btnStatAnim = "GSAnimLockNormalSpecial";
				break;
			case ButtonUIStat.LockHovered:
				btnStatAKBState = "LockHoveredSp";
				btnStatAnim = "GSAnimLockHoveredSpecial";
				break;
			case ButtonUIStat.LockFocused:
				btnStatAKBState = "LockFocusedSp";
				btnStatAnim = "GSAnimLockFocusedSpecial";
				break;
			case ButtonUIStat.Actived:
				btnStatAKBState = "ActivedSp";
				btnStatAnim = "GSAnimActivedSpecial";
				break;
			case ButtonUIStat.LockActived:
				btnStatAKBState = "LockActivedSp";
				btnStatAnim = "GSAnimLockActivedSpecial";
				break;
			case ButtonUIStat.Disable:
				btnStatAKBState = "DisableSp";
				btnStatAnim = "GSAnimDisableSpecial";
				break;
			}
		}
		else
		{
			switch (InGSButtonUIStat)
			{
			case ButtonUIStat.Normal:
				btnStatAKBState = "Normal";
				btnStatAnim = "GSAnimNormal";
				break;
			case ButtonUIStat.Hovered:
				btnStatAKBState = "Hovered";
				btnStatAnim = "GSAnimHovered";
				break;
			case ButtonUIStat.Focused:
				btnStatAKBState = "Focused";
				btnStatAnim = "GSAnimFocused";
				break;
			case ButtonUIStat.LockNormal:
				btnStatAKBState = "LockNormal";
				btnStatAnim = "GSAnimLockNormal";
				break;
			case ButtonUIStat.LockHovered:
				btnStatAKBState = "LockHovered";
				btnStatAnim = "GSAnimLockHovered";
				break;
			case ButtonUIStat.LockFocused:
				btnStatAKBState = "LockFocused";
				btnStatAnim = "GSAnimLockFocused";
				break;
			case ButtonUIStat.Actived:
				btnStatAKBState = "Actived";
				btnStatAnim = "GSAnimActived";
				break;
			case ButtonUIStat.LockActived:
				btnStatAKBState = "LockActived";
				btnStatAnim = "GSAnimLockActived";
				break;
			case ButtonUIStat.Disable:
				btnStatAKBState = "Disable";
				btnStatAnim = "GSAnimDisable";
				break;
			}
		}
		BtnStatAnim = btnStatAnim;
		BtnStatAKBState = btnStatAKBState;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ButtonSpecialNone");
		NativeReflection.GetPropertyRef(ref SpecialNoneUIDataConfigMap_PropertyAddress, unrealStruct, "SpecialNoneUIDataConfigMap");
		SpecialNoneUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialNoneUIDataConfigMap");
		SpecialNoneUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialNoneUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SpecialNormalUIDataConfigMap_PropertyAddress, unrealStruct, "SpecialNormalUIDataConfigMap");
		SpecialNormalUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialNormalUIDataConfigMap");
		SpecialNormalUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialNormalUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref IsSpecial_PropertyAddress, unrealStruct, "IsSpecial");
		IsSpecial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsSpecial");
		IsSpecial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsSpecial", Classes.FBoolProperty);
	}

	static BUI_ButtonSpecialNone()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ButtonSpecialNone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ButtonSpecialNone));
	}
}
