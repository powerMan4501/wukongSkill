using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FlowDataComp")]
public class BUS_FlowDataComp : BUS_ActorBaseDataComp
{
	private BUC_FlowOverlapData OverlapData;

	private BUC_FlowDynamicObstacleData DynamicObstacleData;

	private static bool FlowActorType_IsValid;

	private static int FlowActorType_Offset;

	private static FFieldAddress FlowActorType_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_FlowDataComp:FlowActorType")]
	public EFlowActorType FlowActorType
	{
		get
		{
			CheckDestroyed();
			if (!FlowActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FlowDataComp:FlowActorType");
				return EFlowActorType.None;
			}
			return EnumMarshaler<EFlowActorType>.FromNative(IntPtr.Add(base.Address, FlowActorType_Offset), 0, FlowActorType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FlowActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FlowDataComp:FlowActorType");
			}
			else
			{
				EnumMarshaler<EFlowActorType>.ToNative(IntPtr.Add(base.Address, FlowActorType_Offset), 0, FlowActorType_PropertyAddress.Address, value);
			}
		}
	}

	private BGU_FlowActor OwnerAsFlowActor => GetOwner() as BGU_FlowActor;

	protected override void InitOnNewInCSImpl()
	{
		if (OwnerAsFlowActor != null)
		{
			FlowActorType = OwnerAsFlowActor.FlowActorType;
		}
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_FlowGeneralData>();
		switch (FlowActorType)
		{
		case EFlowActorType.Overlap:
			OverlapData = CreateDataClass<BUC_FlowOverlapData>();
			OverlapDataConvert();
			break;
		case EFlowActorType.DynamicObstacle:
			DynamicObstacleData = CreateDataClass<BUC_FlowDynamicObstacleData>();
			DynamicObstacleDataConvert();
			break;
		case EFlowActorType.Checker:
			CreateDataClass<BUC_FlowCheckerData>();
			break;
		case (EFlowActorType)1:
		case EFlowActorType.Spawn:
			break;
		case EFlowActorType.None:
			break;
		}
	}

	private void OverlapDataConvert()
	{
		OverlapData.bAutoEnableOverlap = OwnerAsFlowActor.bAutoEnableOverlap;
	}

	private void DynamicObstacleDataConvert()
	{
		DynamicObstacleData.bAutoEnable = OwnerAsFlowActor.bAutoEnableDynamicObstacle;
		DynamicObstacleData.bEnableDebug = OwnerAsFlowActor.bEnableDynamicObstacleCollisionDebug;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_FlowDataComp");
		NativeReflection.GetPropertyRef(ref FlowActorType_PropertyAddress, unrealStruct, "FlowActorType");
		FlowActorType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FlowActorType");
		FlowActorType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FlowActorType", Classes.FEnumProperty);
	}

	static BUS_FlowDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FlowDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FlowDataComp));
	}
}
