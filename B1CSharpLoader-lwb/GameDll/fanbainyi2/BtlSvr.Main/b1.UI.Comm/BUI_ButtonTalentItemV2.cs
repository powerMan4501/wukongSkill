using System;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ButtonTalentItemV2")]
public class BUI_ButtonTalentItemV2 : BUI_Button
{
	private UIDataHelper NotLearnUIDataMap;

	private UIDataHelper HasLearnUIDataMap;

	private UIDataHelper MaxLearnUIDataMap;

	private static bool NotLearnUIDataConfigMap_IsValid;

	private static int NotLearnUIDataConfigMap_Offset;

	private static FFieldAddress NotLearnUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> NotLearnUIDataConfigMap_Marshaler;

	private static bool HasLearnUIDataConfigMap_IsValid;

	private static int HasLearnUIDataConfigMap_Offset;

	private static FFieldAddress HasLearnUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> HasLearnUIDataConfigMap_Marshaler;

	private static bool MaxLearnUIDataConfigMap_IsValid;

	private static int MaxLearnUIDataConfigMap_Offset;

	private static FFieldAddress MaxLearnUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> MaxLearnUIDataConfigMap_Marshaler;

	private static bool CurTalentState_IsValid;

	private static int CurTalentState_Offset;

	private static FFieldAddress CurTalentState_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[Category("GSProperty")]
	[DisplayName("未学习UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonTalentItemV2:NotLearnUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> NotLearnUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!NotLearnUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonTalentItemV2:NotLearnUIDataConfigMap");
				return null;
			}
			if (NotLearnUIDataConfigMap_Marshaler == null)
			{
				NotLearnUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, NotLearnUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return NotLearnUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, NotLearnUIDataConfigMap_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("已学习UI配置")]
	[Category("GSProperty")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonTalentItemV2:HasLearnUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> HasLearnUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!HasLearnUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonTalentItemV2:HasLearnUIDataConfigMap");
				return null;
			}
			if (HasLearnUIDataConfigMap_Marshaler == null)
			{
				HasLearnUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, HasLearnUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return HasLearnUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, HasLearnUIDataConfigMap_Offset));
		}
	}

	[DisplayName("已学满UI配置")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_ButtonTalentItemV2:MaxLearnUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> MaxLearnUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!MaxLearnUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonTalentItemV2:MaxLearnUIDataConfigMap");
				return null;
			}
			if (MaxLearnUIDataConfigMap_Marshaler == null)
			{
				MaxLearnUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, MaxLearnUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return MaxLearnUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, MaxLearnUIDataConfigMap_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonTalentItemV2:CurTalentState")]
	public TalentState CurTalentState
	{
		get
		{
			CheckDestroyed();
			if (!CurTalentState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonTalentItemV2:CurTalentState");
				return TalentState.NotLearn;
			}
			return EnumMarshaler<TalentState>.FromNative(IntPtr.Add(base.Address, CurTalentState_Offset), 0, CurTalentState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurTalentState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonTalentItemV2:CurTalentState");
			}
			else
			{
				EnumMarshaler<TalentState>.ToNative(IntPtr.Add(base.Address, CurTalentState_Offset), 0, CurTalentState_PropertyAddress.Address, value);
			}
		}
	}

	public override void InitUIData()
	{
		BUI_ButtonTalentItemV2 bUI_ButtonTalentItemV = GetDefaultObj() as BUI_ButtonTalentItemV2;
		if (bUI_ButtonTalentItemV != null)
		{
			NotLearnUIDataMap = InitUIData(bUI_ButtonTalentItemV.NotLearnUIDataConfigMap);
			HasLearnUIDataMap = InitUIData(bUI_ButtonTalentItemV.HasLearnUIDataConfigMap);
			MaxLearnUIDataMap = InitUIData(bUI_ButtonTalentItemV.MaxLearnUIDataConfigMap);
		}
		else
		{
			BGW_LogUtil.LogError("[InitUIData] Name = " + GetFullName() + " Init Fail");
		}
	}

	protected override UIDataHelper GetDataHelperImpl()
	{
		UIDataHelper result = null;
		switch (CurTalentState)
		{
		case TalentState.NotLearn:
			result = NotLearnUIDataMap;
			break;
		case TalentState.HasLearn:
			result = HasLearnUIDataMap;
			break;
		case TalentState.MaxLearn:
			result = MaxLearnUIDataMap;
			break;
		}
		return result;
	}

	public void SetTalentState(TalentState InTalentState)
	{
		CurTalentState = InTalentState;
		SetBtnStateEvent(ESetStateReason.Update);
		switch (CurTalentState)
		{
		case TalentState.NotLearn:
			GSAnimKeyToState("AKBStateChange", "StNot");
			break;
		case TalentState.HasLearn:
			GSAnimKeyToState("AKBStateChange", "StHas");
			break;
		case TalentState.MaxLearn:
			GSAnimKeyToState("AKBStateChange", "StMax");
			break;
		}
	}

	protected override void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		BUI_ButtonTalentItemV2 bUI_ButtonTalentItemV = base.Parent as BUI_ButtonTalentItemV2;
		if (bUI_ButtonTalentItemV != null)
		{
			CurTalentState = bUI_ButtonTalentItemV.CurTalentState;
		}
		base.GSParentButtonUIStat = BtnStat;
		base.GSButtonUIStat = BtnStat;
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ButtonTalentItemV2");
		NativeReflection.GetPropertyRef(ref NotLearnUIDataConfigMap_PropertyAddress, unrealStruct, "NotLearnUIDataConfigMap");
		NotLearnUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NotLearnUIDataConfigMap");
		NotLearnUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NotLearnUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref HasLearnUIDataConfigMap_PropertyAddress, unrealStruct, "HasLearnUIDataConfigMap");
		HasLearnUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HasLearnUIDataConfigMap");
		HasLearnUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HasLearnUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MaxLearnUIDataConfigMap_PropertyAddress, unrealStruct, "MaxLearnUIDataConfigMap");
		MaxLearnUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxLearnUIDataConfigMap");
		MaxLearnUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxLearnUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref CurTalentState_PropertyAddress, unrealStruct, "CurTalentState");
		CurTalentState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurTalentState");
		CurTalentState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurTalentState", Classes.FEnumProperty);
	}

	static BUI_ButtonTalentItemV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ButtonTalentItemV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ButtonTalentItemV2));
	}
}
