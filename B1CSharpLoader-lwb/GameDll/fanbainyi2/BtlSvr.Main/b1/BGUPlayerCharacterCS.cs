using System;
using System.Collections.Generic;
using b1.BGU.BUS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS")]
public class BGUPlayerCharacterCS : BGU_CharacterAI
{
	private bool HasInitInOnlineGame;

	private static bool CameraBoom1_IsValid;

	private static int CameraBoom1_Offset;

	private static bool FollowCamera_IsValid;

	private static int FollowCamera_Offset;

	private static bool ApproachNotifyComp_IsValid;

	private static int ApproachNotifyComp_Offset;

	private static bool PlayerInputComponent_IsValid;

	private static int PlayerInputComponent_Offset;

	private static bool ParkourMoveComp_IsValid;

	private static int ParkourMoveComp_Offset;

	private static bool PlayerConfigInfoComp_IsValid;

	private static int PlayerConfigInfoComp_Offset;

	private static bool PlayerExtendConfigComp_IsValid;

	private static int PlayerExtendConfigComp_Offset;

	private static bool CharacterModularComp_IsValid;

	private static int CharacterModularComp_Offset;

	private static bool OnPossessedCS_IsValid;

	private static IntPtr OnPossessedCS_FunctionAddress;

	private static int OnPossessedCS_ParamsSize;

	private static bool OnPossessedCS_NewController_IsValid;

	private static int OnPossessedCS_NewController_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool IsPlayerCharacterCS_IsValid;

	private static IntPtr IsPlayerCharacterCS_FunctionAddress;

	private static int IsPlayerCharacterCS_ParamsSize;

	private static bool IsPlayerCharacterCS_ReturnValue_IsValid;

	private static int IsPlayerCharacterCS_ReturnValue_Offset;

	private static FFieldAddress IsPlayerCharacterCS_ReturnValue_PropertyAddress;

	private static bool OnRep_PlayerStateCS_IsValid;

	private static IntPtr OnRep_PlayerStateCS_FunctionAddress;

	private static int OnRep_PlayerStateCS_ParamsSize;

	private static bool SetupPlayerInputComponentCS_IsValid;

	private static IntPtr SetupPlayerInputComponentCS_FunctionAddress;

	private static int SetupPlayerInputComponentCS_ParamsSize;

	private static bool SetupPlayerInputComponentCS_PlayerInputComponent_IsValid;

	private static int SetupPlayerInputComponentCS_PlayerInputComponent_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:CameraBoom1")]
	public BUS_SpringArmComponent CameraBoom1
	{
		get
		{
			CheckDestroyed();
			if (!CameraBoom1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:CameraBoom1");
				return null;
			}
			return UObjectMarshaler<BUS_SpringArmComponent>.FromNative(IntPtr.Add(base.Address, CameraBoom1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBoom1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:CameraBoom1");
			}
			else
			{
				UObjectMarshaler<BUS_SpringArmComponent>.ToNative(IntPtr.Add(base.Address, CameraBoom1_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:FollowCamera")]
	public UCameraComponent FollowCamera
	{
		get
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:FollowCamera");
				return null;
			}
			return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(base.Address, FollowCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:FollowCamera");
			}
			else
			{
				UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(base.Address, FollowCamera_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:ApproachNotifyComp")]
	public USphereComponent ApproachNotifyComp
	{
		get
		{
			CheckDestroyed();
			if (!ApproachNotifyComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:ApproachNotifyComp");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, ApproachNotifyComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ApproachNotifyComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:ApproachNotifyComp");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, ApproachNotifyComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerInputComponent")]
	public UInputComponent PlayerInputComponent
	{
		get
		{
			CheckDestroyed();
			if (!PlayerInputComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerInputComponent");
				return null;
			}
			return UObjectMarshaler<UInputComponent>.FromNative(IntPtr.Add(base.Address, PlayerInputComponent_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!PlayerInputComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerInputComponent");
			}
			else
			{
				UObjectMarshaler<UInputComponent>.ToNative(IntPtr.Add(base.Address, PlayerInputComponent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:ParkourMoveComp")]
	private BUS_ParkourMoveComp ParkourMoveComp
	{
		get
		{
			CheckDestroyed();
			if (!ParkourMoveComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:ParkourMoveComp");
				return null;
			}
			return UObjectMarshaler<BUS_ParkourMoveComp>.FromNative(IntPtr.Add(base.Address, ParkourMoveComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParkourMoveComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:ParkourMoveComp");
			}
			else
			{
				UObjectMarshaler<BUS_ParkourMoveComp>.ToNative(IntPtr.Add(base.Address, ParkourMoveComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerConfigInfoComp")]
	public BUS_ConfigInfoComp PlayerConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!PlayerConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_ConfigInfoComp>.FromNative(IntPtr.Add(base.Address, PlayerConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_ConfigInfoComp>.ToNative(IntPtr.Add(base.Address, PlayerConfigInfoComp_Offset), value);
			}
		}
	}

	[AllowPrivateAccess]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerExtendConfigComp")]
	public BUS_ExtendConfigComp PlayerExtendConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!PlayerExtendConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerExtendConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ExtendConfigComp>.FromNative(IntPtr.Add(base.Address, PlayerExtendConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerExtendConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:PlayerExtendConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ExtendConfigComp>.ToNative(IntPtr.Add(base.Address, PlayerExtendConfigComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:CharacterModularComp")]
	protected BUS_CharacterModularComp CharacterModularComp
	{
		get
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:CharacterModularComp");
				return null;
			}
			return UObjectMarshaler<BUS_CharacterModularComp>.FromNative(IntPtr.Add(base.Address, CharacterModularComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlayerCharacterCS:CharacterModularComp");
			}
			else
			{
				UObjectMarshaler<BUS_CharacterModularComp>.ToNative(IntPtr.Add(base.Address, CharacterModularComp_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:IsPlayerCharacterCS")]
	protected override bool IsPlayerCharacterCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		if (!HasAuthority() && bGW_ECSWorld.HasECSWorldBeginPlay)
		{
			bGW_ECSWorld.BeginPlayEntity(base.ECSEntity);
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.ECSArcheType = 5;
		CameraBoom1 = initializer.CreateDefaultSubobject<BUS_SpringArmComponent>(this, B1GlobalFNames.CameraBoom1);
		CameraBoom1.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		CameraBoom1.TargetArmLength = 344.5f;
		CameraBoom1.UsePawnControlRotation = true;
		FollowCamera = initializer.CreateDefaultSubobject<UCameraComponent>(this, B1GlobalFNames.FollowCamera);
		FollowCamera.AttachToComponent(CameraBoom1, B1GlobalFNames.SpringEndpoint, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		FollowCamera.UsePawnControlRotation = false;
		FollowCamera.AbsoluteRotation = true;
		ApproachNotifyComp = initializer.CreateDefaultSubobject<USphereComponent>(this, B1GlobalFNames.ApproachNotifyComp);
		ApproachNotifyComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		ApproachNotifyComp.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		ApproachNotifyComp.SetCollisionProfileName(B1GlobalFNames.Trigger);
		ParkourMoveComp = initializer.CreateDefaultSubobject<BUS_ParkourMoveComp>(this, B1GlobalFNames.ParkourMoveComp);
		PlayerConfigInfoComp = initializer.CreateDefaultSubobject<BUS_ConfigInfoComp>(this, B1GlobalFNames.PlayerConfigInfoComp);
		FUnitCompFlagConfig flagConfig = PlayerConfigInfoComp.FlagConfig;
		flagConfig.UnitTemplateType = EUnitTagType.TransitionPlayer;
		PlayerConfigInfoComp.FlagConfig = flagConfig;
		PlayerExtendConfigComp = initializer.CreateDefaultSubobject<BUS_ExtendConfigComp>(this, B1GlobalFNames.PlayerExtendConfigComp);
		CharacterModularComp = initializer.CreateDefaultSubobject<BUS_CharacterModularComp>(this, B1GlobalFNames.CharacterModularComp);
	}

	protected override void InitBGUDataComp(FObjectInitializer initializer)
	{
		base.BGUDataComp = initializer.CreateDefaultSubobject<BUS_PlayerDataComp>(this, B1GlobalFNames.UBGUDataComp);
	}

	public override void InitAllComp()
	{
		FUnitCompFlagConfig flagConfig = PlayerConfigInfoComp.FlagConfig;
		EActorCompAlterFlag eActorCompAlterFlag = (EActorCompAlterFlag)0L;
		foreach (KeyValuePair<string, bool> playerAlterTag in flagConfig.PlayerAlterTags)
		{
			if (playerAlterTag.Value && Enum.TryParse<EActorCompAlterFlag>(playerAlterTag.Key, out var result))
			{
				eActorCompAlterFlag |= result;
			}
		}
		base.ActorCompContainerCS.InitialCompSet(flagConfig.UnitTemplateType, eActorCompAlterFlag, (EActorCompRejectFlag)0L);
		InitialConfigInfo(PlayerConfigInfoComp.UnitCDesc.ResID, PlayerConfigInfoComp.UnitCDesc.OverrideID);
		base.bCanAsPerformer = PlayerExtendConfigComp.bCanAsPerformer;
		base.bCanAsNPC = PlayerExtendConfigComp.bCanAsNPC;
		base.bCanAsFollowPartner = PlayerExtendConfigComp.bCanAsFollowPartner;
		base.ActorCompContainerCS.AddComp(new BUS_PlayerInputActionComp(), 16);
		base.InitAllComp();
		base.TeamIDDeprecate = 2;
		base.ActorCompContainerCS.AddComp(new BUS_PlayerActorLifeComp(), int.MaxValue, -2013265920);
		base.ActorCompContainerCS.AddComp(new BUS_DodgeComp());
		base.ActorCompContainerCS.AddComp(new BUS_TouchWallFeedbackComp());
		base.ActorCompContainerCS.AddComp(new BUS_SmartCastSkillComp());
		base.ActorCompContainerCS.AddComp(new BUS_SkillSelectComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_SkillInputAssistComp());
		base.ActorCompContainerCS.AddComp(new BUS_SkillRotateComp());
		base.ActorCompContainerCS.AddComp(new BUS_PlayerRestComp(), 2);
		base.ActorCompContainerCS.AddComp(new BUS_SimpleJumpComp());
		base.ActorCompContainerCS.RegisterUnitComp<BUS_TransGuideComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_MagicSpellInfoComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MappedSoundFXMgrComp>(-2139095040, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PoleDrinkComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.AddComp(new BUS_RegisterGMSystemComp());
		base.ActorCompContainerCS.AddComp(new BUS_ExecuteGMSystemComp(), 2);
		base.ActorCompContainerCS.AddComp(new BUS_FallDyingSystemSvr(), 2);
		base.ActorCompContainerCS.AddComp(new b1.BGU.BUS.BUS_PlayerItemSystem(), 2);
		base.ActorCompContainerCS.AddComp(new b1.BUS_CollectiontInteractSvrComp(), 2);
		base.ActorCompContainerCS.AddComp(new b1.BGU.BUS.BUS_PlayerItemClientSystem(), 16);
		base.ActorCompContainerCS.AddCompUObj<BUS_PlayerCameraCompUObj>();
		base.ActorCompContainerCS.RegisterUnitComp<BUS_LifeSavingComp>(1145323520, EActorCompAlterFlag.LifeSaving, (EActorCompRejectFlag)0L, 2);
		base.ActorCompContainerCS.AddComp(new BUS_OSSTriggerComp(), 2, 2048);
		base.ActorCompContainerCS.AddComp(new BUS_PlayerSpellConfComp());
		base.ActorCompContainerCS.AddComp(new BUS_ParkourMoveCompImpl());
		base.ActorCompContainerCS.AddComp(new BUS_TimeScaleComp());
		base.ActorCompContainerCS.AddCompUObj<BUS_ManualSplineMoveCompImpl>();
		base.ActorCompContainerCS.AddComp(new BUS_FallDyingSystemClient(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_SpiderSilkEntangleComp(), 1);
		base.ActorCompContainerCS.AddComp(new b1.BUS_PlayerInteractCricketComp());
		base.ActorCompContainerCS.AddCompUObj<BUS_PlayerApproachedNotifyComp>();
		base.ActorCompContainerCS.RegisterUnitComp<BUS_QiTianDaShengComp>(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		if (PlayerExtendConfigComp.bEnableTurretControl)
		{
			base.ActorCompContainerCS.AddComp(new BUS_TurretControlComp(), 1);
		}
		UCharacterMovementComponent componentByClass = GetComponentByClass<UCharacterMovementComponent>();
		if (componentByClass != null)
		{
			componentByClass.ServerAcceptClientAuthoritativePosition = true;
			componentByClass.IgnoreClientMovementErrorChecksAndCorrection = true;
		}
		base.ActorCompContainerCS.AddComp(new b1.BUS_ChallengeCtrlComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_CloudMoveComp());
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MiscInitComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_ShockWaveComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
	}

	public override void AfterInitAllComp()
	{
		base.AfterInitAllComp();
		APlayerController aPlayerController = GetController() as APlayerController;
		if (aPlayerController != null && aPlayerController.IsLocalPlayerController())
		{
			base.ActorCompContainerCS.AddComp(new BUS_PlayerCameraCompImpl(), 16);
		}
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.GuidComp?.OnActorConstruction();
		CharacterModularComp?.OnActorConstruction();
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:OnRep_PlayerStateCS")]
	protected override void OnRep_PlayerStateCS_Implementation()
	{
		base.OnRep_PlayerStateCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:SetupPlayerInputComponentCS")]
	protected override void SetupPlayerInputComponentCS_Implementation(UInputComponent PlayerInputComponent)
	{
		this.PlayerInputComponent = PlayerInputComponent;
	}

	public UCameraComponent GetFollowCamera()
	{
		return FollowCamera;
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:OnPossessedCS")]
	protected override void OnPossessedCS_Implementation(AController NewController)
	{
		base.OnPossessedCS_Implementation(NewController);
	}

	[USharpPath("/Script/b1-Managed.BGUPlayerCharacterCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:OnPossessedCS")]
	private static void OnPossessedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		AController newController = UObjectMarshaler<AController>.FromNative(IntPtr.Add(buffer, OnPossessedCS_NewController_Offset));
		bGUPlayerCharacterCS.OnPossessedCS_Implementation(newController);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUPlayerCharacterCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUPlayerCharacterCS.OnConstructionCS_Implementation(transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		bGUPlayerCharacterCS.ReceiveBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:IsPlayerCharacterCS")]
	private static void IsPlayerCharacterCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		bool value = bGUPlayerCharacterCS.IsPlayerCharacterCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsPlayerCharacterCS_ReturnValue_Offset), 0, IsPlayerCharacterCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:OnRep_PlayerStateCS")]
	private static void OnRep_PlayerStateCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		bGUPlayerCharacterCS.OnRep_PlayerStateCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPlayerCharacterCS:SetupPlayerInputComponentCS")]
	private static void SetupPlayerInputComponentCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GCHelper.Find<BGUPlayerCharacterCS>(obj);
		UInputComponent playerInputComponent = UObjectMarshaler<UInputComponent>.FromNative(IntPtr.Add(buffer, SetupPlayerInputComponentCS_PlayerInputComponent_Offset));
		bGUPlayerCharacterCS.SetupPlayerInputComponentCS_Implementation(playerInputComponent);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPlayerCharacterCS");
		CameraBoom1_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBoom1");
		CameraBoom1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBoom1", Classes.FObjectProperty);
		FollowCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "FollowCamera");
		FollowCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FollowCamera", Classes.FObjectProperty);
		ApproachNotifyComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ApproachNotifyComp");
		ApproachNotifyComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ApproachNotifyComp", Classes.FObjectProperty);
		PlayerInputComponent_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerInputComponent");
		PlayerInputComponent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerInputComponent", Classes.FObjectProperty);
		ParkourMoveComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParkourMoveComp");
		ParkourMoveComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParkourMoveComp", Classes.FObjectProperty);
		PlayerConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerConfigInfoComp");
		PlayerConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerConfigInfoComp", Classes.FObjectProperty);
		PlayerExtendConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerExtendConfigComp");
		PlayerExtendConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerExtendConfigComp", Classes.FObjectProperty);
		CharacterModularComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterModularComp");
		CharacterModularComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterModularComp", Classes.FObjectProperty);
		OnPossessedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPossessedCS");
		OnPossessedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPossessedCS_FunctionAddress);
		OnPossessedCS_NewController_Offset = NativeReflection.GetPropertyOffset(OnPossessedCS_FunctionAddress, "NewController");
		OnPossessedCS_NewController_IsValid = NativeReflection.ValidatePropertyClass(OnPossessedCS_FunctionAddress, "NewController", Classes.FObjectProperty);
		OnPossessedCS_IsValid = OnPossessedCS_FunctionAddress != IntPtr.Zero && OnPossessedCS_NewController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:OnPossessedCS", OnPossessedCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:OnConstructionCS", OnConstructionCS_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		IsPlayerCharacterCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayerCharacterCS");
		IsPlayerCharacterCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayerCharacterCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsPlayerCharacterCS_ReturnValue_PropertyAddress, IsPlayerCharacterCS_FunctionAddress, "ReturnValue");
		IsPlayerCharacterCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsPlayerCharacterCS_FunctionAddress, "ReturnValue");
		IsPlayerCharacterCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsPlayerCharacterCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayerCharacterCS_IsValid = IsPlayerCharacterCS_FunctionAddress != IntPtr.Zero && IsPlayerCharacterCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:IsPlayerCharacterCS", IsPlayerCharacterCS_IsValid);
		OnRep_PlayerStateCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRep_PlayerStateCS");
		OnRep_PlayerStateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PlayerStateCS_FunctionAddress);
		OnRep_PlayerStateCS_IsValid = OnRep_PlayerStateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:OnRep_PlayerStateCS", OnRep_PlayerStateCS_IsValid);
		SetupPlayerInputComponentCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupPlayerInputComponentCS");
		SetupPlayerInputComponentCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupPlayerInputComponentCS_FunctionAddress);
		SetupPlayerInputComponentCS_PlayerInputComponent_Offset = NativeReflection.GetPropertyOffset(SetupPlayerInputComponentCS_FunctionAddress, "PlayerInputComponent");
		SetupPlayerInputComponentCS_PlayerInputComponent_IsValid = NativeReflection.ValidatePropertyClass(SetupPlayerInputComponentCS_FunctionAddress, "PlayerInputComponent", Classes.FObjectProperty);
		SetupPlayerInputComponentCS_IsValid = SetupPlayerInputComponentCS_FunctionAddress != IntPtr.Zero && SetupPlayerInputComponentCS_PlayerInputComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayerCharacterCS:SetupPlayerInputComponentCS", SetupPlayerInputComponentCS_IsValid);
	}

	static BGUPlayerCharacterCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPlayerCharacterCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPlayerCharacterCS));
	}
}
