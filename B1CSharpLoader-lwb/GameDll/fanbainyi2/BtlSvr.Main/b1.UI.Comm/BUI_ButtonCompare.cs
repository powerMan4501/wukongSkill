using System;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ButtonCompare")]
public class BUI_ButtonCompare : BUI_ButtonLongPressV2
{
	private UIDataHelper CurUIDataMap;

	private UIDataHelper SelectUIDataMap;

	private static bool CurUIDataConfigMap_IsValid;

	private static int CurUIDataConfigMap_Offset;

	private static FFieldAddress CurUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> CurUIDataConfigMap_Marshaler;

	private static bool SelectUIDataConfigMap_IsValid;

	private static int SelectUIDataConfigMap_Offset;

	private static FFieldAddress SelectUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> SelectUIDataConfigMap_Marshaler;

	private static bool IsSelect_IsValid;

	private static int IsSelect_Offset;

	private static FFieldAddress IsSelect_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[Category("GSProperty")]
	[DisplayName("当前UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonCompare:CurUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> CurUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!CurUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonCompare:CurUIDataConfigMap");
				return null;
			}
			if (CurUIDataConfigMap_Marshaler == null)
			{
				CurUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, CurUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return CurUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, CurUIDataConfigMap_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[Category("GSProperty")]
	[DisplayName("选中UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonCompare:SelectUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> SelectUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!SelectUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonCompare:SelectUIDataConfigMap");
				return null;
			}
			if (SelectUIDataConfigMap_Marshaler == null)
			{
				SelectUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, SelectUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return SelectUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, SelectUIDataConfigMap_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonCompare:IsSelect")]
	public bool IsSelect
	{
		get
		{
			CheckDestroyed();
			if (!IsSelect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonCompare:IsSelect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSelect_Offset), 0, IsSelect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSelect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonCompare:IsSelect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSelect_Offset), 0, IsSelect_PropertyAddress.Address, value);
			}
		}
	}

	public override void InitUIData()
	{
		BUI_ButtonCompare bUI_ButtonCompare = GetDefaultObj() as BUI_ButtonCompare;
		if (bUI_ButtonCompare != null)
		{
			CurUIDataMap = InitUIData(bUI_ButtonCompare.CurUIDataConfigMap);
			SelectUIDataMap = InitUIData(bUI_ButtonCompare.SelectUIDataConfigMap);
		}
		else
		{
			BGW_LogUtil.LogError("[InitUIData] Name = " + GetFullName() + " Init Fail");
		}
	}

	protected override UIDataHelper GetDataHelperImpl()
	{
		if (IsSelect)
		{
			return SelectUIDataMap;
		}
		return CurUIDataMap;
	}

	public void SetIsSelect(bool InIsSelect)
	{
		IsSelect = InIsSelect;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	protected override void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		BUI_ButtonCompare bUI_ButtonCompare = base.Parent as BUI_ButtonCompare;
		if (bUI_ButtonCompare != null)
		{
			IsSelect = bUI_ButtonCompare.IsSelect;
		}
		base.GSParentButtonUIStat = BtnStat;
		base.GSButtonUIStat = BtnStat;
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ButtonCompare");
		NativeReflection.GetPropertyRef(ref CurUIDataConfigMap_PropertyAddress, unrealStruct, "CurUIDataConfigMap");
		CurUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurUIDataConfigMap");
		CurUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SelectUIDataConfigMap_PropertyAddress, unrealStruct, "SelectUIDataConfigMap");
		SelectUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectUIDataConfigMap");
		SelectUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref IsSelect_PropertyAddress, unrealStruct, "IsSelect");
		IsSelect_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsSelect");
		IsSelect_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsSelect", Classes.FBoolProperty);
	}

	static BUI_ButtonCompare()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ButtonCompare)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ButtonCompare));
	}
}
