using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp")]
public class BUS_EnvironmentItemStateMachineComp : UActorEditCompBase
{
	private static bool bEnableBoxOverlaping_IsValid;

	private static int bEnableBoxOverlaping_Offset;

	private static FFieldAddress bEnableBoxOverlaping_PropertyAddress;

	private static bool TriggerUnitFilter_IsValid;

	private static int TriggerUnitFilter_Offset;

	private static FFieldAddress TriggerUnitFilter_PropertyAddress;

	private static bool TriggerRange_IsValid;

	private static int TriggerRange_Offset;

	private static bool bCanTriggerRepeatedly_IsValid;

	private static int bCanTriggerRepeatedly_Offset;

	private static FFieldAddress bCanTriggerRepeatedly_PropertyAddress;

	private static bool SpecifiedResID_IsValid;

	private static int SpecifiedResID_Offset;

	private static bool ResIDBlackList_IsValid;

	private static int ResIDBlackList_Offset;

	private static FFieldAddress ResIDBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ResIDBlackList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:bEnableBoxOverlaping")]
	public bool bEnableBoxOverlaping
	{
		get
		{
			CheckDestroyed();
			if (!bEnableBoxOverlaping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:bEnableBoxOverlaping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableBoxOverlaping_Offset), 0, bEnableBoxOverlaping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableBoxOverlaping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:bEnableBoxOverlaping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableBoxOverlaping_Offset), 0, bEnableBoxOverlaping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:TriggerUnitFilter")]
	public ETriggerUnitFilter TriggerUnitFilter
	{
		get
		{
			CheckDestroyed();
			if (!TriggerUnitFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:TriggerUnitFilter");
				return ETriggerUnitFilter.WuKongOnly;
			}
			return EnumMarshaler<ETriggerUnitFilter>.FromNative(IntPtr.Add(base.Address, TriggerUnitFilter_Offset), 0, TriggerUnitFilter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerUnitFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:TriggerUnitFilter");
			}
			else
			{
				EnumMarshaler<ETriggerUnitFilter>.ToNative(IntPtr.Add(base.Address, TriggerUnitFilter_Offset), 0, TriggerUnitFilter_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("触发范围，该范围会在原有盒子外围生成一个虚拟的盒子，内层盒子触发进入，外层盒子触发退出")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:TriggerRange")]
	public float TriggerRange
	{
		get
		{
			CheckDestroyed();
			if (!TriggerRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:TriggerRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:TriggerRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerRange_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "TriggerUnitFilter != TriggerUnitFilter::All")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:bCanTriggerRepeatedly")]
	public bool bCanTriggerRepeatedly
	{
		get
		{
			CheckDestroyed();
			if (!bCanTriggerRepeatedly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:bCanTriggerRepeatedly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanTriggerRepeatedly_Offset), 0, bCanTriggerRepeatedly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanTriggerRepeatedly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:bCanTriggerRepeatedly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanTriggerRepeatedly_Offset), 0, bCanTriggerRepeatedly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "TriggerUnitFilter == TriggerUnitFilter::SpecifiedResID")]
	[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:SpecifiedResID")]
	public int SpecifiedResID
	{
		get
		{
			CheckDestroyed();
			if (!SpecifiedResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:SpecifiedResID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpecifiedResID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecifiedResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:SpecifiedResID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpecifiedResID_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "TriggerUnitFilter != TriggerUnitFilter::WuKongOnly && TriggerUnitFilter != TriggerUnitFilter::SpecifiedResID")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:ResIDBlackList")]
	public TArrayReadWrite<int> ResIDBlackList
	{
		get
		{
			CheckDestroyed();
			if (!ResIDBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp:ResIDBlackList");
				return null;
			}
			if (ResIDBlackList_Marshaler == null)
			{
				ResIDBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ResIDBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ResIDBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, ResIDBlackList_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		if (TriggerUnitFilter == ETriggerUnitFilter.All)
		{
			bCanTriggerRepeatedly = false;
		}
		RequireWritableData<b1.BUC_EnvironmentItemStateMachineData>().CopyBPDataToData(bEnableBoxOverlaping, TriggerUnitFilter, TriggerRange, bCanTriggerRepeatedly, SpecifiedResID, ResIDBlackList.ToList());
		RequireWritableData<BUC_QuestOverlapData>().bAutoEnableOverlap = true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_EnvironmentItemStateMachineComp");
		NativeReflection.GetPropertyRef(ref bEnableBoxOverlaping_PropertyAddress, unrealStruct, "bEnableBoxOverlaping");
		bEnableBoxOverlaping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableBoxOverlaping");
		bEnableBoxOverlaping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableBoxOverlaping", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TriggerUnitFilter_PropertyAddress, unrealStruct, "TriggerUnitFilter");
		TriggerUnitFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerUnitFilter");
		TriggerUnitFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerUnitFilter", Classes.FEnumProperty);
		TriggerRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerRange");
		TriggerRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerRange", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bCanTriggerRepeatedly_PropertyAddress, unrealStruct, "bCanTriggerRepeatedly");
		bCanTriggerRepeatedly_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanTriggerRepeatedly");
		bCanTriggerRepeatedly_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanTriggerRepeatedly", Classes.FBoolProperty);
		SpecifiedResID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecifiedResID");
		SpecifiedResID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecifiedResID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ResIDBlackList_PropertyAddress, unrealStruct, "ResIDBlackList");
		ResIDBlackList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ResIDBlackList");
		ResIDBlackList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ResIDBlackList", Classes.FArrayProperty);
	}

	static BUS_EnvironmentItemStateMachineComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_EnvironmentItemStateMachineComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_EnvironmentItemStateMachineComp));
	}
}
