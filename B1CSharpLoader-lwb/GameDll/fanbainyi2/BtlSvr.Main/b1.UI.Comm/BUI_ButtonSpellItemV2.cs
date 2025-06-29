using System;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2")]
public class BUI_ButtonSpellItemV2 : BUI_Button
{
	private UIDataHelper NoneUIDataMap;

	private UIDataHelper InitiativeUIDataMap;

	private UIDataHelper WearInitiativeUIDataMap;

	private UIDataHelper PassiveUIDataMap;

	private UIDataHelper WearPassiveUIDataMap;

	private static bool NoneUIDataConfigMap_IsValid;

	private static int NoneUIDataConfigMap_Offset;

	private static FFieldAddress NoneUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> NoneUIDataConfigMap_Marshaler;

	private static bool InitiativeUIDataConfigMap_IsValid;

	private static int InitiativeUIDataConfigMap_Offset;

	private static FFieldAddress InitiativeUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> InitiativeUIDataConfigMap_Marshaler;

	private static bool WearInitiativeUIDataConfigMap_IsValid;

	private static int WearInitiativeUIDataConfigMap_Offset;

	private static FFieldAddress WearInitiativeUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> WearInitiativeUIDataConfigMap_Marshaler;

	private static bool PassiveUIDataConfigMap_IsValid;

	private static int PassiveUIDataConfigMap_Offset;

	private static FFieldAddress PassiveUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> PassiveUIDataConfigMap_Marshaler;

	private static bool WearPassiveUIDataConfigMap_IsValid;

	private static int WearPassiveUIDataConfigMap_Offset;

	private static FFieldAddress WearPassiveUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> WearPassiveUIDataConfigMap_Marshaler;

	private static bool IsInitiative_IsValid;

	private static int IsInitiative_Offset;

	private static FFieldAddress IsInitiative_PropertyAddress;

	private static bool IsNone_IsValid;

	private static int IsNone_Offset;

	private static FFieldAddress IsNone_PropertyAddress;

	private static bool IsWear_IsValid;

	private static int IsWear_Offset;

	private static FFieldAddress IsWear_PropertyAddress;

	[Category("GSProperty")]
	[DisplayName("空置UI配置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:NoneUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> NoneUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!NoneUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:NoneUIDataConfigMap");
				return null;
			}
			if (NoneUIDataConfigMap_Marshaler == null)
			{
				NoneUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, NoneUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return NoneUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, NoneUIDataConfigMap_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[Category("GSProperty")]
	[DisplayName("主动UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:InitiativeUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> InitiativeUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!InitiativeUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:InitiativeUIDataConfigMap");
				return null;
			}
			if (InitiativeUIDataConfigMap_Marshaler == null)
			{
				InitiativeUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, InitiativeUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return InitiativeUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, InitiativeUIDataConfigMap_Offset));
		}
	}

	[Category("GSProperty")]
	[DisplayName("装配主动UI配置")]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:WearInitiativeUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> WearInitiativeUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!WearInitiativeUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:WearInitiativeUIDataConfigMap");
				return null;
			}
			if (WearInitiativeUIDataConfigMap_Marshaler == null)
			{
				WearInitiativeUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, WearInitiativeUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return WearInitiativeUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, WearInitiativeUIDataConfigMap_Offset));
		}
	}

	[Category("GSProperty")]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("被动UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:PassiveUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> PassiveUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!PassiveUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:PassiveUIDataConfigMap");
				return null;
			}
			if (PassiveUIDataConfigMap_Marshaler == null)
			{
				PassiveUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, PassiveUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return PassiveUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, PassiveUIDataConfigMap_Offset));
		}
	}

	[DisplayName("装配被动UI配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:WearPassiveUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> WearPassiveUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!WearPassiveUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:WearPassiveUIDataConfigMap");
				return null;
			}
			if (WearPassiveUIDataConfigMap_Marshaler == null)
			{
				WearPassiveUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, WearPassiveUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return WearPassiveUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, WearPassiveUIDataConfigMap_Offset));
		}
	}

	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsInitiative")]
	public bool IsInitiative
	{
		get
		{
			CheckDestroyed();
			if (!IsInitiative_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsInitiative");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInitiative_Offset), 0, IsInitiative_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInitiative_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsInitiative");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInitiative_Offset), 0, IsInitiative_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsNone")]
	public bool IsNone
	{
		get
		{
			CheckDestroyed();
			if (!IsNone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsNone");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNone_Offset), 0, IsNone_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsNone");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNone_Offset), 0, IsNone_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsWear")]
	public bool IsWear
	{
		get
		{
			CheckDestroyed();
			if (!IsWear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsWear");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsWear_Offset), 0, IsWear_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsWear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonSpellItemV2:IsWear");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsWear_Offset), 0, IsWear_PropertyAddress.Address, value);
			}
		}
	}

	public override void InitUIData()
	{
		BUI_ButtonSpellItemV2 bUI_ButtonSpellItemV = GetDefaultObj() as BUI_ButtonSpellItemV2;
		if (bUI_ButtonSpellItemV != null)
		{
			NoneUIDataMap = InitUIData(bUI_ButtonSpellItemV.NoneUIDataConfigMap);
			InitiativeUIDataMap = InitUIData(bUI_ButtonSpellItemV.InitiativeUIDataConfigMap);
			WearInitiativeUIDataMap = InitUIData(bUI_ButtonSpellItemV.WearInitiativeUIDataConfigMap);
			PassiveUIDataMap = InitUIData(bUI_ButtonSpellItemV.PassiveUIDataConfigMap);
			WearPassiveUIDataMap = InitUIData(bUI_ButtonSpellItemV.WearPassiveUIDataConfigMap);
		}
		else
		{
			BGW_LogUtil.LogError("[InitUIData] Name = " + GetFullName() + " Init Fail");
		}
	}

	protected override UIDataHelper GetDataHelperImpl()
	{
		if (IsNone)
		{
			return NoneUIDataMap;
		}
		if (IsInitiative)
		{
			if (IsWear)
			{
				return WearInitiativeUIDataMap;
			}
			return InitiativeUIDataMap;
		}
		if (IsWear)
		{
			return WearPassiveUIDataMap;
		}
		return PassiveUIDataMap;
	}

	public void SetIsInitiative(bool InIsInitiative)
	{
		IsInitiative = InIsInitiative;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	public void SetIsNone(bool InIsNone)
	{
		IsNone = InIsNone;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	public void SetIsWear(bool InIsWear)
	{
		IsWear = InIsWear;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	protected override void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		BUI_ButtonSpellItemV2 bUI_ButtonSpellItemV = base.Parent as BUI_ButtonSpellItemV2;
		if (bUI_ButtonSpellItemV != null)
		{
			IsInitiative = bUI_ButtonSpellItemV.IsInitiative;
			IsNone = bUI_ButtonSpellItemV.IsNone;
			IsWear = bUI_ButtonSpellItemV.IsWear;
		}
		base.GSParentButtonUIStat = BtnStat;
		base.GSButtonUIStat = BtnStat;
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ButtonSpellItemV2");
		NativeReflection.GetPropertyRef(ref NoneUIDataConfigMap_PropertyAddress, unrealStruct, "NoneUIDataConfigMap");
		NoneUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoneUIDataConfigMap");
		NoneUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoneUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref InitiativeUIDataConfigMap_PropertyAddress, unrealStruct, "InitiativeUIDataConfigMap");
		InitiativeUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InitiativeUIDataConfigMap");
		InitiativeUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InitiativeUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref WearInitiativeUIDataConfigMap_PropertyAddress, unrealStruct, "WearInitiativeUIDataConfigMap");
		WearInitiativeUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WearInitiativeUIDataConfigMap");
		WearInitiativeUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WearInitiativeUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref PassiveUIDataConfigMap_PropertyAddress, unrealStruct, "PassiveUIDataConfigMap");
		PassiveUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PassiveUIDataConfigMap");
		PassiveUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PassiveUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref WearPassiveUIDataConfigMap_PropertyAddress, unrealStruct, "WearPassiveUIDataConfigMap");
		WearPassiveUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WearPassiveUIDataConfigMap");
		WearPassiveUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WearPassiveUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref IsInitiative_PropertyAddress, unrealStruct, "IsInitiative");
		IsInitiative_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsInitiative");
		IsInitiative_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsInitiative", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNone_PropertyAddress, unrealStruct, "IsNone");
		IsNone_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsNone");
		IsNone_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsNone", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsWear_PropertyAddress, unrealStruct, "IsWear");
		IsWear_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsWear");
		IsWear_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsWear", Classes.FBoolProperty);
	}

	static BUI_ButtonSpellItemV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ButtonSpellItemV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ButtonSpellItemV2));
	}
}
