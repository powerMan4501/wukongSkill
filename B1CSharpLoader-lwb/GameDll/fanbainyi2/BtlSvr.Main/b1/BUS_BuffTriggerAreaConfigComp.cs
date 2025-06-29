using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp")]
public class BUS_BuffTriggerAreaConfigComp : UActorEditCompBase
{
	private static bool ObserveUnitsConditions_IsValid;

	private static int ObserveUnitsConditions_Offset;

	private static FFieldAddress ObserveUnitsConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSBuffTriggerUnitCondition> ObserveUnitsConditions_Marshaler;

	private static bool bTriggerEndOverlapWhenDisable_IsValid;

	private static int bTriggerEndOverlapWhenDisable_Offset;

	private static FFieldAddress bTriggerEndOverlapWhenDisable_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("BuffTrigger整体配置")]
	[UProperty]
	[Category("BuffTrigger config")]
	[Tooltip("需要检测的单位状态配置")]
	[USharpPath("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp:ObserveUnitsConditions")]
	public TArrayReadWrite<FGSBuffTriggerUnitCondition> ObserveUnitsConditions
	{
		get
		{
			CheckDestroyed();
			if (!ObserveUnitsConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp:ObserveUnitsConditions");
				return null;
			}
			if (ObserveUnitsConditions_Marshaler == null)
			{
				ObserveUnitsConditions_Marshaler = new TArrayReadWriteMarshaler<FGSBuffTriggerUnitCondition>(1, ObserveUnitsConditions_PropertyAddress, CachedMarshalingDelegates<FGSBuffTriggerUnitCondition, FGSBuffTriggerUnitCondition>.FromNative, CachedMarshalingDelegates<FGSBuffTriggerUnitCondition, FGSBuffTriggerUnitCondition>.ToNative);
			}
			return ObserveUnitsConditions_Marshaler.FromNative(IntPtr.Add(base.Address, ObserveUnitsConditions_Offset));
		}
	}

	[DisplayName("Disable是否触发离开区域")]
	[Tooltip("是否默认开启，控制器的开启和关闭可由CQG控制")]
	[Category("BuffTrigger config")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp:bTriggerEndOverlapWhenDisable")]
	public bool bTriggerEndOverlapWhenDisable
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerEndOverlapWhenDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp:bTriggerEndOverlapWhenDisable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerEndOverlapWhenDisable_Offset), 0, bTriggerEndOverlapWhenDisable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerEndOverlapWhenDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp:bTriggerEndOverlapWhenDisable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerEndOverlapWhenDisable_Offset), 0, bTriggerEndOverlapWhenDisable_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_BuffTriggerLogicData bUC_BuffTriggerLogicData = RequireWritableData<b1.BUC_BuffTriggerLogicData>();
		foreach (FGSBuffTriggerUnitCondition observeUnitsCondition in ObserveUnitsConditions)
		{
			bUC_BuffTriggerLogicData.BuffTriggerUnitConditions.Add(new FBuffTriggerUnitCondition(observeUnitsCondition));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_BuffTriggerAreaConfigComp");
		NativeReflection.GetPropertyRef(ref ObserveUnitsConditions_PropertyAddress, unrealStruct, "ObserveUnitsConditions");
		ObserveUnitsConditions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObserveUnitsConditions");
		ObserveUnitsConditions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObserveUnitsConditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bTriggerEndOverlapWhenDisable_PropertyAddress, unrealStruct, "bTriggerEndOverlapWhenDisable");
		bTriggerEndOverlapWhenDisable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bTriggerEndOverlapWhenDisable");
		bTriggerEndOverlapWhenDisable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bTriggerEndOverlapWhenDisable", Classes.FBoolProperty);
	}

	static BUS_BuffTriggerAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BuffTriggerAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BuffTriggerAreaConfigComp));
	}
}
