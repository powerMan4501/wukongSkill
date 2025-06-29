using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGU_FlowActor")]
public class BGU_FlowActor : BGUActorBaseCS
{
	private static bool FlowActorType_IsValid;

	private static int FlowActorType_Offset;

	private static FFieldAddress FlowActorType_PropertyAddress;

	private static bool RootFlow_IsValid;

	private static int RootFlow_Offset;

	private static bool bAutoStartRootFlow_IsValid;

	private static int bAutoStartRootFlow_Offset;

	private static FFieldAddress bAutoStartRootFlow_PropertyAddress;

	private static bool bAllowMultipleInstances_IsValid;

	private static int bAllowMultipleInstances_Offset;

	private static FFieldAddress bAllowMultipleInstances_PropertyAddress;

	private static bool bAutoEnableOverlap_IsValid;

	private static int bAutoEnableOverlap_Offset;

	private static FFieldAddress bAutoEnableOverlap_PropertyAddress;

	private static bool SpawnUnitClass_IsValid;

	private static int SpawnUnitClass_Offset;

	private static bool SpawnMontage_IsValid;

	private static int SpawnMontage_Offset;

	private static bool bFaceToPlayer_IsValid;

	private static int bFaceToPlayer_Offset;

	private static FFieldAddress bFaceToPlayer_PropertyAddress;

	private static bool bAutoEnableDynamicObstacle_IsValid;

	private static int bAutoEnableDynamicObstacle_Offset;

	private static FFieldAddress bAutoEnableDynamicObstacle_PropertyAddress;

	private static bool bEnableDynamicObstacleCollisionDebug_IsValid;

	private static int bEnableDynamicObstacleCollisionDebug_Offset;

	private static FFieldAddress bEnableDynamicObstacleCollisionDebug_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("Flow")]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:FlowActorType")]
	public EFlowActorType FlowActorType
	{
		get
		{
			CheckDestroyed();
			if (!FlowActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:FlowActorType");
				return EFlowActorType.None;
			}
			return EnumMarshaler<EFlowActorType>.FromNative(IntPtr.Add(base.Address, FlowActorType_Offset), 0, FlowActorType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FlowActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:FlowActorType");
			}
			else
			{
				EnumMarshaler<EFlowActorType>.ToNative(IntPtr.Add(base.Address, FlowActorType_Offset), 0, FlowActorType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Flow|Root")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:RootFlow")]
	public UCalliopeAsset RootFlow
	{
		get
		{
			CheckDestroyed();
			if (!RootFlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:RootFlow");
				return null;
			}
			return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(base.Address, RootFlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootFlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:RootFlow");
			}
			else
			{
				UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(base.Address, RootFlow_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Flow|Root")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:bAutoStartRootFlow")]
	public bool bAutoStartRootFlow
	{
		get
		{
			CheckDestroyed();
			if (!bAutoStartRootFlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAutoStartRootFlow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoStartRootFlow_Offset), 0, bAutoStartRootFlow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoStartRootFlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAutoStartRootFlow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoStartRootFlow_Offset), 0, bAutoStartRootFlow_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Flow|Root")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:bAllowMultipleInstances")]
	public bool bAllowMultipleInstances
	{
		get
		{
			CheckDestroyed();
			if (!bAllowMultipleInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAllowMultipleInstances");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAllowMultipleInstances_Offset), 0, bAllowMultipleInstances_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAllowMultipleInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAllowMultipleInstances");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAllowMultipleInstances_Offset), 0, bAllowMultipleInstances_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Flow|Overlap")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:bAutoEnableOverlap")]
	public bool bAutoEnableOverlap
	{
		get
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAutoEnableOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAutoEnableOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("单位类")]
	[EditAnywhere]
	[UProperty]
	[Category("Flow|Spawn")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:SpawnUnitClass")]
	public TSubclassOf<AActor> SpawnUnitClass
	{
		get
		{
			CheckDestroyed();
			if (!SpawnUnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:SpawnUnitClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SpawnUnitClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnUnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:SpawnUnitClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SpawnUnitClass_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("单位出生动画")]
	[Category("Flow|Spawn")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:SpawnMontage")]
	public UAnimMontage SpawnMontage
	{
		get
		{
			CheckDestroyed();
			if (!SpawnMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:SpawnMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, SpawnMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:SpawnMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, SpawnMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位出生时是否面向玩家")]
	[Category("Flow|Spawn")]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:bFaceToPlayer")]
	public bool bFaceToPlayer
	{
		get
		{
			CheckDestroyed();
			if (!bFaceToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bFaceToPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFaceToPlayer_Offset), 0, bFaceToPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFaceToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bFaceToPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFaceToPlayer_Offset), 0, bFaceToPlayer_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Flow|DynamicObstacle")]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:bAutoEnableDynamicObstacle")]
	public bool bAutoEnableDynamicObstacle
	{
		get
		{
			CheckDestroyed();
			if (!bAutoEnableDynamicObstacle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAutoEnableDynamicObstacle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoEnableDynamicObstacle_Offset), 0, bAutoEnableDynamicObstacle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoEnableDynamicObstacle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bAutoEnableDynamicObstacle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoEnableDynamicObstacle_Offset), 0, bAutoEnableDynamicObstacle_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Flow|DynamicObstacle")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_FlowActor:bEnableDynamicObstacleCollisionDebug")]
	public bool bEnableDynamicObstacleCollisionDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDynamicObstacleCollisionDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bEnableDynamicObstacleCollisionDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDynamicObstacleCollisionDebug_Offset), 0, bEnableDynamicObstacleCollisionDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDynamicObstacleCollisionDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_FlowActor:bEnableDynamicObstacleCollisionDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDynamicObstacleCollisionDebug_Offset), 0, bEnableDynamicObstacleCollisionDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		switch (FlowActorType)
		{
		case EFlowActorType.None:
			break;
		case EFlowActorType.Overlap:
			base.ActorCompContainerCS.AddComp(new BUS_FlowOverlapComponent());
			break;
		case EFlowActorType.DynamicObstacle:
			base.ActorCompContainerCS.AddComp(new BUS_FlowDynamicObstacleComp());
			break;
		case EFlowActorType.Checker:
			base.ActorCompContainerCS.AddComp(new BUS_FlowCheckAreaDeathComp());
			break;
		case (EFlowActorType)1:
		case EFlowActorType.Spawn:
			break;
		}
	}

	protected override void CreateDataContainer(FObjectInitializer Initializer)
	{
		base.DataComp = Initializer.CreateDefaultSubobject<BUS_FlowDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGU_FlowActor");
		NativeReflection.GetPropertyRef(ref FlowActorType_PropertyAddress, unrealStruct, "FlowActorType");
		FlowActorType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FlowActorType");
		FlowActorType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FlowActorType", Classes.FEnumProperty);
		RootFlow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RootFlow");
		RootFlow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RootFlow", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bAutoStartRootFlow_PropertyAddress, unrealStruct, "bAutoStartRootFlow");
		bAutoStartRootFlow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoStartRootFlow");
		bAutoStartRootFlow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoStartRootFlow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAllowMultipleInstances_PropertyAddress, unrealStruct, "bAllowMultipleInstances");
		bAllowMultipleInstances_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAllowMultipleInstances");
		bAllowMultipleInstances_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAllowMultipleInstances", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAutoEnableOverlap_PropertyAddress, unrealStruct, "bAutoEnableOverlap");
		bAutoEnableOverlap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoEnableOverlap");
		bAutoEnableOverlap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoEnableOverlap", Classes.FBoolProperty);
		SpawnUnitClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnUnitClass");
		SpawnUnitClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnUnitClass", Classes.FClassProperty);
		SpawnMontage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnMontage");
		SpawnMontage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bFaceToPlayer_PropertyAddress, unrealStruct, "bFaceToPlayer");
		bFaceToPlayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFaceToPlayer");
		bFaceToPlayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFaceToPlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAutoEnableDynamicObstacle_PropertyAddress, unrealStruct, "bAutoEnableDynamicObstacle");
		bAutoEnableDynamicObstacle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoEnableDynamicObstacle");
		bAutoEnableDynamicObstacle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoEnableDynamicObstacle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableDynamicObstacleCollisionDebug_PropertyAddress, unrealStruct, "bEnableDynamicObstacleCollisionDebug");
		bEnableDynamicObstacleCollisionDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDynamicObstacleCollisionDebug");
		bEnableDynamicObstacleCollisionDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDynamicObstacleCollisionDebug", Classes.FBoolProperty);
	}

	static BGU_FlowActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_FlowActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_FlowActor));
	}
}
