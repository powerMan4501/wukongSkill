using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp")]
internal class BUS_ActionTriggerConfigComp : UActorEditCompBase
{
	private static bool TargetActionType_IsValid;

	private static int TargetActionType_Offset;

	private static FFieldAddress TargetActionType_PropertyAddress;

	private static bool UseManualSelect_IsValid;

	private static int UseManualSelect_Offset;

	private static FFieldAddress UseManualSelect_PropertyAddress;

	private static bool TargetList_IsValid;

	private static int TargetList_Offset;

	private static FFieldAddress TargetList_PropertyAddress;

	private TArrayReadWriteMarshaler<ABGUCharacter> TargetList_Marshaler;

	private static bool UseAreaSelect_IsValid;

	private static int UseAreaSelect_Offset;

	private static FFieldAddress UseAreaSelect_PropertyAddress;

	private static bool AreaList_IsValid;

	private static int AreaList_Offset;

	private static FFieldAddress AreaList_PropertyAddress;

	private TArrayReadWriteMarshaler<BGUSelectAreaActor> AreaList_Marshaler;

	private static bool ResIdList_IsValid;

	private static int ResIdList_Offset;

	private static FFieldAddress ResIdList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ResIdList_Marshaler;

	private static bool bSelectUnitHasTarget_IsValid;

	private static int bSelectUnitHasTarget_Offset;

	private static FFieldAddress bSelectUnitHasTarget_PropertyAddress;

	private static bool bSelectPassiveUnit_IsValid;

	private static int bSelectPassiveUnit_Offset;

	private static FFieldAddress bSelectPassiveUnit_PropertyAddress;

	[EditAnywhere]
	[Category("配置|目标行为类型")]
	[DisplayName("目标行为类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:TargetActionType")]
	public ETargetActionType TargetActionType
	{
		get
		{
			CheckDestroyed();
			if (!TargetActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:TargetActionType");
				return ETargetActionType.WakeUp;
			}
			return EnumMarshaler<ETargetActionType>.FromNative(IntPtr.Add(base.Address, TargetActionType_Offset), 0, TargetActionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:TargetActionType");
			}
			else
			{
				EnumMarshaler<ETargetActionType>.ToNative(IntPtr.Add(base.Address, TargetActionType_Offset), 0, TargetActionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("配置|目标筛选")]
	[DisplayName("是否使用手动选怪")]
	[Tooltip("和区域筛选可以共存")]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:UseManualSelect")]
	public bool UseManualSelect
	{
		get
		{
			CheckDestroyed();
			if (!UseManualSelect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:UseManualSelect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseManualSelect_Offset), 0, UseManualSelect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseManualSelect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:UseManualSelect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseManualSelect_Offset), 0, UseManualSelect_PropertyAddress.Address, value);
			}
		}
	}

	[Category("配置|目标筛选")]
	[EditAnywhere]
	[DisplayName("目标列表")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseManualSelect")]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:TargetList")]
	public TArrayReadWrite<ABGUCharacter> TargetList
	{
		get
		{
			CheckDestroyed();
			if (!TargetList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:TargetList");
				return null;
			}
			if (TargetList_Marshaler == null)
			{
				TargetList_Marshaler = new TArrayReadWriteMarshaler<ABGUCharacter>(1, TargetList_PropertyAddress, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.ToNative);
			}
			return TargetList_Marshaler.FromNative(IntPtr.Add(base.Address, TargetList_Offset));
		}
	}

	[UProperty]
	[Category("配置|目标筛选")]
	[DisplayName("是否使用区域选怪")]
	[Tooltip("和手动筛选可以共存")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:UseAreaSelect")]
	public bool UseAreaSelect
	{
		get
		{
			CheckDestroyed();
			if (!UseAreaSelect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:UseAreaSelect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAreaSelect_Offset), 0, UseAreaSelect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAreaSelect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:UseAreaSelect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAreaSelect_Offset), 0, UseAreaSelect_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseAreaSelect")]
	[UProperty]
	[EditAnywhere]
	[Category("配置|目标筛选")]
	[DisplayName("区域列表")]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:AreaList")]
	public TArrayReadWrite<BGUSelectAreaActor> AreaList
	{
		get
		{
			CheckDestroyed();
			if (!AreaList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:AreaList");
				return null;
			}
			if (AreaList_Marshaler == null)
			{
				AreaList_Marshaler = new TArrayReadWriteMarshaler<BGUSelectAreaActor>(1, AreaList_PropertyAddress, CachedMarshalingDelegates<BGUSelectAreaActor, UObjectMarshaler<BGUSelectAreaActor>>.FromNative, CachedMarshalingDelegates<BGUSelectAreaActor, UObjectMarshaler<BGUSelectAreaActor>>.ToNative);
			}
			return AreaList_Marshaler.FromNative(IntPtr.Add(base.Address, AreaList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("配置|通用筛选项")]
	[Tooltip("不填则不做过滤")]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:ResIdList")]
	public TArrayReadWrite<int> ResIdList
	{
		get
		{
			CheckDestroyed();
			if (!ResIdList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:ResIdList");
				return null;
			}
			if (ResIdList_Marshaler == null)
			{
				ResIdList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ResIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ResIdList_Marshaler.FromNative(IntPtr.Add(base.Address, ResIdList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("配置|通用筛选项")]
	[DisplayName("是否筛选已有目标的单位")]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:bSelectUnitHasTarget")]
	public bool bSelectUnitHasTarget
	{
		get
		{
			CheckDestroyed();
			if (!bSelectUnitHasTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:bSelectUnitHasTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSelectUnitHasTarget_Offset), 0, bSelectUnitHasTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSelectUnitHasTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:bSelectUnitHasTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSelectUnitHasTarget_Offset), 0, bSelectUnitHasTarget_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("被动属性由UnitAI表中UnitAIAttackType配置")]
	[DisplayName("是否筛选被动怪")]
	[Category("配置|通用筛选项")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ActionTriggerConfigComp:bSelectPassiveUnit")]
	public bool bSelectPassiveUnit
	{
		get
		{
			CheckDestroyed();
			if (!bSelectPassiveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:bSelectPassiveUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSelectPassiveUnit_Offset), 0, bSelectPassiveUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSelectPassiveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActionTriggerConfigComp:bSelectPassiveUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSelectPassiveUnit_Offset), 0, bSelectPassiveUnit_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_ActionTriggerConfigData bUC_ActionTriggerConfigData = RequireWritableData<b1.BUC_ActionTriggerConfigData>();
		bUC_ActionTriggerConfigData.TargetActionType = TargetActionType;
		bUC_ActionTriggerConfigData.UseManualSelect = UseManualSelect;
		bUC_ActionTriggerConfigData.TargetList = new List<TStrongObjectPtr<ABGUCharacter>>();
		foreach (ABGUCharacter item in TargetList.ToList())
		{
			bUC_ActionTriggerConfigData.TargetList.Add(new TStrongObjectPtr<ABGUCharacter>(item));
		}
		bUC_ActionTriggerConfigData.UseAreaSelect = UseAreaSelect;
		bUC_ActionTriggerConfigData.AreaList = new List<TStrongObjectPtr<BGUSelectAreaActor>>();
		foreach (BGUSelectAreaActor item2 in AreaList.ToList())
		{
			bUC_ActionTriggerConfigData.AreaList.Add(new TStrongObjectPtr<BGUSelectAreaActor>(item2));
		}
		bUC_ActionTriggerConfigData.ResIdList = ResIdList.ToList();
		bUC_ActionTriggerConfigData.bSelectUnitHasTarget = bSelectUnitHasTarget;
		bUC_ActionTriggerConfigData.bSelectPassiveUnit = bSelectPassiveUnit;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ActionTriggerConfigComp");
		NativeReflection.GetPropertyRef(ref TargetActionType_PropertyAddress, unrealStruct, "TargetActionType");
		TargetActionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetActionType");
		TargetActionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetActionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UseManualSelect_PropertyAddress, unrealStruct, "UseManualSelect");
		UseManualSelect_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseManualSelect");
		UseManualSelect_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseManualSelect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TargetList_PropertyAddress, unrealStruct, "TargetList");
		TargetList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetList");
		TargetList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseAreaSelect_PropertyAddress, unrealStruct, "UseAreaSelect");
		UseAreaSelect_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseAreaSelect");
		UseAreaSelect_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseAreaSelect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AreaList_PropertyAddress, unrealStruct, "AreaList");
		AreaList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaList");
		AreaList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ResIdList_PropertyAddress, unrealStruct, "ResIdList");
		ResIdList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ResIdList");
		ResIdList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ResIdList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bSelectUnitHasTarget_PropertyAddress, unrealStruct, "bSelectUnitHasTarget");
		bSelectUnitHasTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bSelectUnitHasTarget");
		bSelectUnitHasTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bSelectUnitHasTarget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSelectPassiveUnit_PropertyAddress, unrealStruct, "bSelectPassiveUnit");
		bSelectPassiveUnit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bSelectPassiveUnit");
		bSelectPassiveUnit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bSelectPassiveUnit", Classes.FBoolProperty);
	}

	static BUS_ActionTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_ActionTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_ActionTriggerConfigComp));
	}
}
