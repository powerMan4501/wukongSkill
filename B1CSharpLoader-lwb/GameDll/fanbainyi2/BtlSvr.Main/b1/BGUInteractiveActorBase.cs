using System;
using System.Collections.Generic;
using BtlB1;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase")]
public class BGUInteractiveActorBase : BGUActorBaseCS
{
	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	private static bool InteractComp_IsValid;

	private static int InteractComp_Offset;

	private static bool InteractRangeDebugComp_IsValid;

	private static int InteractRangeDebugComp_Offset;

	private static bool InteractRangeDebugComp2_IsValid;

	private static int InteractRangeDebugComp2_Offset;

	private static bool InteractRangeDebugComp3_IsValid;

	private static int InteractRangeDebugComp3_Offset;

	private static bool CallBPFunc_IsValid;

	private static IntPtr CallBPFunc_FunctionAddress;

	private static int CallBPFunc_ParamsSize;

	private IntPtr CallBPFunc_InstanceFunctionAddressInstance;

	private static bool OnHitDestructible_IsValid;

	private static IntPtr OnHitDestructible_FunctionAddress;

	private static int OnHitDestructible_ParamsSize;

	private static bool OnHitDestructible_HitLocation_IsValid;

	private static int OnHitDestructible_HitLocation_Offset;

	private static FFieldAddress OnHitDestructible_HitLocation_PropertyAddress;

	private static bool OnHitDestructible_ImpulseDir_IsValid;

	private static int OnHitDestructible_ImpulseDir_Offset;

	private static FFieldAddress OnHitDestructible_ImpulseDir_PropertyAddress;

	private static bool OnHitDestructible_ImpulseStrength_IsValid;

	private static int OnHitDestructible_ImpulseStrength_Offset;

	private static bool OnHitDestructible_Damage_IsValid;

	private static int OnHitDestructible_Damage_Offset;

	private IntPtr OnHitDestructible_InstanceFunctionAddressInstance;

	private static bool OnResetDestructible_IsValid;

	private static IntPtr OnResetDestructible_FunctionAddress;

	private static int OnResetDestructible_ParamsSize;

	private static bool OnResetDestructible_IsDestroyed_IsValid;

	private static int OnResetDestructible_IsDestroyed_Offset;

	private static FFieldAddress OnResetDestructible_IsDestroyed_PropertyAddress;

	private IntPtr OnResetDestructible_InstanceFunctionAddressInstance;

	private static bool OnDestroyDestructible_IsValid;

	private static IntPtr OnDestroyDestructible_FunctionAddress;

	private static int OnDestroyDestructible_ParamsSize;

	private static bool OnDestroyDestructible_HitLocation_IsValid;

	private static int OnDestroyDestructible_HitLocation_Offset;

	private static FFieldAddress OnDestroyDestructible_HitLocation_PropertyAddress;

	private static bool OnDestroyDestructible_ImpulseDir_IsValid;

	private static int OnDestroyDestructible_ImpulseDir_Offset;

	private static FFieldAddress OnDestroyDestructible_ImpulseDir_PropertyAddress;

	private static bool OnDestroyDestructible_ImpulseStrength_IsValid;

	private static int OnDestroyDestructible_ImpulseStrength_Offset;

	private static bool OnDestroyDestructible_Damage_IsValid;

	private static int OnDestroyDestructible_Damage_Offset;

	private IntPtr OnDestroyDestructible_InstanceFunctionAddressInstance;

	private static bool RefreshInteractDebugRange_IsValid;

	private static IntPtr RefreshInteractDebugRange_FunctionAddress;

	private static int RefreshInteractDebugRange_ParamsSize;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:DefaultRootComp")]
	private USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:InteractComp")]
	public BUS_InteractComp InteractComp
	{
		get
		{
			CheckDestroyed();
			if (!InteractComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractComp");
				return null;
			}
			return UObjectMarshaler<BUS_InteractComp>.FromNative(IntPtr.Add(base.Address, InteractComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractComp");
			}
			else
			{
				UObjectMarshaler<BUS_InteractComp>.ToNative(IntPtr.Add(base.Address, InteractComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp")]
	public UBGUDebugSectorComponent InteractRangeDebugComp
	{
		get
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, InteractRangeDebugComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, InteractRangeDebugComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp2")]
	public UBGUDebugSectorComponent InteractRangeDebugComp2
	{
		get
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp2");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, InteractRangeDebugComp2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp2");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, InteractRangeDebugComp2_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp3")]
	public UBGUDebugSectorComponent InteractRangeDebugComp3
	{
		get
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp3");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, InteractRangeDebugComp3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUInteractiveActorBase:InteractRangeDebugComp3");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, InteractRangeDebugComp3_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		SetRootComponentCS(DefaultRootComp);
		InteractComp = initializer.CreateDefaultSubobject<BUS_InteractComp>(this, B1GlobalFNames.InteractSystem);
		InteractRangeDebugComp = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.InteractRangeDebugComp);
		InteractRangeDebugComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		InteractRangeDebugComp.ShapeColor = FColor.Pink;
		InteractRangeDebugComp2 = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.InteractRangeDebugComp2);
		InteractRangeDebugComp2.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		InteractRangeDebugComp2.ShapeColor = FColor.YellowGreen;
		InteractRangeDebugComp3 = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.InteractRangeDebugComp3);
		InteractRangeDebugComp3.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		InteractRangeDebugComp3.ShapeColor = FColor.OrangeRed;
		base.Replicates = true;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_InteractCompImpl());
		base.ActorCompContainerCS.AddComp(new b1.BUS_AnimationSyncHostComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_AnimationSyncGuestComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_TickRateLogicSimpleComp());
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_AKMgrComp>(1);
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		bGW_ECSWorld?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		UMeshComponent meshByCollectionType = GetMeshByCollectionType();
		if (meshByCollectionType != null)
		{
			BUC_DispLibUnitRendererBaseData bUC_DispLibUnitRendererBaseData = CreateDataClass<BUC_DispLibUnitRendererBaseData>(bGW_ECSWorld);
			bUC_DispLibUnitRendererBaseData.Init(100f, 100, meshByCollectionType);
			CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>(bGW_ECSWorld).Init(bUC_DispLibUnitRendererBaseData);
			CreateDataClass<BUC_DispLibDBCBaseData>(bGW_ECSWorld).Init(meshByCollectionType, DispLibDBCActorGroup.Interact);
			CreateDataClass<BUC_DispLibDBCQueueData>(bGW_ECSWorld).Init();
			base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
			base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp(), 1);
		}
		foreach (UActorComponent item in GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			UGSE_SkeletalMeshFuncLib.SetUpdateOverlapsOnAnimationFinalize(item as USkeletalMeshComponent, bVal: false);
		}
	}

	protected virtual UMeshComponent GetMeshByCollectionType()
	{
		List<UActorComponent> componentsByClass = GetComponentsByClass(UClass.GetClass<UMeshComponent>());
		if (componentsByClass.Count == 1)
		{
			if (!(componentsByClass[0] is UWidgetComponent))
			{
				return componentsByClass[0] as UMeshComponent;
			}
		}
		else
		{
			foreach (UActorComponent item in componentsByClass)
			{
				if (item.ComponentHasTag(B1GlobalFNames.master))
				{
					return item as UMeshComponent;
				}
			}
		}
		return null;
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_InteractiveActorDataComp>(this, B1GlobalFNames.InteractiveActorDataComp);
	}

	protected T CreateDataClass<T>(BGW_ECSWorld ECSWorld) where T : class, new()
	{
		T val = new T();
		ECSWorld?.SetObject(base.ECSEntity, val);
		return val;
	}

	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		if (UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			RefreshInteractRange();
		}
	}

	private void RefreshInteractRange()
	{
		FUStInteractiveUnitCommDesc fUStInteractiveUnitCommDesc = null;
		if (InteractComp.InteractiveUnitID > 0)
		{
			fUStInteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(InteractComp.InteractiveUnitID);
			if (fUStInteractiveUnitCommDesc == null && BGW_GameDB.GetAllInteractiveUnitCommDesc().Count == 0)
			{
				BGUFuncLibNonRuntime.LoadProtobufData<FUStInteractiveUnitCommDesc>();
				fUStInteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(InteractComp.InteractiveUnitID);
			}
		}
		if (fUStInteractiveUnitCommDesc == null)
		{
			InteractRangeDebugComp.SetVisibility(bNewVisibility: false);
			InteractRangeDebugComp.SetActive(bNewActive: false);
			InteractRangeDebugComp2.SetVisibility(bNewVisibility: false);
			InteractRangeDebugComp2.SetActive(bNewActive: false);
			InteractRangeDebugComp3.SetVisibility(bNewVisibility: false);
			InteractRangeDebugComp3.SetActive(bNewActive: false);
			return;
		}
		List<UActorComponent> componentsByTag = GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.GSInteractRangeAnchor);
		if (componentsByTag.Count > 0)
		{
			InteractRangeDebugComp.SetRelativeLocation((componentsByTag[0] as USceneComponent).RelativeLocation, bSweep: false, out var SweepHitResult, bTeleport: true);
			InteractRangeDebugComp2.SetRelativeLocation((componentsByTag[0] as USceneComponent).RelativeLocation, bSweep: false, out SweepHitResult, bTeleport: true);
			InteractRangeDebugComp3.SetRelativeLocation((componentsByTag[0] as USceneComponent).RelativeLocation, bSweep: false, out SweepHitResult, bTeleport: true);
		}
		InteractRangeDebugComp.SetSectorRadius(fUStInteractiveUnitCommDesc.InteractDistance);
		InteractRangeDebugComp.SetSectorMinAngle((0f - fUStInteractiveUnitCommDesc.InteractAngle) / 2f);
		InteractRangeDebugComp.SetSectorMaxAngle(fUStInteractiveUnitCommDesc.InteractAngle / 2f);
		if (!InteractRangeDebugComp.IsVisible())
		{
			InteractRangeDebugComp.SetVisibility(bNewVisibility: true);
			InteractRangeDebugComp.SetActive(bNewActive: true);
		}
		float num = ((InteractComp.ActivableDistance <= 0f) ? fUStInteractiveUnitCommDesc.ActivableDistance : InteractComp.ActivableDistance);
		InteractRangeDebugComp2.SetSectorRadius(num);
		InteractRangeDebugComp2.SetSectorMinAngle(-180f);
		InteractRangeDebugComp2.SetSectorMaxAngle(180f);
		if (!InteractRangeDebugComp2.IsVisible())
		{
			InteractRangeDebugComp2.SetVisibility(bNewVisibility: true);
			InteractRangeDebugComp2.SetActive(bNewActive: true);
		}
		InteractRangeDebugComp3.SetSectorRadius(UBGWFunctionLibraryCS.GetLeaveActivableDistance(num));
		InteractRangeDebugComp3.SetSectorMinAngle(-180f);
		InteractRangeDebugComp3.SetSectorMaxAngle(180f);
		if (!InteractRangeDebugComp3.IsVisible())
		{
			InteractRangeDebugComp3.SetVisibility(bNewVisibility: true);
			InteractRangeDebugComp3.SetActive(bNewActive: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:CallBPFunc")]
	public unsafe void CallBPFunc()
	{
		CheckDestroyed();
		if (!CallBPFunc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUInteractiveActorBase:CallBPFunc");
			return;
		}
		if (CallBPFunc_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			CallBPFunc_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "CallBPFunc");
		}
		byte* value = stackalloc byte[(int)(uint)CallBPFunc_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, CallBPFunc_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, CallBPFunc_InstanceFunctionAddressInstance, intPtr, CallBPFunc_ParamsSize);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:RefreshInteractDebugRange")]
	public void RefreshInteractDebugRange()
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			BGUFunctionLibraryCS.RefreshGameDB();
			RefreshInteractRange();
		}
	}

	[BlueprintCallable]
	[DisplayName("【已过期】OnHitDestructible")]
	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:OnHitDestructible")]
	public unsafe void OnHitDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength, float Damage)
	{
		CheckDestroyed();
		if (!OnHitDestructible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUInteractiveActorBase:OnHitDestructible");
			return;
		}
		if (OnHitDestructible_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnHitDestructible_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnHitDestructible");
		}
		byte* value = stackalloc byte[(int)(uint)OnHitDestructible_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnHitDestructible_ParamsSize);
		NativeReflection.InitializeValue_InContainer(OnHitDestructible_HitLocation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_HitLocation_Offset), HitLocation);
		NativeReflection.InitializeValue_InContainer(OnHitDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_ImpulseDir_Offset), ImpulseDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_ImpulseStrength_Offset), ImpulseStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_Damage_Offset), Damage);
		NativeReflection.InvokeFunction(base.Address, OnHitDestructible_InstanceFunctionAddressInstance, intPtr, OnHitDestructible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnHitDestructible_HitLocation_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnHitDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
	}

	[DisplayName("蓝图响应触发破碎")]
	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:OnDestroyDestructible")]
	public unsafe void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength, float Damage)
	{
		CheckDestroyed();
		if (!OnDestroyDestructible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUInteractiveActorBase:OnDestroyDestructible");
			return;
		}
		if (OnDestroyDestructible_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnDestroyDestructible_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnDestroyDestructible");
		}
		byte* value = stackalloc byte[(int)(uint)OnDestroyDestructible_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnDestroyDestructible_ParamsSize);
		NativeReflection.InitializeValue_InContainer(OnDestroyDestructible_HitLocation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_HitLocation_Offset), HitLocation);
		NativeReflection.InitializeValue_InContainer(OnDestroyDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_ImpulseDir_Offset), ImpulseDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_ImpulseStrength_Offset), ImpulseStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_Damage_Offset), Damage);
		NativeReflection.InvokeFunction(base.Address, OnDestroyDestructible_InstanceFunctionAddressInstance, intPtr, OnDestroyDestructible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDestroyDestructible_HitLocation_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnDestroyDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
	}

	[DisplayName("蓝图响应触发重置")]
	[BlueprintImplementedEvent]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUInteractiveActorBase:OnResetDestructible")]
	public unsafe void OnResetDestructible(bool IsDestroyed)
	{
		CheckDestroyed();
		if (!OnResetDestructible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUInteractiveActorBase:OnResetDestructible");
			return;
		}
		if (OnResetDestructible_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnResetDestructible_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetDestructible");
		}
		byte* value = stackalloc byte[(int)(uint)OnResetDestructible_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnResetDestructible_ParamsSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnResetDestructible_IsDestroyed_Offset), 0, OnResetDestructible_IsDestroyed_PropertyAddress.Address, IsDestroyed);
		NativeReflection.InvokeFunction(base.Address, OnResetDestructible_InstanceFunctionAddressInstance, intPtr, OnResetDestructible_ParamsSize);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUInteractiveActorBase:RefreshInteractDebugRange")]
	private static void RefreshInteractDebugRange__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUInteractiveActorBase bGUInteractiveActorBase = GCHelper.Find<BGUInteractiveActorBase>(obj);
		bGUInteractiveActorBase.RefreshInteractDebugRange();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUInteractiveActorBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUInteractiveActorBase bGUInteractiveActorBase = GCHelper.Find<BGUInteractiveActorBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUInteractiveActorBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUInteractiveActorBase");
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRootComp", Classes.FObjectProperty);
		InteractComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractComp");
		InteractComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractComp", Classes.FObjectProperty);
		InteractRangeDebugComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractRangeDebugComp");
		InteractRangeDebugComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractRangeDebugComp", Classes.FObjectProperty);
		InteractRangeDebugComp2_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractRangeDebugComp2");
		InteractRangeDebugComp2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractRangeDebugComp2", Classes.FObjectProperty);
		InteractRangeDebugComp3_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractRangeDebugComp3");
		InteractRangeDebugComp3_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractRangeDebugComp3", Classes.FObjectProperty);
		CallBPFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CallBPFunc");
		CallBPFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(CallBPFunc_FunctionAddress);
		CallBPFunc_IsValid = CallBPFunc_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUInteractiveActorBase:CallBPFunc", CallBPFunc_IsValid);
		OnHitDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnHitDestructible");
		OnHitDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnHitDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnHitDestructible_HitLocation_PropertyAddress, OnHitDestructible_FunctionAddress, "HitLocation");
		OnHitDestructible_HitLocation_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "HitLocation");
		OnHitDestructible_HitLocation_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnHitDestructible_ImpulseDir_PropertyAddress, OnHitDestructible_FunctionAddress, "ImpulseDir");
		OnHitDestructible_ImpulseDir_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "ImpulseDir");
		OnHitDestructible_ImpulseDir_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "ImpulseDir", Classes.FStructProperty);
		OnHitDestructible_ImpulseStrength_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "ImpulseStrength");
		OnHitDestructible_ImpulseStrength_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		OnHitDestructible_Damage_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "Damage");
		OnHitDestructible_Damage_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "Damage", Classes.FFloatProperty);
		OnHitDestructible_IsValid = OnHitDestructible_FunctionAddress != IntPtr.Zero && OnHitDestructible_HitLocation_IsValid && OnHitDestructible_ImpulseDir_IsValid && OnHitDestructible_ImpulseStrength_IsValid && OnHitDestructible_Damage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUInteractiveActorBase:OnHitDestructible", OnHitDestructible_IsValid);
		OnResetDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnResetDestructible");
		OnResetDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnResetDestructible_IsDestroyed_PropertyAddress, OnResetDestructible_FunctionAddress, "IsDestroyed");
		OnResetDestructible_IsDestroyed_Offset = NativeReflection.GetPropertyOffset(OnResetDestructible_FunctionAddress, "IsDestroyed");
		OnResetDestructible_IsDestroyed_IsValid = NativeReflection.ValidatePropertyClass(OnResetDestructible_FunctionAddress, "IsDestroyed", Classes.FBoolProperty);
		OnResetDestructible_IsValid = OnResetDestructible_FunctionAddress != IntPtr.Zero && OnResetDestructible_IsDestroyed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUInteractiveActorBase:OnResetDestructible", OnResetDestructible_IsValid);
		OnDestroyDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDestroyDestructible");
		OnDestroyDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestroyDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDestroyDestructible_HitLocation_PropertyAddress, OnDestroyDestructible_FunctionAddress, "HitLocation");
		OnDestroyDestructible_HitLocation_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "HitLocation");
		OnDestroyDestructible_HitLocation_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnDestroyDestructible_ImpulseDir_PropertyAddress, OnDestroyDestructible_FunctionAddress, "ImpulseDir");
		OnDestroyDestructible_ImpulseDir_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "ImpulseDir");
		OnDestroyDestructible_ImpulseDir_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "ImpulseDir", Classes.FStructProperty);
		OnDestroyDestructible_ImpulseStrength_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "ImpulseStrength");
		OnDestroyDestructible_ImpulseStrength_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		OnDestroyDestructible_Damage_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "Damage");
		OnDestroyDestructible_Damage_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "Damage", Classes.FFloatProperty);
		OnDestroyDestructible_IsValid = OnDestroyDestructible_FunctionAddress != IntPtr.Zero && OnDestroyDestructible_HitLocation_IsValid && OnDestroyDestructible_ImpulseDir_IsValid && OnDestroyDestructible_ImpulseStrength_IsValid && OnDestroyDestructible_Damage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUInteractiveActorBase:OnDestroyDestructible", OnDestroyDestructible_IsValid);
		RefreshInteractDebugRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshInteractDebugRange");
		RefreshInteractDebugRange_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshInteractDebugRange_FunctionAddress);
		RefreshInteractDebugRange_IsValid = RefreshInteractDebugRange_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUInteractiveActorBase:RefreshInteractDebugRange", RefreshInteractDebugRange_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUInteractiveActorBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUInteractiveActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUInteractiveActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUInteractiveActorBase));
	}
}
