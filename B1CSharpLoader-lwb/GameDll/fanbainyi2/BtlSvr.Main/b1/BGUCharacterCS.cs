using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCharacterCS")]
public class BGUCharacterCS : ABGUCharacter, INetWorkedECSWorldObj, IECSWorldObj, ITeamCS
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private static int sCSharpUIDAlloc;

	public int CSharpUID = -1;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool GetActorGuidCS_IsValid;

	private static IntPtr GetActorGuidCS_FunctionAddress;

	private static int GetActorGuidCS_ParamsSize;

	private static bool GetActorGuidCS_OutActorGuid_IsValid;

	private static int GetActorGuidCS_OutActorGuid_Offset;

	private static FFieldAddress GetActorGuidCS_OutActorGuid_PropertyAddress;

	private static bool GetActorGuidCS_ReturnValue_IsValid;

	private static int GetActorGuidCS_ReturnValue_Offset;

	private static FFieldAddress GetActorGuidCS_ReturnValue_PropertyAddress;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	private static bool OnActorChannelOpen_IsValid;

	private static IntPtr OnActorChannelOpen_FunctionAddress;

	private static int OnActorChannelOpen_ParamsSize;

	private static bool OnActorChannelOpen_Connection_IsValid;

	private static int OnActorChannelOpen_Connection_Offset;

	private static bool IsPlayerCharacterCS_IsValid;

	private static IntPtr IsPlayerCharacterCS_FunctionAddress;

	private static int IsPlayerCharacterCS_ParamsSize;

	private static bool IsPlayerCharacterCS_ReturnValue_IsValid;

	private static int IsPlayerCharacterCS_ReturnValue_Offset;

	private static FFieldAddress IsPlayerCharacterCS_ReturnValue_PropertyAddress;

	private static bool PostNetReceiveRoleCS_IsValid;

	private static IntPtr PostNetReceiveRoleCS_FunctionAddress;

	private static int PostNetReceiveRoleCS_ParamsSize;

	private static bool GetGSAuthorityPlayerCS_IsValid;

	private static IntPtr GetGSAuthorityPlayerCS_FunctionAddress;

	private static int GetGSAuthorityPlayerCS_ParamsSize;

	private static bool GetGSAuthorityPlayerCS_ReturnValue_IsValid;

	private static int GetGSAuthorityPlayerCS_ReturnValue_Offset;

	private static bool OnMovementModeChangedCS_IsValid;

	private static IntPtr OnMovementModeChangedCS_FunctionAddress;

	private static int OnMovementModeChangedCS_ParamsSize;

	private static bool OnMovementModeChangedCS_PrevMovementMode_IsValid;

	private static int OnMovementModeChangedCS_PrevMovementMode_Offset;

	private static FFieldAddress OnMovementModeChangedCS_PrevMovementMode_PropertyAddress;

	private static bool OnMovementModeChangedCS_NewMovementMode_IsValid;

	private static int OnMovementModeChangedCS_NewMovementMode_Offset;

	private static FFieldAddress OnMovementModeChangedCS_NewMovementMode_PropertyAddress;

	private static bool OnMovementModeChangedCS_PrevCustomMode_IsValid;

	private static int OnMovementModeChangedCS_PrevCustomMode_Offset;

	private static bool OnMovementModeChangedCS_NewCustomMode_IsValid;

	private static int OnMovementModeChangedCS_NewCustomMode_Offset;

	private static bool PostInitializeComponentsCS_IsValid;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool PreDestroyFromReplicationCS_IsValid;

	private static IntPtr PreDestroyFromReplicationCS_FunctionAddress;

	private static int PreDestroyFromReplicationCS_ParamsSize;

	public Entity ECSEntity
	{
		get
		{
			return mECSEntity;
		}
		set
		{
			mECSEntity = value;
		}
	}

	public Chunk ECSChunk
	{
		get
		{
			return mECSChunk;
		}
		set
		{
			mECSChunk = value;
		}
	}

	public int ECSIndexInChunk
	{
		get
		{
			return mECSIndexInChunk;
		}
		set
		{
			mECSIndexInChunk = value;
		}
	}

	public int ECSArcheType { get; protected set; }

	private BUS_GSEventCollection RPCEventCollection { get; set; }

	private int ResID { get; set; }

	private int OverrideBattleInfoExtendID { get; set; }

	private int DefaultBattleInfoExtendID { get; set; }

	private int TeamIDInCS { get; set; }

	public bool bCanAsPerformer { get; set; }

	public bool bCanAsNPC { get; set; }

	public bool bCanAsFollowPartner { get; set; }

	public bool bBossRoomMonster { get; set; }

	public int AbnormalDispID_AsAttacker_Default { get; set; }

	public int AbnormalDispID_AsVictim_Default { get; set; }

	public int AbnormalDispID_AsAttacker_Override { get; set; }

	public int AbnormalDispID_AsVictim_Override { get; set; }

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUCharacterCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCharacterCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCharacterCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	public UActorDataContainer DataComp => base.BGUDataComp;

	public IBUC_PassiveSkillData PassiveSkillData { get; private set; }

	public ETamerType TamerType { get; set; }

	public override void GetLifetimeReplicatedProps(FLifetimePropertyCollection lifetimeProps)
	{
		base.GetLifetimeReplicatedProps(lifetimeProps);
		lifetimeProps.Add("RPCEventCollection");
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:PreDestroyFromReplicationCS")]
	protected override void PreDestroyFromReplicationCS_Implementation()
	{
		_ = DebugConfig.DebugGSRepRole;
		if (!UGSE_OnlineFuncLib.InServerReal(this))
		{
			FTamerRef fTamerRef = (GetTamerOwner() as BUTamerActor)?.CurrentRef;
			if (fTamerRef != null && !UGSE_OnlineFuncLib.InServerReal(this))
			{
				fTamerRef?.OnClientMonsterPreDestroyFromReplication();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:OnActorChannelOpen")]
	protected override void OnActorChannelOpen_Implementation(UNetConnection Connection)
	{
		base.OnActorChannelOpen_Implementation(Connection);
		_ = DebugConfig.DebugGSRepRole;
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:GetGSAuthorityPlayerCS")]
	protected override APlayerController GetGSAuthorityPlayerCS_Implementation()
	{
		return BGU_DataUtil.GetGameModeReadonlyData<BGC_ServerTamerAuthData>(this).GetServerTamerAuthPlayer(BGU_DataUtil.GetActorGuid(this, bFindFromComponent: true));
	}

	protected virtual void InitBGUDataComp(FObjectInitializer initializer)
	{
		base.BGUDataComp = initializer.CreateDefaultSubobject<BUS_BGUDataComp>(this, B1GlobalFNames.UBGUDataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		if (CSharpUID < 0)
		{
			CSharpUID = ++sCSharpUIDAlloc;
		}
		base.Initialize(initializer);
		base.AlwaysRelevant = true;
		RPCEventCollection = initializer.CreateDefaultSubobject<BUS_GSEventCollection>(this, B1GlobalFNames.RPCEventCollection);
		RPCEventCollection.Replicates = true;
		ECSArcheType = 6;
		InitBGUDataComp(initializer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		ActorCompContainerCS.bUserForUnit = true;
		base.Mesh.SetReceivesDecals(bNewReceivesDecals: false);
		AbnormalDispID_AsAttacker_Override = -1;
		AbnormalDispID_AsVictim_Override = -1;
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:PostInitializeComponentsCS")]
	protected override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
		BGW_ECSWorld.RegisterDataComp(DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	public object GetEventCollection()
	{
		return RPCEventCollection;
	}

	public void InitialConfigInfo(int InResId, int InOverrideID)
	{
		ResID = InResId;
		OverrideBattleInfoExtendID = InOverrideID;
		DefaultBattleInfoExtendID = 0;
		base.BGUDataComp.InitWithCharacter(this);
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(InResId);
		if (unitCommDesc != null)
		{
			DefaultBattleInfoExtendID = unitCommDesc.DefaultBattleInfoExtendID;
			TeamIDInCS = unitCommDesc.TeamID;
		}
		AbnormalDispID_AsAttacker_Default = 0;
		AbnormalDispID_AsVictim_Default = 0;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			AbnormalDispID_AsAttacker_Default = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
			AbnormalDispID_AsVictim_Default = unitBattleInfoExtendDesc.AbnormalDispVictimID;
		}
	}

	protected void InitialCacheData()
	{
		PassiveSkillData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(this);
	}

	protected void InitialFromTamer()
	{
		BUTamerActor bUTamerActor = GetTamerOwner() as BUTamerActor;
		if (bUTamerActor == null)
		{
			return;
		}
		InitialConfigInfo(bUTamerActor.ConfigInfoComp.UnitCDesc.ResID, bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID);
		bCanAsPerformer = bUTamerActor.ExtendConfigComp.bCanAsPerformer;
		bCanAsNPC = bUTamerActor.ExtendConfigComp.bCanAsNPC;
		bCanAsFollowPartner = bUTamerActor.ExtendConfigComp.bCanAsFollowPartner;
		if (B1Global.GIsBossRushMode)
		{
			if (bUTamerActor.TamerType == ETamerType.LevelLoaded)
			{
				bBossRoomMonster = true;
			}
		}
		else
		{
			IBGC_GlobalBattleStateData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>(this);
			if (gameStateReadonlyData != null)
			{
				bBossRoomMonster = gameStateReadonlyData.IsBossRoomMonster(bUTamerActor.GetFinalGuid());
			}
		}
		FUnitCompFlagConfig flagConfig = bUTamerActor.ConfigInfoComp.FlagConfig;
		EActorCompAlterFlag eActorCompAlterFlag = (EActorCompAlterFlag)0L;
		foreach (KeyValuePair<string, bool> monsterAlterTag in flagConfig.MonsterAlterTags)
		{
			if (monsterAlterTag.Value && Enum.TryParse<EActorCompAlterFlag>(monsterAlterTag.Key, out var result))
			{
				eActorCompAlterFlag |= result;
			}
		}
		EActorCompRejectFlag eActorCompRejectFlag = (EActorCompRejectFlag)0L;
		foreach (KeyValuePair<string, bool> monsterRejectTag in flagConfig.MonsterRejectTags)
		{
			if (monsterRejectTag.Value && Enum.TryParse<EActorCompRejectFlag>(monsterRejectTag.Key, out var result2))
			{
				eActorCompRejectFlag |= result2;
			}
		}
		ActorCompContainerCS.InitialCompSet(flagConfig.UnitTemplateType, eActorCompAlterFlag, eActorCompRejectFlag);
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:IsPlayerCharacterCS")]
	protected override bool IsPlayerCharacterCS_Implementation()
	{
		return false;
	}

	public virtual void InitAllComp()
	{
	}

	public virtual void AfterInitAllComp()
	{
		ActorCompContainerCS.RegisterUnitComp<b1.BUS_ActorTransformInfoComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.AlwaysCantMove);
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		if (TamerType == ETamerType.None && !IsPlayerCharacterCS())
		{
			DestroyActor();
			return;
		}
		base.ReceiveBeginPlay_Implementation();
		FullyInit();
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
		UBGUFunctionLibraryForCS.RemoveAllQueriesByQuerier(this);
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:OnMovementModeChangedCS")]
	protected override void OnMovementModeChangedCS_Implementation(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
	{
		if (IsBeginPlayFinished())
		{
			if (NewMovementMode == EMovementMode.MOVE_Falling && PrevMovementMode != EMovementMode.MOVE_Falling)
			{
				BUS_EventCollectionCS.Get(this)?.Evt_FallingStart.Invoke();
			}
			else if (PrevMovementMode == EMovementMode.MOVE_Falling && NewMovementMode != EMovementMode.MOVE_Falling)
			{
				BUS_EventCollectionCS.Get(this)?.Evt_OnLeaveFalling.Invoke();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:GetActorGuidCS")]
	protected override bool GetActorGuidCS_Implementation(out string OutActorGuid)
	{
		OutActorGuid = BGU_DataUtil.GetActorGuid(this, bFindFromComponent: true);
		return !string.IsNullOrEmpty(OutActorGuid);
	}

	[USharpPath("/Script/b1-Managed.BGUCharacterCS:PostNetReceiveRoleCS")]
	protected override void PostNetReceiveRoleCS_Implementation()
	{
		base.PostNetReceiveRoleCS_Implementation();
		BPS_EventCollectionCS.GetLocal(this)?.Evt_BPS_BGUCharaterNetReceiveRole.Invoke(this);
	}

	public void FreshNetRole(bool HasAuthority)
	{
		GSSwapNetRoleCS(HasAuthority);
		int actorNetRole = BGUFuncLibReplication.GetActorNetRole(this);
		if (HasAuthority)
		{
			ABGUAIController aBGUAIController = GetController() as ABGUAIController;
			if (aBGUAIController == null)
			{
				ForceSpawnDefaultControllerCS();
				BUS_BGUDataComp componentByClass = GetComponentByClass<BUS_BGUDataComp>();
				if (componentByClass != null)
				{
					aBGUAIController = GetController() as ABGUAIController;
					if (aBGUAIController != null)
					{
						componentByClass.InitWithAIController(aBGUAIController);
					}
				}
			}
		}
		ActorCompContainerCS.FreshActorNetRole(actorNetRole);
		(DataComp as BUS_BGUDataCompBase).FreshNetRole(actorNetRole);
	}

	public int GetFinalBattleInfoExtendID()
	{
		if (OverrideBattleInfoExtendID <= 0)
		{
			return DefaultBattleInfoExtendID;
		}
		return OverrideBattleInfoExtendID;
	}

	public int GetFinalAbnormalDispID_AsAttacker()
	{
		if (AbnormalDispID_AsAttacker_Override < 0)
		{
			return AbnormalDispID_AsAttacker_Default;
		}
		return AbnormalDispID_AsAttacker_Override;
	}

	public int GetFinalAbnormalDispID_AsVictim()
	{
		if (AbnormalDispID_AsVictim_Override < 0)
		{
			return AbnormalDispID_AsVictim_Default;
		}
		return AbnormalDispID_AsVictim_Override;
	}

	public int GetResID()
	{
		return ResID;
	}

	public void SetTeamIDInCS(int NewTeamID)
	{
		TeamIDInCS = NewTeamID;
	}

	public int GetTeamIDInCS()
	{
		return TeamIDInCS;
	}

	public void SetCustomTimeDilation_ForAllCSharpComps(float CustomTimeDilation)
	{
		ActorCompContainerCS.SetAllCompCustomTimeDilation(CustomTimeDilation);
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:GetActorGuidCS")]
	private static void GetActorGuidCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		string OutActorGuid;
		bool actorGuidCS_Implementation = bGUCharacterCS.GetActorGuidCS_Implementation(out OutActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address, actorGuidCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_OutActorGuid_Offset), OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUCharacterCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		bGUCharacterCS.ReceiveBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		bGUCharacterCS.ReceiveDestroyed_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:OnActorChannelOpen")]
	private static void OnActorChannelOpen__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		UNetConnection connection = UObjectMarshaler<UNetConnection>.FromNative(IntPtr.Add(buffer, OnActorChannelOpen_Connection_Offset));
		bGUCharacterCS.OnActorChannelOpen_Implementation(connection);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:IsPlayerCharacterCS")]
	private static void IsPlayerCharacterCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		bool value = bGUCharacterCS.IsPlayerCharacterCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsPlayerCharacterCS_ReturnValue_Offset), 0, IsPlayerCharacterCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:PostNetReceiveRoleCS")]
	private static void PostNetReceiveRoleCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		bGUCharacterCS.PostNetReceiveRoleCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:GetGSAuthorityPlayerCS")]
	private static void GetGSAuthorityPlayerCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		APlayerController gSAuthorityPlayerCS_Implementation = bGUCharacterCS.GetGSAuthorityPlayerCS_Implementation();
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(buffer, GetGSAuthorityPlayerCS_ReturnValue_Offset), gSAuthorityPlayerCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:OnMovementModeChangedCS")]
	private static void OnMovementModeChangedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		EMovementMode prevMovementMode = EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(buffer, OnMovementModeChangedCS_PrevMovementMode_Offset), 0, OnMovementModeChangedCS_PrevMovementMode_PropertyAddress.Address);
		EMovementMode newMovementMode = EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(buffer, OnMovementModeChangedCS_NewMovementMode_Offset), 0, OnMovementModeChangedCS_NewMovementMode_PropertyAddress.Address);
		byte prevCustomMode = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(buffer, OnMovementModeChangedCS_PrevCustomMode_Offset));
		byte newCustomMode = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(buffer, OnMovementModeChangedCS_NewCustomMode_Offset));
		bGUCharacterCS.OnMovementModeChangedCS_Implementation(prevMovementMode, newMovementMode, prevCustomMode, newCustomMode);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		bGUCharacterCS.PostInitializeComponentsCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCharacterCS:PreDestroyFromReplicationCS")]
	private static void PreDestroyFromReplicationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS bGUCharacterCS = GCHelper.Find<BGUCharacterCS>(obj);
		bGUCharacterCS.PreDestroyFromReplicationCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUCharacterCS");
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:GetActorGuidCS", GetActorGuidCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:ReceiveDestroyed", ReceiveDestroyed_IsValid);
		OnActorChannelOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnActorChannelOpen");
		OnActorChannelOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorChannelOpen_FunctionAddress);
		OnActorChannelOpen_Connection_Offset = NativeReflection.GetPropertyOffset(OnActorChannelOpen_FunctionAddress, "Connection");
		OnActorChannelOpen_Connection_IsValid = NativeReflection.ValidatePropertyClass(OnActorChannelOpen_FunctionAddress, "Connection", Classes.FObjectProperty);
		OnActorChannelOpen_IsValid = OnActorChannelOpen_FunctionAddress != IntPtr.Zero && OnActorChannelOpen_Connection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:OnActorChannelOpen", OnActorChannelOpen_IsValid);
		IsPlayerCharacterCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayerCharacterCS");
		IsPlayerCharacterCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayerCharacterCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsPlayerCharacterCS_ReturnValue_PropertyAddress, IsPlayerCharacterCS_FunctionAddress, "ReturnValue");
		IsPlayerCharacterCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsPlayerCharacterCS_FunctionAddress, "ReturnValue");
		IsPlayerCharacterCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsPlayerCharacterCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayerCharacterCS_IsValid = IsPlayerCharacterCS_FunctionAddress != IntPtr.Zero && IsPlayerCharacterCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:IsPlayerCharacterCS", IsPlayerCharacterCS_IsValid);
		PostNetReceiveRoleCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostNetReceiveRoleCS");
		PostNetReceiveRoleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostNetReceiveRoleCS_FunctionAddress);
		PostNetReceiveRoleCS_IsValid = PostNetReceiveRoleCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:PostNetReceiveRoleCS", PostNetReceiveRoleCS_IsValid);
		GetGSAuthorityPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGSAuthorityPlayerCS");
		GetGSAuthorityPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSAuthorityPlayerCS_FunctionAddress);
		GetGSAuthorityPlayerCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetGSAuthorityPlayerCS_FunctionAddress, "ReturnValue");
		GetGSAuthorityPlayerCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetGSAuthorityPlayerCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGSAuthorityPlayerCS_IsValid = GetGSAuthorityPlayerCS_FunctionAddress != IntPtr.Zero && GetGSAuthorityPlayerCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:GetGSAuthorityPlayerCS", GetGSAuthorityPlayerCS_IsValid);
		OnMovementModeChangedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMovementModeChangedCS");
		OnMovementModeChangedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMovementModeChangedCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMovementModeChangedCS_PrevMovementMode_PropertyAddress, OnMovementModeChangedCS_FunctionAddress, "PrevMovementMode");
		OnMovementModeChangedCS_PrevMovementMode_Offset = NativeReflection.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "PrevMovementMode");
		OnMovementModeChangedCS_PrevMovementMode_IsValid = NativeReflection.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "PrevMovementMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref OnMovementModeChangedCS_NewMovementMode_PropertyAddress, OnMovementModeChangedCS_FunctionAddress, "NewMovementMode");
		OnMovementModeChangedCS_NewMovementMode_Offset = NativeReflection.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "NewMovementMode");
		OnMovementModeChangedCS_NewMovementMode_IsValid = NativeReflection.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "NewMovementMode", Classes.FEnumProperty);
		OnMovementModeChangedCS_PrevCustomMode_Offset = NativeReflection.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "PrevCustomMode");
		OnMovementModeChangedCS_PrevCustomMode_IsValid = NativeReflection.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "PrevCustomMode", Classes.FByteProperty);
		OnMovementModeChangedCS_NewCustomMode_Offset = NativeReflection.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "NewCustomMode");
		OnMovementModeChangedCS_NewCustomMode_IsValid = NativeReflection.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "NewCustomMode", Classes.FByteProperty);
		OnMovementModeChangedCS_IsValid = OnMovementModeChangedCS_FunctionAddress != IntPtr.Zero && OnMovementModeChangedCS_PrevMovementMode_IsValid && OnMovementModeChangedCS_NewMovementMode_IsValid && OnMovementModeChangedCS_PrevCustomMode_IsValid && OnMovementModeChangedCS_NewCustomMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:OnMovementModeChangedCS", OnMovementModeChangedCS_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		PreDestroyFromReplicationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreDestroyFromReplicationCS");
		PreDestroyFromReplicationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreDestroyFromReplicationCS_FunctionAddress);
		PreDestroyFromReplicationCS_IsValid = PreDestroyFromReplicationCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCharacterCS:PreDestroyFromReplicationCS", PreDestroyFromReplicationCS_IsValid);
	}

	static BGUCharacterCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCharacterCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCharacterCS));
	}
}
