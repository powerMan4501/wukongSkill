using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGU_DebugActor")]
public class BGU_DebugActor : ABGUActorBase
{
	private static bool SceneRoot_IsValid;

	private static int SceneRoot_Offset;

	private static bool SightPerceptionDebugSector_IsValid;

	private static int SightPerceptionDebugSector_Offset;

	private static bool HearingPerceptionDebugCircle_IsValid;

	private static int HearingPerceptionDebugCircle_Offset;

	private static bool WakeUpRangeCylinder_IsValid;

	private static int WakeUpRangeCylinder_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BGU_DebugActor:SceneRoot")]
	private USceneComponent SceneRoot
	{
		get
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:SceneRoot");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:SceneRoot");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneRoot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BGU_DebugActor:SightPerceptionDebugSector")]
	public UBGUDebugSectorComponent SightPerceptionDebugSector
	{
		get
		{
			CheckDestroyed();
			if (!SightPerceptionDebugSector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:SightPerceptionDebugSector");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, SightPerceptionDebugSector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SightPerceptionDebugSector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:SightPerceptionDebugSector");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, SightPerceptionDebugSector_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BGU_DebugActor:HearingPerceptionDebugCircle")]
	public UBGUDebugCircleComponent HearingPerceptionDebugCircle
	{
		get
		{
			CheckDestroyed();
			if (!HearingPerceptionDebugCircle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:HearingPerceptionDebugCircle");
				return null;
			}
			return UObjectMarshaler<UBGUDebugCircleComponent>.FromNative(IntPtr.Add(base.Address, HearingPerceptionDebugCircle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HearingPerceptionDebugCircle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:HearingPerceptionDebugCircle");
			}
			else
			{
				UObjectMarshaler<UBGUDebugCircleComponent>.ToNative(IntPtr.Add(base.Address, HearingPerceptionDebugCircle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_DebugActor:WakeUpRangeCylinder")]
	public UStaticMeshComponent WakeUpRangeCylinder
	{
		get
		{
			CheckDestroyed();
			if (!WakeUpRangeCylinder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:WakeUpRangeCylinder");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, WakeUpRangeCylinder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WakeUpRangeCylinder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DebugActor:WakeUpRangeCylinder");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, WakeUpRangeCylinder_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		if (UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			SceneRoot = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.SceneRoot);
			base.RootComponent = SceneRoot;
			SightPerceptionDebugSector = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.SightPerceptionDebugSector);
			SightPerceptionDebugSector.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			SightPerceptionDebugSector.ShapeColor = new FColor(0, byte.MaxValue, 0);
			HearingPerceptionDebugCircle = initializer.CreateDefaultSubobject<UBGUDebugCircleComponent>(this, B1GlobalFNames.HearingPerceptionDebugCircle);
			HearingPerceptionDebugCircle.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			HearingPerceptionDebugCircle.ShapeColor = new FColor(0, 0, byte.MaxValue);
			WakeUpRangeCylinder = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.WakeUpRangeCylinder);
			WakeUpRangeCylinder.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			WakeUpRangeCylinder.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			WakeUpRangeCylinder.SetVisibility(bNewVisibility: false);
		}
	}

	[USharpPath("/Script/b1-Managed.BGU_DebugActor:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		if (UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			BUTamerActor bUTamerActor = GetParentActor() as BUTamerActor;
			if (!(bUTamerActor == null))
			{
				UpdatePerceptionComps(bUTamerActor);
				UpdateWakeUpComps(bUTamerActor);
			}
		}
	}

	public void OnUpdateWhenParentActorChange(BUTamerActor ParentActor)
	{
		UpdatePerceptionComps(ParentActor);
		UpdateWakeUpComps(ParentActor);
	}

	[USharpPath("/Script/b1-Managed.BGU_DebugActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
		if (!UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			return;
		}
		AActor parentActor = GetParentActor();
		if (!(parentActor == null))
		{
			BUC_UnitDebugData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitDebugData>(parentActor);
			if (readOnlyData != null)
			{
				readOnlyData.DebugActor = this;
			}
		}
	}

	private void UpdatePerceptionComps(BUTamerActor ParentActor)
	{
		ParentActor.GetActorEyesViewPoint(out var OutLocation, out var _);
		SightPerceptionDebugSector.SetWorldLocation(OutLocation, bSweep: false, out var _, bTeleport: false);
		BUS_ExtendConfigComp componentByClass = ParentActor.GetComponentByClass<BUS_ExtendConfigComp>();
		if (componentByClass != null && componentByClass.bEnablePerceptionPreview)
		{
			FUnitAIDesc fUnitAIDesc = BGUFuncLibNonRuntime.BGUGetUnitAIDesc(ParentActor);
			SightPerceptionDebugSector.SetVisibility(bNewVisibility: true);
			SightPerceptionDebugSector.SetSectorRadius(fUnitAIDesc.SightRange);
			SightPerceptionDebugSector.SetSectorMinAngle(0f - fUnitAIDesc.VisionAngleDegrees);
			SightPerceptionDebugSector.SetSectorMaxAngle(fUnitAIDesc.VisionAngleDegrees);
			HearingPerceptionDebugCircle.SetVisibility(bNewVisibility: true);
			HearingPerceptionDebugCircle.SetCircleRadius(fUnitAIDesc.HearRange);
		}
		else
		{
			SightPerceptionDebugSector.SetVisibility(bNewVisibility: false);
			HearingPerceptionDebugCircle.SetVisibility(bNewVisibility: false);
		}
	}

	private void UpdateWakeUpComps(AActor ParentActor)
	{
		BUS_ExtendConfigComp componentByClass = ParentActor.GetComponentByClass<BUS_ExtendConfigComp>();
		if (componentByClass != null && componentByClass.bEnableWakeUpLinkRangeDebug)
		{
			if (componentByClass.WakeUpConfig.RangeType == ERangeType.Cylinder)
			{
				float rangeParam_ = componentByClass.WakeUpConfig.RangeParam_1;
				float rangeParam_2 = componentByClass.WakeUpConfig.RangeParam_2;
				float rangeParam_3 = componentByClass.WakeUpConfig.RangeParam_3;
				WakeUpRangeCylinder.SetRelativeLocation(new FVector(0.0, 0.0, (rangeParam_2 - rangeParam_3) / 2f), bSweep: false, out var _, bTeleport: false);
				WakeUpRangeCylinder.SetRelativeScale3D(new FVector(rangeParam_ / 50f, rangeParam_ / 50f, (rangeParam_2 + rangeParam_3) / 100f));
				WakeUpRangeCylinder.SetVisibility(bNewVisibility: true);
			}
		}
		else
		{
			WakeUpRangeCylinder.SetVisibility(bNewVisibility: false);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_DebugActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_DebugActor bGU_DebugActor = GCHelper.Find<BGU_DebugActor>(obj);
		bGU_DebugActor.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_DebugActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_DebugActor bGU_DebugActor = GCHelper.Find<BGU_DebugActor>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGU_DebugActor.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_DebugActor");
		SceneRoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneRoot");
		SceneRoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneRoot", Classes.FObjectProperty);
		SightPerceptionDebugSector_Offset = NativeReflection.GetPropertyOffset(intPtr, "SightPerceptionDebugSector");
		SightPerceptionDebugSector_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SightPerceptionDebugSector", Classes.FObjectProperty);
		HearingPerceptionDebugCircle_Offset = NativeReflection.GetPropertyOffset(intPtr, "HearingPerceptionDebugCircle");
		HearingPerceptionDebugCircle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HearingPerceptionDebugCircle", Classes.FObjectProperty);
		WakeUpRangeCylinder_Offset = NativeReflection.GetPropertyOffset(intPtr, "WakeUpRangeCylinder");
		WakeUpRangeCylinder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WakeUpRangeCylinder", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_DebugActor:BeginPlayCS", BeginPlayCS_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_DebugActor:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGU_DebugActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_DebugActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_DebugActor));
	}
}
