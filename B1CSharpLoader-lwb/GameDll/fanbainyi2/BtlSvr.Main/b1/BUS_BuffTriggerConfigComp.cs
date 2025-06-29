using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BuffTriggerConfigComp")]
public class BUS_BuffTriggerConfigComp : UActorEditCompBase
{
	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	private static bool bTriggerEndOverlapWhenDisable_IsValid;

	private static int bTriggerEndOverlapWhenDisable_Offset;

	private static FFieldAddress bTriggerEndOverlapWhenDisable_PropertyAddress;

	private static bool ObserveUnitsConditions_IsValid;

	private static int ObserveUnitsConditions_Offset;

	private static FFieldAddress ObserveUnitsConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSBuffTriggerUnitCondition> ObserveUnitsConditions_Marshaler;

	[Tooltip("是否默认开启，控制器的开启和关闭可由CQG控制")]
	[DisplayName("是否默认开启")]
	[Category("BuffTrigger config")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_BuffTriggerConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerConfigComp:AutoEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Disable是否触发离开区域")]
	[Tooltip("是否默认开启，控制器的开启和关闭可由CQG控制")]
	[Category("BuffTrigger config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_BuffTriggerConfigComp:bTriggerEndOverlapWhenDisable")]
	public bool bTriggerEndOverlapWhenDisable
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerEndOverlapWhenDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerConfigComp:bTriggerEndOverlapWhenDisable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerEndOverlapWhenDisable_Offset), 0, bTriggerEndOverlapWhenDisable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerEndOverlapWhenDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerConfigComp:bTriggerEndOverlapWhenDisable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerEndOverlapWhenDisable_Offset), 0, bTriggerEndOverlapWhenDisable_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("需要检测的单位状态配置")]
	[Category("BuffTrigger config")]
	[DisplayName("BuffTrigger整体配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_BuffTriggerConfigComp:ObserveUnitsConditions")]
	public TArrayReadWrite<FGSBuffTriggerUnitCondition> ObserveUnitsConditions
	{
		get
		{
			CheckDestroyed();
			if (!ObserveUnitsConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerConfigComp:ObserveUnitsConditions");
				return null;
			}
			if (ObserveUnitsConditions_Marshaler == null)
			{
				ObserveUnitsConditions_Marshaler = new TArrayReadWriteMarshaler<FGSBuffTriggerUnitCondition>(1, ObserveUnitsConditions_PropertyAddress, CachedMarshalingDelegates<FGSBuffTriggerUnitCondition, FGSBuffTriggerUnitCondition>.FromNative, CachedMarshalingDelegates<FGSBuffTriggerUnitCondition, FGSBuffTriggerUnitCondition>.ToNative);
			}
			return ObserveUnitsConditions_Marshaler.FromNative(IntPtr.Add(base.Address, ObserveUnitsConditions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AutoEnable = true;
		bTriggerEndOverlapWhenDisable = false;
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_QuestOverlapData>().bAutoEnableOverlap = AutoEnable;
		b1.BUC_BuffTriggerData bUC_BuffTriggerData = RequireWritableData<b1.BUC_BuffTriggerData>();
		bUC_BuffTriggerData.bTriggerEndOverlapWhenDisable = bTriggerEndOverlapWhenDisable;
		foreach (FGSBuffTriggerUnitCondition observeUnitsCondition in ObserveUnitsConditions)
		{
			bUC_BuffTriggerData.BuffTriggerUnitConditions.Add(new FBuffTriggerUnitCondition(observeUnitsCondition));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_BuffTriggerConfigComp");
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bTriggerEndOverlapWhenDisable_PropertyAddress, unrealStruct, "bTriggerEndOverlapWhenDisable");
		bTriggerEndOverlapWhenDisable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bTriggerEndOverlapWhenDisable");
		bTriggerEndOverlapWhenDisable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bTriggerEndOverlapWhenDisable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveUnitsConditions_PropertyAddress, unrealStruct, "ObserveUnitsConditions");
		ObserveUnitsConditions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObserveUnitsConditions");
		ObserveUnitsConditions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObserveUnitsConditions", Classes.FArrayProperty);
	}

	static BUS_BuffTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BuffTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BuffTriggerConfigComp));
	}
}
