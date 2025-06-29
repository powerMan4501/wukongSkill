using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp")]
public class BUS_SplineFlyMoveTriggerConfigComp : UActorEditCompBase
{
	private static bool SplineFlyMoveConfigs_IsValid;

	private static int SplineFlyMoveConfigs_Offset;

	private static FFieldAddress SplineFlyMoveConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<FSplineFlyMoveConfig> SplineFlyMoveConfigs_Marshaler;

	private static bool OnlyTransitionPlayerCanTrigger_IsValid;

	private static int OnlyTransitionPlayerCanTrigger_Offset;

	private static FFieldAddress OnlyTransitionPlayerCanTrigger_PropertyAddress;

	private static bool IsPlayerObserveMode_IsValid;

	private static int IsPlayerObserveMode_Offset;

	private static FFieldAddress IsPlayerObserveMode_PropertyAddress;

	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	private static bool TraceVelocityCameraSpeedRate_IsValid;

	private static int TraceVelocityCameraSpeedRate_Offset;

	private static bool bDestoryControlledUnitInActived_IsValid;

	private static int bDestoryControlledUnitInActived_Offset;

	private static FFieldAddress bDestoryControlledUnitInActived_PropertyAddress;

	private static bool SceneItem_IsValid;

	private static int SceneItem_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("SplineFlyMoveTrigger config")]
	[DisplayName("飞行配置组")]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:SplineFlyMoveConfigs")]
	public TArrayReadWrite<FSplineFlyMoveConfig> SplineFlyMoveConfigs
	{
		get
		{
			CheckDestroyed();
			if (!SplineFlyMoveConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:SplineFlyMoveConfigs");
				return null;
			}
			if (SplineFlyMoveConfigs_Marshaler == null)
			{
				SplineFlyMoveConfigs_Marshaler = new TArrayReadWriteMarshaler<FSplineFlyMoveConfig>(1, SplineFlyMoveConfigs_PropertyAddress, CachedMarshalingDelegates<FSplineFlyMoveConfig, FSplineFlyMoveConfig>.FromNative, CachedMarshalingDelegates<FSplineFlyMoveConfig, FSplineFlyMoveConfig>.ToNative);
			}
			return SplineFlyMoveConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, SplineFlyMoveConfigs_Offset));
		}
	}

	[DisplayName("是否只有主角变身单位可以触发")]
	[Category("SplineFlyMoveTrigger config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:OnlyTransitionPlayerCanTrigger")]
	public bool OnlyTransitionPlayerCanTrigger
	{
		get
		{
			CheckDestroyed();
			if (!OnlyTransitionPlayerCanTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:OnlyTransitionPlayerCanTrigger");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyTransitionPlayerCanTrigger_Offset), 0, OnlyTransitionPlayerCanTrigger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyTransitionPlayerCanTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:OnlyTransitionPlayerCanTrigger");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyTransitionPlayerCanTrigger_Offset), 0, OnlyTransitionPlayerCanTrigger_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否为主角旁观模式")]
	[Category("SplineFlyMoveTrigger config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:IsPlayerObserveMode")]
	public bool IsPlayerObserveMode
	{
		get
		{
			CheckDestroyed();
			if (!IsPlayerObserveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:IsPlayerObserveMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPlayerObserveMode_Offset), 0, IsPlayerObserveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPlayerObserveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:IsPlayerObserveMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPlayerObserveMode_Offset), 0, IsPlayerObserveMode_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("自动开启")]
	[EditAnywhere]
	[UProperty]
	[Category("SplineFlyMoveTrigger config")]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:AutoEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("SplineFlyMoveTrigger config")]
	[DisplayName("镜头追踪速度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:TraceVelocityCameraSpeedRate")]
	public float TraceVelocityCameraSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!TraceVelocityCameraSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:TraceVelocityCameraSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceVelocityCameraSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceVelocityCameraSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:TraceVelocityCameraSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceVelocityCameraSpeedRate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("SplineFlyMoveTrigger config")]
	[DisplayName("结束后销毁控制单位  不包括主角")]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:bDestoryControlledUnitInActived")]
	public bool bDestoryControlledUnitInActived
	{
		get
		{
			CheckDestroyed();
			if (!bDestoryControlledUnitInActived_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:bDestoryControlledUnitInActived");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDestoryControlledUnitInActived_Offset), 0, bDestoryControlledUnitInActived_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDestoryControlledUnitInActived_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:bDestoryControlledUnitInActived");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDestoryControlledUnitInActived_Offset), 0, bDestoryControlledUnitInActived_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("SplineFlyMoveTrigger config")]
	[DisplayName("结束后主角位置锚点")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:SceneItem")]
	public TSoftObject<BGUSceneItemBase> SceneItem
	{
		get
		{
			CheckDestroyed();
			if (!SceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:SceneItem");
				return default(TSoftObject<BGUSceneItemBase>);
			}
			return TSoftObjectMarshaler<BGUSceneItemBase>.FromNative(IntPtr.Add(base.Address, SceneItem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp:SceneItem");
			}
			else
			{
				TSoftObjectMarshaler<BGUSceneItemBase>.ToNative(IntPtr.Add(base.Address, SceneItem_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_SplineFlyMoveTriggerData bUC_SplineFlyMoveTriggerData = RequireWritableData<BUC_SplineFlyMoveTriggerData>();
		bUC_SplineFlyMoveTriggerData.ControlledCount = SplineFlyMoveConfigs.Count;
		foreach (FSplineFlyMoveConfig splineFlyMoveConfig in SplineFlyMoveConfigs)
		{
			if (splineFlyMoveConfig.UnitType == ESplineFlyUnitType.Monster)
			{
				TSoftObject<BUTamerActor> unit = splineFlyMoveConfig.Unit;
				if (unit.Value.IsNullOrDestroyed())
				{
					continue;
				}
			}
			bUC_SplineFlyMoveTriggerData.Configs.Add(new SplineMoveConfig(splineFlyMoveConfig));
		}
		bUC_SplineFlyMoveTriggerData.OnlyTransitionPlayerCanTrigger = OnlyTransitionPlayerCanTrigger;
		bUC_SplineFlyMoveTriggerData.TraceVelocityCameraSpeedRate = TraceVelocityCameraSpeedRate;
		bUC_SplineFlyMoveTriggerData.bDestoryControlledUnitInActived = bDestoryControlledUnitInActived;
		bUC_SplineFlyMoveTriggerData.bAutoEnable = AutoEnable;
		bUC_SplineFlyMoveTriggerData.IsPlayerObserveMode = IsPlayerObserveMode;
		bUC_SplineFlyMoveTriggerData.bUseTransform = false;
		if (SceneItem.IsValid && !SceneItem.Value.IsNullOrDestroyed())
		{
			bUC_SplineFlyMoveTriggerData.bUseTransform = true;
			bUC_SplineFlyMoveTriggerData.PlayerEndTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(SceneItem.Value);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SplineFlyMoveTriggerConfigComp");
		NativeReflection.GetPropertyRef(ref SplineFlyMoveConfigs_PropertyAddress, unrealStruct, "SplineFlyMoveConfigs");
		SplineFlyMoveConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineFlyMoveConfigs");
		SplineFlyMoveConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineFlyMoveConfigs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OnlyTransitionPlayerCanTrigger_PropertyAddress, unrealStruct, "OnlyTransitionPlayerCanTrigger");
		OnlyTransitionPlayerCanTrigger_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnlyTransitionPlayerCanTrigger");
		OnlyTransitionPlayerCanTrigger_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnlyTransitionPlayerCanTrigger", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsPlayerObserveMode_PropertyAddress, unrealStruct, "IsPlayerObserveMode");
		IsPlayerObserveMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsPlayerObserveMode");
		IsPlayerObserveMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsPlayerObserveMode", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
		TraceVelocityCameraSpeedRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceVelocityCameraSpeedRate");
		TraceVelocityCameraSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceVelocityCameraSpeedRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bDestoryControlledUnitInActived_PropertyAddress, unrealStruct, "bDestoryControlledUnitInActived");
		bDestoryControlledUnitInActived_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDestoryControlledUnitInActived");
		bDestoryControlledUnitInActived_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDestoryControlledUnitInActived", Classes.FBoolProperty);
		SceneItem_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneItem");
		SceneItem_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneItem", Classes.FSoftObjectProperty);
	}

	static BUS_SplineFlyMoveTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SplineFlyMoveTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SplineFlyMoveTriggerConfigComp));
	}
}
