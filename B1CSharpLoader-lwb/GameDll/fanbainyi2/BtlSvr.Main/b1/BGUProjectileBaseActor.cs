using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor")]
public abstract class BGUProjectileBaseActor : BGUSimpleActorBaseCS, ITeamCS
{
	private AActor AttachParentActor_Cached;

	private bool bOpenDebugMode;

	private static bool ProjectileMovement_IsValid;

	private static int ProjectileMovement_Offset;

	private static bool SphereCollisionComp_IsValid;

	private static int SphereCollisionComp_Offset;

	private static bool BoxCollisionComp_IsValid;

	private static int BoxCollisionComp_Offset;

	private static bool CapsuleCollisionComp_IsValid;

	private static int CapsuleCollisionComp_Offset;

	private static bool CustomCollisionComp_IsValid;

	private static int CustomCollisionComp_Offset;

	private static bool LineTraceStartPoint_IsValid;

	private static int LineTraceStartPoint_Offset;

	private static bool StaticComp_IsValid;

	private static int StaticComp_Offset;

	private static bool Interact_Start_IsValid;

	private static int Interact_Start_Offset;

	private static bool Interact_End_IsValid;

	private static int Interact_End_Offset;

	private static bool ProjectileConfigInfoComp_IsValid;

	private static int ProjectileConfigInfoComp_Offset;

	private static bool OnDead_IsValid;

	private static IntPtr OnDead_FunctionAddress;

	private static int OnDead_ParamsSize;

	private IntPtr OnDead_InstanceFunctionAddressInstance;

	private static bool SwitchPre_IsValid;

	private static IntPtr SwitchPre_FunctionAddress;

	private static int SwitchPre_ParamsSize;

	private IntPtr SwitchPre_InstanceFunctionAddressInstance;

	private static bool OnDrawSign_IsValid;

	private static IntPtr OnDrawSign_FunctionAddress;

	private static int OnDrawSign_ParamsSize;

	private static bool OnDrawSign_HitActor_IsValid;

	private static int OnDrawSign_HitActor_Offset;

	private static bool OnDrawSign_HitTransform_IsValid;

	private static int OnDrawSign_HitTransform_Offset;

	private static FFieldAddress OnDrawSign_HitTransform_PropertyAddress;

	private IntPtr OnDrawSign_InstanceFunctionAddressInstance;

	private static bool SwitchBegin_IsValid;

	private static IntPtr SwitchBegin_FunctionAddress;

	private static int SwitchBegin_ParamsSize;

	private IntPtr SwitchBegin_InstanceFunctionAddressInstance;

	private static bool SpawnFinished_IsValid;

	private static IntPtr SpawnFinished_FunctionAddress;

	private static int SpawnFinished_ParamsSize;

	private static bool SpawnFinished_ProjectileSpawnEventInfo_IsValid;

	private static int SpawnFinished_ProjectileSpawnEventInfo_Offset;

	private IntPtr SpawnFinished_InstanceFunctionAddressInstance;

	private static bool SwitchFinished_IsValid;

	private static IntPtr SwitchFinished_FunctionAddress;

	private static int SwitchFinished_ParamsSize;

	private IntPtr SwitchFinished_InstanceFunctionAddressInstance;

	private static bool GetProjectileID_IsValid;

	private static IntPtr GetProjectileID_FunctionAddress;

	private static int GetProjectileID_ParamsSize;

	private static bool GetProjectileID_ReturnValue_IsValid;

	private static int GetProjectileID_ReturnValue_Offset;

	private static bool GetProjectileMovement_IsValid;

	private static IntPtr GetProjectileMovement_FunctionAddress;

	private static int GetProjectileMovement_ParamsSize;

	private static bool GetProjectileMovement_ReturnValue_IsValid;

	private static int GetProjectileMovement_ReturnValue_Offset;

	private static bool CheckDrawSignCondition_IsValid;

	private static IntPtr CheckDrawSignCondition_FunctionAddress;

	private static int CheckDrawSignCondition_ParamsSize;

	private static bool CheckDrawSignCondition_HitActor_IsValid;

	private static int CheckDrawSignCondition_HitActor_Offset;

	private static bool CheckDrawSignCondition_ReturnValue_IsValid;

	private static int CheckDrawSignCondition_ReturnValue_Offset;

	private static FFieldAddress CheckDrawSignCondition_ReturnValue_PropertyAddress;

	private IntPtr CheckDrawSignCondition_InstanceFunctionAddressInstance;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool GetStaticMeshCompChildsNum_IsValid;

	private static IntPtr GetStaticMeshCompChildsNum_FunctionAddress;

	private static int GetStaticMeshCompChildsNum_ParamsSize;

	private static bool GetStaticMeshCompChildsNum_ReturnValue_IsValid;

	private static int GetStaticMeshCompChildsNum_ReturnValue_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static bool ProjectileAbilityCheck_ByBPConfig_IsValid;

	private static IntPtr ProjectileAbilityCheck_ByBPConfig_FunctionAddress;

	private static int ProjectileAbilityCheck_ByBPConfig_ParamsSize;

	private static bool ProjectileAbilityCheck_ByBPConfig_ReturnValue_IsValid;

	private static int ProjectileAbilityCheck_ByBPConfig_ReturnValue_Offset;

	private static FFieldAddress ProjectileAbilityCheck_ByBPConfig_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileMovement")]
	protected UBGUProjectileMovementComponent ProjectileMovement
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileMovement");
				return null;
			}
			return UObjectMarshaler<UBGUProjectileMovementComponent>.FromNative(IntPtr.Add(base.Address, ProjectileMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileMovement");
			}
			else
			{
				UObjectMarshaler<UBGUProjectileMovementComponent>.ToNative(IntPtr.Add(base.Address, ProjectileMovement_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:SphereCollisionComp")]
	protected USphereComponent SphereCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!SphereCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:SphereCollisionComp");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, SphereCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SphereCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:SphereCollisionComp");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, SphereCollisionComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:BoxCollisionComp")]
	protected UBoxComponent BoxCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!BoxCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:BoxCollisionComp");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BoxCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:BoxCollisionComp");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BoxCollisionComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:CapsuleCollisionComp")]
	protected UCapsuleComponent CapsuleCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:CapsuleCollisionComp");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:CapsuleCollisionComp");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleCollisionComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:CustomCollisionComp")]
	protected UStaticMeshComponent CustomCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!CustomCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:CustomCollisionComp");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, CustomCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:CustomCollisionComp");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, CustomCollisionComp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:LineTraceStartPoint")]
	protected USceneComponent LineTraceStartPoint
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceStartPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:LineTraceStartPoint");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, LineTraceStartPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceStartPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:LineTraceStartPoint");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, LineTraceStartPoint_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:StaticComp")]
	protected UStaticMeshComponent StaticComp
	{
		get
		{
			CheckDestroyed();
			if (!StaticComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:StaticComp");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, StaticComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:StaticComp");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, StaticComp_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:Interact_Start")]
	protected USphereComponent Interact_Start
	{
		get
		{
			CheckDestroyed();
			if (!Interact_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:Interact_Start");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, Interact_Start_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:Interact_Start");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, Interact_Start_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:Interact_End")]
	protected USphereComponent Interact_End
	{
		get
		{
			CheckDestroyed();
			if (!Interact_End_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:Interact_End");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, Interact_End_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_End_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:Interact_End");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, Interact_End_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileConfigInfoComp")]
	public BUS_ProjectileConfigInfoComp ProjectileConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_ProjectileConfigInfoComp>.FromNative(IntPtr.Add(base.Address, ProjectileConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_ProjectileConfigInfoComp>.ToNative(IntPtr.Add(base.Address, ProjectileConfigInfoComp_Offset), value);
			}
		}
	}

	private int TeamIDInCS { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetReplicateMovement(bInReplicateMovement: true);
		BaseInitialize(initializer);
		ProjectileMovement.AutoActivate = false;
		base.Replicates = true;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.bIsNoMoveActor = false;
		base.ActorCompContainerCS.InitialCompSet_Projectile(ProjectileConfigInfoComp.ExtAbilityMask.Mask, ProjectileConfigInfoComp.DisableAbilityMask.Mask);
		base.ActorCompContainerCS.AddComp(new b1.BUS_TickRateLogicSimpleComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_ProjectileBasicComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_MasterComp());
		base.ActorCompContainerCS.AddComp(new BUS_ObjActorMovementComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_TriggerEffectCompSvr(), 128);
		base.ActorCompContainerCS.AddComp(new b1.BUS_TriggerEffectComp());
		base.ActorCompContainerCS.AddComp(new BUS_ProjectileLifeComp());
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_AKMgrComp>(1);
		base.ActorCompContainerCS.RegisterProjectileComp<BUS_ProjectileScaleMgrComp>(EProjectileAbilityType.DynamicScale);
		base.ActorCompContainerCS.AddComp(new BUS_BulletDispComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_ProjectileDispInteractComp());
		base.ActorCompContainerCS.RegisterProjectileComp<BUS_ProjectileAudioCompl>(EProjectileAbilityType.Default, EProjectileDisableAbilityType.Audio);
		base.ActorCompContainerCS.RegisterProjectileComp<b1.BUS_ProjectileThrowUpDeadUnitComp>(EProjectileAbilityType.ThrowUpDeadUnit);
		base.ActorCompContainerCS.RegisterProjectileComp<BUS_ProjectileLaserComp>(EProjectileAbilityType.LaserBullet);
		base.ActorCompContainerCS.RegisterProjectileComp<b1.BUS_DestructibleDestroyEffectTriggerCompImpl>(EProjectileAbilityType.DestructibleBullet);
		base.ActorCompContainerCS.RegisterProjectileComp<BUS_ProceduralEnvInteractionTriggerCompImpl>(EProjectileAbilityType.ProceduralEnvInteract);
		base.ActorCompContainerCS.AddComp(new BUS_ProjectileSimpleMovementComp());
		base.ActorCompContainerCS.AddComp(new BUS_SimpleOverlapComp());
		base.ActorCompContainerCS.AddComp(new BUS_DataReplicationSystemClient(), 8);
		base.ActorCompContainerCS.AddComp(new BUS_DataReplicationSystemSvr(), 2);
		base.ActorCompContainerCS.AddComp(new BUS_ProjectileBeAttackedComp());
		base.ActorCompContainerCS.RegisterProjectileComp<BUS_ProjectileWindBrokenAudioComp>(EProjectileAbilityType.WindBrokenAudio);
	}

	public USphereComponent GetSphereCollisionComp()
	{
		return SphereCollisionComp;
	}

	public UBoxComponent GetBoxCollisionComp()
	{
		return BoxCollisionComp;
	}

	public UCapsuleComponent GetCapsuleCollisionComp()
	{
		return CapsuleCollisionComp;
	}

	public UStaticMeshComponent GetStaticMesh()
	{
		return StaticComp;
	}

	public UStaticMeshComponent GetCustomCollisionComp()
	{
		return CustomCollisionComp;
	}

	private void BaseInitialize(FObjectInitializer initializer)
	{
		StaticComp = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.StaticComp);
		SetRootComponentCS(StaticComp);
		StaticComp.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
		SetCompCanEverAffectNavigation(StaticComp, bRelevant: false);
		ProjectileConfigInfoComp = initializer.CreateDefaultSubobject<BUS_ProjectileConfigInfoComp>(this, B1GlobalFNames.ProjectileConfigInfoComp);
		ProjectileMovement = initializer.CreateDefaultSubobject<UBGUProjectileMovementComponent>(this, B1GlobalFNames.ProjectileComp);
		ProjectileMovement.UpdatedComponent = base.RootComponent;
		ProjectileMovement.Velocity = FVector.ZeroVector;
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ProjectileBaseDataComp>(this, B1GlobalFNames.ProjectileBaseDataComp);
	}

	public bool IsDead()
	{
		return BGU_DataUtil.GetReadOnlyData<BUC_ProjectileLifeData>(this)?.ProjectileIsDead ?? false;
	}

	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:GetProjectileMovement")]
	public UBGUProjectileMovementComponent GetProjectileMovement()
	{
		return ProjectileMovement;
	}

	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:GetProjectileID")]
	public int GetProjectileID()
	{
		return BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(this)?.ProjectileID ?? (-1);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:SwitchFinished")]
	public unsafe void SwitchFinished()
	{
		CheckDestroyed();
		if (!SwitchFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:SwitchFinished");
			return;
		}
		if (SwitchFinished_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			SwitchFinished_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "SwitchFinished");
		}
		byte* value = stackalloc byte[(int)(uint)SwitchFinished_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, SwitchFinished_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, SwitchFinished_InstanceFunctionAddressInstance, intPtr, SwitchFinished_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:SwitchBegin")]
	public unsafe void SwitchBegin()
	{
		CheckDestroyed();
		if (!SwitchBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:SwitchBegin");
			return;
		}
		if (SwitchBegin_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			SwitchBegin_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "SwitchBegin");
		}
		byte* value = stackalloc byte[(int)(uint)SwitchBegin_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, SwitchBegin_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, SwitchBegin_InstanceFunctionAddressInstance, intPtr, SwitchBegin_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:SwitchPre")]
	public unsafe void SwitchPre()
	{
		CheckDestroyed();
		if (!SwitchPre_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:SwitchPre");
			return;
		}
		if (SwitchPre_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			SwitchPre_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "SwitchPre");
		}
		byte* value = stackalloc byte[(int)(uint)SwitchPre_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, SwitchPre_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, SwitchPre_InstanceFunctionAddressInstance, intPtr, SwitchPre_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:SpawnFinished")]
	public unsafe void SpawnFinished(FProjectileSpawnEventInfo ProjectileSpawnEventInfo)
	{
		CheckDestroyed();
		if (!SpawnFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:SpawnFinished");
			return;
		}
		if (SpawnFinished_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			SpawnFinished_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "SpawnFinished");
		}
		byte* value = stackalloc byte[(int)(uint)SpawnFinished_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, SpawnFinished_ParamsSize);
		BlittableTypeMarshaler<FProjectileSpawnEventInfo>.ToNative(IntPtr.Add(intPtr, SpawnFinished_ProjectileSpawnEventInfo_Offset), ProjectileSpawnEventInfo);
		NativeReflection.InvokeFunction(base.Address, SpawnFinished_InstanceFunctionAddressInstance, intPtr, SpawnFinished_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:OnDead")]
	public unsafe void OnDead()
	{
		CheckDestroyed();
		if (!OnDead_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:OnDead");
			return;
		}
		if (OnDead_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnDead_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnDead");
		}
		byte* value = stackalloc byte[(int)(uint)OnDead_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnDead_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnDead_InstanceFunctionAddressInstance, intPtr, OnDead_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:CheckDrawSignCondition")]
	public unsafe bool CheckDrawSignCondition(AActor HitActor)
	{
		CheckDestroyed();
		if (!CheckDrawSignCondition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:CheckDrawSignCondition");
			return false;
		}
		if (CheckDrawSignCondition_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			CheckDrawSignCondition_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "CheckDrawSignCondition");
		}
		byte* value = stackalloc byte[(int)(uint)CheckDrawSignCondition_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, CheckDrawSignCondition_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CheckDrawSignCondition_HitActor_Offset), HitActor);
		NativeReflection.InvokeFunction(base.Address, CheckDrawSignCondition_InstanceFunctionAddressInstance, intPtr, CheckDrawSignCondition_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckDrawSignCondition_ReturnValue_Offset), 0, CheckDrawSignCondition_ReturnValue_PropertyAddress.Address);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:OnDrawSign")]
	public unsafe void OnDrawSign(AActor HitActor, FTransform HitTransform)
	{
		CheckDestroyed();
		if (!OnDrawSign_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUProjectileBaseActor:OnDrawSign");
			return;
		}
		if (OnDrawSign_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnDrawSign_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnDrawSign");
		}
		byte* value = stackalloc byte[(int)(uint)OnDrawSign_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnDrawSign_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnDrawSign_HitActor_Offset), HitActor);
		NativeReflection.InitializeValue_InContainer(OnDrawSign_HitTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnDrawSign_HitTransform_Offset), HitTransform);
		NativeReflection.InvokeFunction(base.Address, OnDrawSign_InstanceFunctionAddressInstance, intPtr, OnDrawSign_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDrawSign_HitTransform_PropertyAddress.Address, intPtr);
	}

	public FTransform GetWorldTransform_LineTracePoint()
	{
		return BGUFuncLibActorTransformCS.BGUGetWorldTransform(LineTraceStartPoint);
	}

	public FTransform GetWorldTransform_HitAttachPoint()
	{
		return BGUFuncLibActorTransformCS.BGUGetActorTransform(this);
	}

	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
	}

	protected void WriteGeomInfoToConfigInfo()
	{
	}

	private void MakeCompEditorOnly(USceneComponent _SceneComp, bool bIsEditorOnly)
	{
		_SceneComp.IsEditorOnly = bIsEditorOnly;
		_SceneComp.AbsoluteLocation = bIsEditorOnly;
		_SceneComp.AbsoluteRotation = bIsEditorOnly;
		_SceneComp.AbsoluteScale = bIsEditorOnly;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:GetStaticMeshCompChildsNum")]
	public int GetStaticMeshCompChildsNum()
	{
		StaticComp.GetChildrenComponents(bIncludeAllDescendants: true, out var Children);
		return Children.Count;
	}

	public void ProjectileAttachToActor(AActor AttachParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies = false)
	{
		AttachToActor(AttachParentActor, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
		OnAttachmentChanged(AttachParentActor);
	}

	public void ProjectileAttachToComp(USceneComponent AttachComp, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies = false)
	{
		AttachToComponent(AttachComp, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
		OnAttachmentChanged(AttachComp.GetOwner());
	}

	public void ProjectileDetachFromActor(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule)
	{
		if (AttachParentActor_Cached != null)
		{
			DetachFromActor(LocationRule, RotationRule, ScaleRule);
			OnAttachmentChanged(null);
		}
	}

	private void OnAttachmentChanged(AActor NewAttachParentActor)
	{
		AttachParentActor_Cached = NewAttachParentActor;
	}

	public AActor GetAttachParentActorCached()
	{
		return AttachParentActor_Cached;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileAbilityCheck_ByBPConfig")]
	public bool ProjectileAbilityCheck_ByBPConfig()
	{
		bool flag = false;
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(base.World))
		{
			return flag;
		}
		string pathName = GetClass().GetPathName();
		pathName = pathName.Substring(0, pathName.Length - 2);
		UBlueprint Blueprint;
		UObject uObject = UGSE_EditorFuncLib.AssetPath_GetCDO(null, pathName, out Blueprint);
		if (uObject != null)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = uObject as BGUProjectileBaseActor;
			if (bGUProjectileBaseActor != null)
			{
				flag |= bGUProjectileBaseActor.ProjectileAbilityCheck_ProceduralEnvInteract();
				flag |= bGUProjectileBaseActor.ProjectileAbilityCheck_DestructibleBullet();
				flag |= bGUProjectileBaseActor.ProjectileAbilityCheck_BulletMatMerge();
				flag |= bGUProjectileBaseActor.ProjectileAbilityCheck_WindBrokenAudio();
			}
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_ByDesc(bool bEnableLaser, bool bEnableDyanamicScale)
	{
		bool flag = false;
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(base.World))
		{
			return flag;
		}
		string pathName = GetClass().GetPathName();
		pathName = pathName.Substring(0, pathName.Length - 2);
		UBlueprint Blueprint;
		UObject uObject = UGSE_EditorFuncLib.AssetPath_GetCDO(null, pathName, out Blueprint);
		if (uObject != null)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = uObject as BGUProjectileBaseActor;
			if (bGUProjectileBaseActor != null)
			{
				flag |= bGUProjectileBaseActor.ProjectileAbilityCheck_LaserBullet(bEnableLaser);
				flag |= bGUProjectileBaseActor.ProjectileAbilityCheck_DynamicScale(bEnableDyanamicScale);
			}
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_ProceduralEnvInteract()
	{
		bool flag = false;
		if (ProjectileConfigInfoComp.bEnable)
		{
			if ((8 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) == 0)
			{
				FProjectileExtAbilityMask extAbilityMask = ProjectileConfigInfoComp.ExtAbilityMask;
				extAbilityMask.Mask |= 8;
				ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask;
				flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
			}
		}
		else if ((8 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) != 0)
		{
			FProjectileExtAbilityMask extAbilityMask2 = ProjectileConfigInfoComp.ExtAbilityMask;
			extAbilityMask2.Mask -= 8;
			ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask2;
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_DestructibleBullet()
	{
		bool flag = false;
		if (ProjectileConfigInfoComp.DestructibleTag != FName.None)
		{
			if ((0x20 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) == 0)
			{
				FProjectileExtAbilityMask extAbilityMask = ProjectileConfigInfoComp.ExtAbilityMask;
				extAbilityMask.Mask |= 32;
				ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask;
				flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
			}
		}
		else if ((0x20 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) != 0)
		{
			FProjectileExtAbilityMask extAbilityMask2 = ProjectileConfigInfoComp.ExtAbilityMask;
			extAbilityMask2.Mask -= 32;
			ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask2;
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_WindBrokenAudio()
	{
		bool flag = false;
		if (ProjectileConfigInfoComp.WindBrokenAudio != null && ProjectileConfigInfoComp.TriggerDist_WindBroken > 0f)
		{
			if ((0x80 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) == 0)
			{
				FProjectileExtAbilityMask extAbilityMask = ProjectileConfigInfoComp.ExtAbilityMask;
				extAbilityMask.Mask |= 128;
				ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask;
				flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
			}
		}
		else if ((0x80 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) != 0)
		{
			FProjectileExtAbilityMask extAbilityMask2 = ProjectileConfigInfoComp.ExtAbilityMask;
			extAbilityMask2.Mask -= 128;
			ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask2;
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_BulletMatMerge()
	{
		bool flag = false;
		if (ProjectileConfigInfoComp.MPC != null)
		{
			if ((0x10 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) == 0)
			{
				FProjectileExtAbilityMask extAbilityMask = ProjectileConfigInfoComp.ExtAbilityMask;
				extAbilityMask.Mask |= 16;
				ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask;
				flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
			}
		}
		else if ((0x10 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) != 0)
		{
			FProjectileExtAbilityMask extAbilityMask2 = ProjectileConfigInfoComp.ExtAbilityMask;
			extAbilityMask2.Mask -= 16;
			ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask2;
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_LaserBullet(bool EnableLaser)
	{
		bool flag = false;
		if (EnableLaser)
		{
			if ((4 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) == 0)
			{
				FProjectileExtAbilityMask extAbilityMask = ProjectileConfigInfoComp.ExtAbilityMask;
				extAbilityMask.Mask |= 4;
				ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask;
				flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
			}
		}
		else if ((4 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) != 0)
		{
			FProjectileExtAbilityMask extAbilityMask2 = ProjectileConfigInfoComp.ExtAbilityMask;
			extAbilityMask2.Mask -= 4;
			ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask2;
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	public bool ProjectileAbilityCheck_DynamicScale(bool EnableDynamicScale)
	{
		bool flag = false;
		if (EnableDynamicScale)
		{
			if ((2 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) == 0)
			{
				FProjectileExtAbilityMask extAbilityMask = ProjectileConfigInfoComp.ExtAbilityMask;
				extAbilityMask.Mask |= 2;
				ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask;
				flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
			}
		}
		else if ((2 & ProjectileConfigInfoComp.ExtAbilityMask.Mask) != 0)
		{
			FProjectileExtAbilityMask extAbilityMask2 = ProjectileConfigInfoComp.ExtAbilityMask;
			extAbilityMask2.Mask -= 2;
			ProjectileConfigInfoComp.ExtAbilityMask = extAbilityMask2;
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	[USharpPath("/Script/b1-Managed.BGUProjectileBaseActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
		switch (ProjectileConfigInfoComp.CheckShapeType)
		{
		case EProjectileCheckShapeType.SphereShape:
		{
			List<UActorComponent> componentsByTag2 = GetComponentsByTag(UClass.GetClass<USphereComponent>(), B1GlobalFNames.CheckComp_Sphere);
			if (componentsByTag2.Count > 0)
			{
				SphereCollisionComp = componentsByTag2[0] as USphereComponent;
			}
			break;
		}
		case EProjectileCheckShapeType.BoxShape:
		{
			List<UActorComponent> componentsByTag4 = GetComponentsByTag(UClass.GetClass<UBoxComponent>(), B1GlobalFNames.CheckComp_Box);
			if (componentsByTag4.Count > 0)
			{
				BoxCollisionComp = componentsByTag4[0] as UBoxComponent;
			}
			break;
		}
		case EProjectileCheckShapeType.CapsuleShape:
		{
			List<UActorComponent> componentsByTag5 = GetComponentsByTag(UClass.GetClass<UCapsuleComponent>(), B1GlobalFNames.CheckComp_Capsule);
			if (componentsByTag5.Count > 0)
			{
				CapsuleCollisionComp = componentsByTag5[0] as UCapsuleComponent;
			}
			break;
		}
		case EProjectileCheckShapeType.CustomShape:
		{
			List<UActorComponent> componentsByTag3 = GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.CheckComp_Custom);
			if (componentsByTag3.Count > 0)
			{
				CustomCollisionComp = componentsByTag3[0] as UStaticMeshComponent;
			}
			break;
		}
		case EProjectileCheckShapeType.LineTrace:
		{
			List<UActorComponent> componentsByTag = GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.LineTracePoint);
			if (componentsByTag.Count > 0)
			{
				LineTraceStartPoint = componentsByTag[0] as USceneComponent;
			}
			break;
		}
		case EProjectileCheckShapeType.SceneItem:
			break;
		}
	}

	public void SetTeamIDInCS(int NewTeamID)
	{
		TeamIDInCS = NewTeamID;
	}

	public int GetTeamIDInCS()
	{
		return TeamIDInCS;
	}

	public void EnableDebugMode()
	{
		bOpenDebugMode = true;
	}

	public bool bInDebugMode()
	{
		return bOpenDebugMode;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileBaseActor:GetProjectileID")]
	private static void GetProjectileID__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GCHelper.Find<BGUProjectileBaseActor>(obj);
		int projectileID = bGUProjectileBaseActor.GetProjectileID();
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetProjectileID_ReturnValue_Offset), projectileID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileBaseActor:GetProjectileMovement")]
	private static void GetProjectileMovement__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GCHelper.Find<BGUProjectileBaseActor>(obj);
		UBGUProjectileMovementComponent projectileMovement = bGUProjectileBaseActor.GetProjectileMovement();
		UObjectMarshaler<UBGUProjectileMovementComponent>.ToNative(IntPtr.Add(buffer, GetProjectileMovement_ReturnValue_Offset), projectileMovement);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileBaseActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GCHelper.Find<BGUProjectileBaseActor>(obj);
		bGUProjectileBaseActor.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileBaseActor:GetStaticMeshCompChildsNum")]
	private static void GetStaticMeshCompChildsNum__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GCHelper.Find<BGUProjectileBaseActor>(obj);
		int staticMeshCompChildsNum = bGUProjectileBaseActor.GetStaticMeshCompChildsNum();
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetStaticMeshCompChildsNum_ReturnValue_Offset), staticMeshCompChildsNum);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileBaseActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GCHelper.Find<BGUProjectileBaseActor>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUProjectileBaseActor.OnConstructionCS_Implementation(transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileAbilityCheck_ByBPConfig")]
	private static void ProjectileAbilityCheck_ByBPConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GCHelper.Find<BGUProjectileBaseActor>(obj);
		bool value = bGUProjectileBaseActor.ProjectileAbilityCheck_ByBPConfig();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAbilityCheck_ByBPConfig_ReturnValue_Offset), 0, ProjectileAbilityCheck_ByBPConfig_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUProjectileBaseActor");
		ProjectileMovement_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileMovement");
		ProjectileMovement_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileMovement", Classes.FObjectProperty);
		SphereCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SphereCollisionComp");
		SphereCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SphereCollisionComp", Classes.FObjectProperty);
		BoxCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoxCollisionComp");
		BoxCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoxCollisionComp", Classes.FObjectProperty);
		CapsuleCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleCollisionComp");
		CapsuleCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleCollisionComp", Classes.FObjectProperty);
		CustomCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomCollisionComp");
		CustomCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomCollisionComp", Classes.FObjectProperty);
		LineTraceStartPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceStartPoint");
		LineTraceStartPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceStartPoint", Classes.FObjectProperty);
		StaticComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "StaticComp");
		StaticComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StaticComp", Classes.FObjectProperty);
		Interact_Start_Offset = NativeReflection.GetPropertyOffset(intPtr, "Interact_Start");
		Interact_Start_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Interact_Start", Classes.FObjectProperty);
		Interact_End_Offset = NativeReflection.GetPropertyOffset(intPtr, "Interact_End");
		Interact_End_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Interact_End", Classes.FObjectProperty);
		ProjectileConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileConfigInfoComp");
		ProjectileConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileConfigInfoComp", Classes.FObjectProperty);
		OnDead_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDead");
		OnDead_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDead_FunctionAddress);
		OnDead_IsValid = OnDead_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:OnDead", OnDead_IsValid);
		SwitchPre_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchPre");
		SwitchPre_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchPre_FunctionAddress);
		SwitchPre_IsValid = SwitchPre_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:SwitchPre", SwitchPre_IsValid);
		OnDrawSign_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDrawSign");
		OnDrawSign_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDrawSign_FunctionAddress);
		OnDrawSign_HitActor_Offset = NativeReflection.GetPropertyOffset(OnDrawSign_FunctionAddress, "HitActor");
		OnDrawSign_HitActor_IsValid = NativeReflection.ValidatePropertyClass(OnDrawSign_FunctionAddress, "HitActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnDrawSign_HitTransform_PropertyAddress, OnDrawSign_FunctionAddress, "HitTransform");
		OnDrawSign_HitTransform_Offset = NativeReflection.GetPropertyOffset(OnDrawSign_FunctionAddress, "HitTransform");
		OnDrawSign_HitTransform_IsValid = NativeReflection.ValidatePropertyClass(OnDrawSign_FunctionAddress, "HitTransform", Classes.FStructProperty);
		OnDrawSign_IsValid = OnDrawSign_FunctionAddress != IntPtr.Zero && OnDrawSign_HitActor_IsValid && OnDrawSign_HitTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:OnDrawSign", OnDrawSign_IsValid);
		SwitchBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchBegin");
		SwitchBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchBegin_FunctionAddress);
		SwitchBegin_IsValid = SwitchBegin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:SwitchBegin", SwitchBegin_IsValid);
		SpawnFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnFinished");
		SpawnFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnFinished_FunctionAddress);
		SpawnFinished_ProjectileSpawnEventInfo_Offset = NativeReflection.GetPropertyOffset(SpawnFinished_FunctionAddress, "ProjectileSpawnEventInfo");
		SpawnFinished_ProjectileSpawnEventInfo_IsValid = NativeReflection.ValidatePropertyClass(SpawnFinished_FunctionAddress, "ProjectileSpawnEventInfo", Classes.FStructProperty);
		SpawnFinished_IsValid = SpawnFinished_FunctionAddress != IntPtr.Zero && SpawnFinished_ProjectileSpawnEventInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:SpawnFinished", SpawnFinished_IsValid);
		SwitchFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchFinished");
		SwitchFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchFinished_FunctionAddress);
		SwitchFinished_IsValid = SwitchFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:SwitchFinished", SwitchFinished_IsValid);
		GetProjectileID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetProjectileID");
		GetProjectileID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectileID_FunctionAddress);
		GetProjectileID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetProjectileID_FunctionAddress, "ReturnValue");
		GetProjectileID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetProjectileID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetProjectileID_IsValid = GetProjectileID_FunctionAddress != IntPtr.Zero && GetProjectileID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:GetProjectileID", GetProjectileID_IsValid);
		GetProjectileMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetProjectileMovement");
		GetProjectileMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectileMovement_FunctionAddress);
		GetProjectileMovement_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetProjectileMovement_FunctionAddress, "ReturnValue");
		GetProjectileMovement_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetProjectileMovement_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetProjectileMovement_IsValid = GetProjectileMovement_FunctionAddress != IntPtr.Zero && GetProjectileMovement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:GetProjectileMovement", GetProjectileMovement_IsValid);
		CheckDrawSignCondition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckDrawSignCondition");
		CheckDrawSignCondition_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckDrawSignCondition_FunctionAddress);
		CheckDrawSignCondition_HitActor_Offset = NativeReflection.GetPropertyOffset(CheckDrawSignCondition_FunctionAddress, "HitActor");
		CheckDrawSignCondition_HitActor_IsValid = NativeReflection.ValidatePropertyClass(CheckDrawSignCondition_FunctionAddress, "HitActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CheckDrawSignCondition_ReturnValue_PropertyAddress, CheckDrawSignCondition_FunctionAddress, "ReturnValue");
		CheckDrawSignCondition_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckDrawSignCondition_FunctionAddress, "ReturnValue");
		CheckDrawSignCondition_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckDrawSignCondition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckDrawSignCondition_IsValid = CheckDrawSignCondition_FunctionAddress != IntPtr.Zero && CheckDrawSignCondition_HitActor_IsValid && CheckDrawSignCondition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:CheckDrawSignCondition", CheckDrawSignCondition_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:BeginPlayCS", BeginPlayCS_IsValid);
		GetStaticMeshCompChildsNum_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStaticMeshCompChildsNum");
		GetStaticMeshCompChildsNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshCompChildsNum_FunctionAddress);
		GetStaticMeshCompChildsNum_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStaticMeshCompChildsNum_FunctionAddress, "ReturnValue");
		GetStaticMeshCompChildsNum_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStaticMeshCompChildsNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStaticMeshCompChildsNum_IsValid = GetStaticMeshCompChildsNum_FunctionAddress != IntPtr.Zero && GetStaticMeshCompChildsNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:GetStaticMeshCompChildsNum", GetStaticMeshCompChildsNum_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:OnConstructionCS", OnConstructionCS_IsValid);
		ProjectileAbilityCheck_ByBPConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectileAbilityCheck_ByBPConfig");
		ProjectileAbilityCheck_ByBPConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectileAbilityCheck_ByBPConfig_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ProjectileAbilityCheck_ByBPConfig_ReturnValue_PropertyAddress, ProjectileAbilityCheck_ByBPConfig_FunctionAddress, "ReturnValue");
		ProjectileAbilityCheck_ByBPConfig_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ProjectileAbilityCheck_ByBPConfig_FunctionAddress, "ReturnValue");
		ProjectileAbilityCheck_ByBPConfig_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAbilityCheck_ByBPConfig_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectileAbilityCheck_ByBPConfig_IsValid = ProjectileAbilityCheck_ByBPConfig_FunctionAddress != IntPtr.Zero && ProjectileAbilityCheck_ByBPConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileBaseActor:ProjectileAbilityCheck_ByBPConfig", ProjectileAbilityCheck_ByBPConfig_IsValid);
	}

	static BGUProjectileBaseActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUProjectileBaseActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUProjectileBaseActor));
	}
}
