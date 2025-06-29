using System;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ButtonNone")]
public class BUI_ButtonNone : BUI_Button
{
	protected UIDataHelper NoneUIDataMap;

	protected UIDataHelper NormalUIDataMap;

	private static bool NoneUIDataConfigMap_IsValid;

	private static int NoneUIDataConfigMap_Offset;

	private static FFieldAddress NoneUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> NoneUIDataConfigMap_Marshaler;

	private static bool NormalUIDataConfigMap_IsValid;

	private static int NormalUIDataConfigMap_Offset;

	private static FFieldAddress NormalUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> NormalUIDataConfigMap_Marshaler;

	private static bool IsNone_IsValid;

	private static int IsNone_Offset;

	private static FFieldAddress IsNone_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[DisplayName("空置UI配置")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonNone:NoneUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> NoneUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!NoneUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonNone:NoneUIDataConfigMap");
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
	[DisplayName("默认UI配置")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonNone:NormalUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> NormalUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!NormalUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonNone:NormalUIDataConfigMap");
				return null;
			}
			if (NormalUIDataConfigMap_Marshaler == null)
			{
				NormalUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, NormalUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return NormalUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, NormalUIDataConfigMap_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonNone:IsNone")]
	public bool IsNone
	{
		get
		{
			CheckDestroyed();
			if (!IsNone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonNone:IsNone");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNone_Offset), 0, IsNone_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonNone:IsNone");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNone_Offset), 0, IsNone_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		IsNone = true;
	}

	public override void InitUIData()
	{
		BUI_ButtonNone bUI_ButtonNone = GetDefaultObj() as BUI_ButtonNone;
		if (bUI_ButtonNone != null)
		{
			NoneUIDataMap = InitUIData(bUI_ButtonNone.NoneUIDataConfigMap);
			NormalUIDataMap = InitUIData(bUI_ButtonNone.NormalUIDataConfigMap);
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
		return NormalUIDataMap;
	}

	public void SetIsNone(bool InIsNone)
	{
		IsNone = InIsNone;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	protected override void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		BUI_ButtonNone bUI_ButtonNone = base.Parent as BUI_ButtonNone;
		if (bUI_ButtonNone != null)
		{
			IsNone = bUI_ButtonNone.IsNone;
		}
		base.GSParentButtonUIStat = BtnStat;
		base.GSButtonUIStat = BtnStat;
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ButtonNone");
		NativeReflection.GetPropertyRef(ref NoneUIDataConfigMap_PropertyAddress, unrealStruct, "NoneUIDataConfigMap");
		NoneUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoneUIDataConfigMap");
		NoneUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoneUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref NormalUIDataConfigMap_PropertyAddress, unrealStruct, "NormalUIDataConfigMap");
		NormalUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalUIDataConfigMap");
		NormalUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref IsNone_PropertyAddress, unrealStruct, "IsNone");
		IsNone_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsNone");
		IsNone_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsNone", Classes.FBoolProperty);
	}

	static BUI_ButtonNone()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ButtonNone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ButtonNone));
	}
}
