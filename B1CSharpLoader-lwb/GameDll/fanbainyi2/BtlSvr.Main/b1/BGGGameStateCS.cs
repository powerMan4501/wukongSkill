using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGGGameStateCS")]
public abstract class BGGGameStateCS : ABGWGameState, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	public static List<WeakReference<BGGGameStateCS>> s_weakReferences;

	private bool InDispatchScope;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	private static bool HandleBeginPlayCS_IsValid;

	private static IntPtr HandleBeginPlayCS_FunctionAddress;

	private static int HandleBeginPlayCS_ParamsSize;

	private static bool HandleLeavingMapCS_IsValid;

	private static IntPtr HandleLeavingMapCS_FunctionAddress;

	private static int HandleLeavingMapCS_ParamsSize;

	private static bool OnTickDispatchEventCS_IsValid;

	private static IntPtr OnTickDispatchEventCS_FunctionAddress;

	private static int OnTickDispatchEventCS_ParamsSize;

	private static bool OnTickDispatchEventCS_DeltaTime_IsValid;

	private static int OnTickDispatchEventCS_DeltaTime_Offset;

	private static bool HandleMatchHasEndedCS_IsValid;

	private static IntPtr HandleMatchHasEndedCS_FunctionAddress;

	private static int HandleMatchHasEndedCS_ParamsSize;

	private static bool HandleMatchHasStartedCS_IsValid;

	private static IntPtr HandleMatchHasStartedCS_FunctionAddress;

	private static int HandleMatchHasStartedCS_ParamsSize;

	private static bool IsGSEventDebuggerOpenCS_IsValid;

	private static IntPtr IsGSEventDebuggerOpenCS_FunctionAddress;

	private static int IsGSEventDebuggerOpenCS_ParamsSize;

	private static bool IsGSEventDebuggerOpenCS_ReturnValue_IsValid;

	private static int IsGSEventDebuggerOpenCS_ReturnValue_Offset;

	private static FFieldAddress IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress;

	private static bool OnPostTickDispatchEventCS_IsValid;

	private static IntPtr OnPostTickDispatchEventCS_FunctionAddress;

	private static int OnPostTickDispatchEventCS_ParamsSize;

	private static bool PostInitializeComponentsCS_IsValid;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool HandleMatchIsWaitingToStartCS_IsValid;

	private static IntPtr HandleMatchIsWaitingToStartCS_FunctionAddress;

	private static int HandleMatchIsWaitingToStartCS_ParamsSize;

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

	public UActorDataContainer DataComp => base.BGSDataComp;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGGGameStateCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGGGameStateCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGGGameStateCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	public int ECSArcheType => 2;

	public BGS_GSEventCollection GameEventCollection { get; set; }

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	public sealed override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		CreateDataContainer(initializer);
	}

	protected abstract void CreateDataContainer(FObjectInitializer initializer);

	public object GetEventCollection()
	{
		return GameEventCollection;
	}

	public virtual void InitAllComp()
	{
		ActorCompContainerCS.AddComp(new BGS_GameStateTestSystem());
		ActorCompContainerCS.AddComp(new BGS_DataReplicationSystemClient(), 8);
		ActorCompContainerCS.AddComp(new BGS_DataReplicationSystemSvr(), 2);
		ActorCompContainerCS.AddComp(new b1.BGS_LevelBattleSystem());
		ActorCompContainerCS.AddComp(new BGS_OnlineChallengeSystem(), 2);
		ActorCompContainerCS.AddComp(new b1.BGS_OnlineChallengeClientSystem());
		ActorCompContainerCS.AddComp(new BGS_OnlineAssistSystem(), 4);
		ActorCompContainerCS.AddComp(new BGS_OnlineAssistClientSystem());
		ActorCompContainerCS.AddComp(new b1.BGS_DropItemSystem(), 2);
		ActorCompContainerCS.AddComp(new BGS_PredictionSystem(), 12);
		ActorCompContainerCS.AddComp(new BGS_PredictionStateSystem());
		ActorCompContainerCS.AddComp(new BGS_GlobalBattleStateSystem());
		ActorCompContainerCS.AddComp(new BGS_SimpleOverlapMgrSystem());
		ActorCompContainerCS.AddComp(new BGS_FollowPartnerSystem());
		ActorCompContainerCS.AddComp(new BGS_AssociationUnitSysten());
		ActorCompContainerCS.AddComp(new BGS_GroupAISystem());
		ActorCompContainerCS.AddComp(new b1.BGS_MovieSystem());
		ActorCompContainerCS.AddComp(new BGS_BattleTriggerMgr());
		ActorCompContainerCS.AddComp(new BGS_DebugTargetMgr());
		ActorCompContainerCS.AddComp(new BGS_EQSFunctionBinderMgr());
		ActorCompContainerCS.AddComp(new BGS_SpiderNavigationMgr());
		ActorCompContainerCS.AddComp(new BGS_SceneInactiveObjectMgr());
		ActorCompContainerCS.AddComp(new BGS_TeamRelationMgr());
		ActorCompContainerCS.AddComp(new BGS_RuntimeMeshActorsMgr());
		ActorCompContainerCS.AddComp(new BGS_UnitPatrolGroupMgr());
		ActorCompContainerCS.AddComp(new BGS_GameBgmMgr());
		ActorCompContainerCS.AddComp(new b1.BGS_LevelActorManager());
		ActorCompContainerCS.AddComp(new b1.BGS_ProjectileManager());
		ActorCompContainerCS.AddComp(new b1.BGS_WeaponManager());
		ActorCompContainerCS.AddComp(new b1.BGS_LineTraceMgr());
		ActorCompContainerCS.AddComp(new b1.BGS_AiConversationMgr());
		ActorCompContainerCS.AddComp(new BGS_PlayMontageProxyMgr());
		ActorCompContainerCS.AddComp(new b1.BGS_PigsyStorySystem());
		ActorCompContainerCS.AddComp(new BGS_SpawnWaveGroupMgr());
		ActorCompContainerCS.AddComp(new BGS_SoulItemMgr());
		ActorCompContainerCS.AddComp(new b1.BGS_NeutralAnimalSpawnMgr());
		ActorCompContainerCS.AddComp(new b1.BGS_BattleFieldPerformanceOptMgr());
		ActorCompContainerCS.AddComp(new b1.BGS_FieldSystem());
		ActorCompContainerCS.AddComp(new BGS_AnimationSyncSystem());
		ActorCompContainerCS.AddComp(new BGS_LocalFluid2DMgr());
		ActorCompContainerCS.AddComp(new BGS_TransEffectSystem());
		ActorCompContainerCS.AddComp(new BGS_SimpleOverlapMgrSystem_ThreadBlocker());
		ActorCompContainerCS.AddComp(new BGS_FoliageInteractSoundMgr());
		ActorCompContainerCS.AddComp(new BGS_SkillPreviewMgr());
		ActorCompContainerCS.AddComp(new BGS_SharedDataMgr());
		ActorCompContainerCS.AddComp(new BGS_LifeTimeSystem());
		ActorCompContainerCS.AddComp(new BGS_GroupLeisureSyncSystem());
		ActorCompContainerCS.AddComp(new BGS_QuestSystem());
		ActorCompContainerCS.AddComp(new b1.BGS_TamerManagerSystem());
		ActorCompContainerCS.AddComp(new BGS_CircusControlSystem());
		ActorCompContainerCS.AddComp(new BGS_RenderTargetMgr());
		ActorCompContainerCS.AddComp(new BGS_GSCamShakeMgr());
		ActorCompContainerCS.AddComp(new BGS_BuffDispMgr());
		ActorCompContainerCS.AddComp(new BGS_OnlineTeammateMgr());
		ActorCompContainerCS.AddComp(new BGS_SummonManagerSystem(), 2);
		ActorCompContainerCS.AddComp(new BGS_EnvMgrSystem());
		ActorCompContainerCS.AddComp(new BGS_BattleSupercomputingCenterSystem());
		ActorCompContainerCS.AddComp(new b1.BGS_GlobalAIMgrSystem());
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:HandleBeginPlayCS")]
	protected override void HandleBeginPlayCS_Implementation()
	{
		base.HandleBeginPlayCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:HandleLeavingMapCS")]
	protected override void HandleLeavingMapCS_Implementation()
	{
		base.HandleLeavingMapCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:HandleMatchHasStartedCS")]
	protected override void HandleMatchHasStartedCS_Implementation()
	{
		base.HandleMatchHasStartedCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:HandleMatchHasEndedCS")]
	protected override void HandleMatchHasEndedCS_Implementation()
	{
		base.HandleMatchHasEndedCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:HandleMatchIsWaitingToStartCS")]
	protected override void HandleMatchIsWaitingToStartCS_Implementation()
	{
		base.HandleMatchIsWaitingToStartCS_Implementation();
	}

	public virtual void AfterInitAllComp()
	{
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:OnTickDispatchEventCS")]
	protected override void OnTickDispatchEventCS_Implementation(float DeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:OnPostTickDispatchEventCS")]
	protected override void OnPostTickDispatchEventCS_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:IsGSEventDebuggerOpenCS")]
	protected override bool IsGSEventDebuggerOpenCS_Implementation()
	{
		return false;
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:PostInitializeComponentsCS")]
	protected override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
		BGW_ECSWorld.RegisterDataComp(DataComp);
		if (DebugConfig.EventMemoryLeakTest)
		{
			s_weakReferences.Add(new WeakReference<BGGGameStateCS>(this));
		}
	}

	[USharpPath("/Script/b1-Managed.BGGGameStateCS:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	static BGGGameStateCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGGGameStateCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGGGameStateCS));
		s_weakReferences = new List<WeakReference<BGGGameStateCS>>();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGGGameStateCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.ReceiveDestroyed_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:HandleBeginPlayCS")]
	private static void HandleBeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.HandleBeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:HandleLeavingMapCS")]
	private static void HandleLeavingMapCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.HandleLeavingMapCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:OnTickDispatchEventCS")]
	private static void OnTickDispatchEventCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnTickDispatchEventCS_DeltaTime_Offset));
		bGGGameStateCS.OnTickDispatchEventCS_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:HandleMatchHasEndedCS")]
	private static void HandleMatchHasEndedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.HandleMatchHasEndedCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:HandleMatchHasStartedCS")]
	private static void HandleMatchHasStartedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.HandleMatchHasStartedCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:IsGSEventDebuggerOpenCS")]
	private static void IsGSEventDebuggerOpenCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bool value = bGGGameStateCS.IsGSEventDebuggerOpenCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsGSEventDebuggerOpenCS_ReturnValue_Offset), 0, IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:OnPostTickDispatchEventCS")]
	private static void OnPostTickDispatchEventCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.OnPostTickDispatchEventCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.PostInitializeComponentsCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGGGameStateCS:HandleMatchIsWaitingToStartCS")]
	private static void HandleMatchIsWaitingToStartCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGGGameStateCS bGGGameStateCS = GCHelper.Find<BGGGameStateCS>(obj);
		bGGGameStateCS.HandleMatchIsWaitingToStartCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGGGameStateCS");
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:ReceiveDestroyed", ReceiveDestroyed_IsValid);
		HandleBeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleBeginPlayCS");
		HandleBeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleBeginPlayCS_FunctionAddress);
		HandleBeginPlayCS_IsValid = HandleBeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:HandleBeginPlayCS", HandleBeginPlayCS_IsValid);
		HandleLeavingMapCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleLeavingMapCS");
		HandleLeavingMapCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleLeavingMapCS_FunctionAddress);
		HandleLeavingMapCS_IsValid = HandleLeavingMapCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:HandleLeavingMapCS", HandleLeavingMapCS_IsValid);
		OnTickDispatchEventCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTickDispatchEventCS");
		OnTickDispatchEventCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickDispatchEventCS_FunctionAddress);
		OnTickDispatchEventCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(OnTickDispatchEventCS_FunctionAddress, "DeltaTime");
		OnTickDispatchEventCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(OnTickDispatchEventCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTickDispatchEventCS_IsValid = OnTickDispatchEventCS_FunctionAddress != IntPtr.Zero && OnTickDispatchEventCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:OnTickDispatchEventCS", OnTickDispatchEventCS_IsValid);
		HandleMatchHasEndedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchHasEndedCS");
		HandleMatchHasEndedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchHasEndedCS_FunctionAddress);
		HandleMatchHasEndedCS_IsValid = HandleMatchHasEndedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:HandleMatchHasEndedCS", HandleMatchHasEndedCS_IsValid);
		HandleMatchHasStartedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchHasStartedCS");
		HandleMatchHasStartedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchHasStartedCS_FunctionAddress);
		HandleMatchHasStartedCS_IsValid = HandleMatchHasStartedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:HandleMatchHasStartedCS", HandleMatchHasStartedCS_IsValid);
		IsGSEventDebuggerOpenCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsGSEventDebuggerOpenCS");
		IsGSEventDebuggerOpenCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGSEventDebuggerOpenCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress, IsGSEventDebuggerOpenCS_FunctionAddress, "ReturnValue");
		IsGSEventDebuggerOpenCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsGSEventDebuggerOpenCS_FunctionAddress, "ReturnValue");
		IsGSEventDebuggerOpenCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsGSEventDebuggerOpenCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGSEventDebuggerOpenCS_IsValid = IsGSEventDebuggerOpenCS_FunctionAddress != IntPtr.Zero && IsGSEventDebuggerOpenCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:IsGSEventDebuggerOpenCS", IsGSEventDebuggerOpenCS_IsValid);
		OnPostTickDispatchEventCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostTickDispatchEventCS");
		OnPostTickDispatchEventCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostTickDispatchEventCS_FunctionAddress);
		OnPostTickDispatchEventCS_IsValid = OnPostTickDispatchEventCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:OnPostTickDispatchEventCS", OnPostTickDispatchEventCS_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		HandleMatchIsWaitingToStartCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchIsWaitingToStartCS");
		HandleMatchIsWaitingToStartCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchIsWaitingToStartCS_FunctionAddress);
		HandleMatchIsWaitingToStartCS_IsValid = HandleMatchIsWaitingToStartCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGGGameStateCS:HandleMatchIsWaitingToStartCS", HandleMatchIsWaitingToStartCS_IsValid);
	}
}
