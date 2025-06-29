using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGU_QuestActor")]
public class BGU_QuestActor : BGUActorBaseCS
{
	private static bool QuestActorType_IsValid;

	private static int QuestActorType_Offset;

	private static FFieldAddress QuestActorType_PropertyAddress;

	private static bool bAutoEnableOverlap_IsValid;

	private static int bAutoEnableOverlap_Offset;

	private static FFieldAddress bAutoEnableOverlap_PropertyAddress;

	private static bool AssignBirthPointID_IsValid;

	private static int AssignBirthPointID_Offset;

	private static bool bAutoEnableDynamicObstacle_IsValid;

	private static int bAutoEnableDynamicObstacle_Offset;

	private static FFieldAddress bAutoEnableDynamicObstacle_PropertyAddress;

	private static bool PerformID_IsValid;

	private static int PerformID_Offset;

	private static bool bEnableDynamicObstacleCollisionDebug_IsValid;

	private static int bEnableDynamicObstacleCollisionDebug_Offset;

	private static FFieldAddress bEnableDynamicObstacleCollisionDebug_PropertyAddress;

	private static bool Timer_InArea_IsValid;

	private static int Timer_InArea_Offset;

	private static bool Timer_OutArea_IsValid;

	private static int Timer_OutArea_Offset;

	private static bool HLMActor_IsValid;

	private static int HLMActor_Offset;

	private static bool NewTrans_HLM_State1_IsValid;

	private static int NewTrans_HLM_State1_Offset;

	private static bool NewTrans_HLM_KillWa_IsValid;

	private static int NewTrans_HLM_KillWa_Offset;

	private static bool bRecoverToNoSpawn_IsValid;

	private static int bRecoverToNoSpawn_Offset;

	private static FFieldAddress bRecoverToNoSpawn_PropertyAddress;

	private static bool SpawnWaveGroupID_IsValid;

	private static int SpawnWaveGroupID_Offset;

	private static bool SpawnWaveGlobleGroupCD_IsValid;

	private static int SpawnWaveGlobleGroupCD_Offset;

	private static bool EnsureBornPosCanNavToPlayer_IsValid;

	private static int EnsureBornPosCanNavToPlayer_Offset;

	private static FFieldAddress EnsureBornPosCanNavToPlayer_PropertyAddress;

	private static bool SpawnWaveType_IsValid;

	private static int SpawnWaveType_Offset;

	private static FFieldAddress SpawnWaveType_PropertyAddress;

	private static bool WaveStopActionType_IsValid;

	private static int WaveStopActionType_Offset;

	private static FFieldAddress WaveStopActionType_PropertyAddress;

	private static bool FirstWaveStartCondition_IsValid;

	private static int FirstWaveStartCondition_Offset;

	private static bool Waves_IsValid;

	private static int Waves_Offset;

	private static FFieldAddress Waves_PropertyAddress;

	private TArrayReadWriteMarshaler<FSpawnWaveConfig> Waves_Marshaler;

	private static bool InfiniteWave_IsValid;

	private static int InfiniteWave_Offset;

	private static bool OnCollisionEndOverlap_IsValid;

	private static IntPtr OnCollisionEndOverlap_FunctionAddress;

	private static int OnCollisionEndOverlap_ParamsSize;

	private static bool OnCollisionEndOverlap_OverlappedComponent_IsValid;

	private static int OnCollisionEndOverlap_OverlappedComponent_Offset;

	private static bool OnCollisionEndOverlap_OtherActor_IsValid;

	private static int OnCollisionEndOverlap_OtherActor_Offset;

	private static bool OnCollisionEndOverlap_OtherComp_IsValid;

	private static int OnCollisionEndOverlap_OtherComp_Offset;

	private static bool OnCollisionEndOverlap_OtherBodyIndex_IsValid;

	private static int OnCollisionEndOverlap_OtherBodyIndex_Offset;

	private IntPtr OnCollisionEndOverlap_InstanceFunctionAddressInstance;

	private static bool OnCollisionBeginOverlap_IsValid;

	private static IntPtr OnCollisionBeginOverlap_FunctionAddress;

	private static int OnCollisionBeginOverlap_ParamsSize;

	private static bool OnCollisionBeginOverlap_OverlappedComponent_IsValid;

	private static int OnCollisionBeginOverlap_OverlappedComponent_Offset;

	private static bool OnCollisionBeginOverlap_OtherActor_IsValid;

	private static int OnCollisionBeginOverlap_OtherActor_Offset;

	private static bool OnCollisionBeginOverlap_OtherComp_IsValid;

	private static int OnCollisionBeginOverlap_OtherComp_Offset;

	private static bool OnCollisionBeginOverlap_OtherBodyIndex_IsValid;

	private static int OnCollisionBeginOverlap_OtherBodyIndex_Offset;

	private static bool OnCollisionBeginOverlap_bFromSweep_IsValid;

	private static int OnCollisionBeginOverlap_bFromSweep_Offset;

	private static FFieldAddress OnCollisionBeginOverlap_bFromSweep_PropertyAddress;

	private static bool OnCollisionBeginOverlap_SweepResult_IsValid;

	private static int OnCollisionBeginOverlap_SweepResult_Offset;

	private static FFieldAddress OnCollisionBeginOverlap_SweepResult_PropertyAddress;

	private IntPtr OnCollisionBeginOverlap_InstanceFunctionAddressInstance;

	private static bool OnEnableDynamicObstacle_IsValid;

	private static IntPtr OnEnableDynamicObstacle_FunctionAddress;

	private static int OnEnableDynamicObstacle_ParamsSize;

	private IntPtr OnEnableDynamicObstacle_InstanceFunctionAddressInstance;

	private static bool OnDisableDynamicObstacle_IsValid;

	private static IntPtr OnDisableDynamicObstacle_FunctionAddress;

	private static int OnDisableDynamicObstacle_ParamsSize;

	private IntPtr OnDisableDynamicObstacle_InstanceFunctionAddressInstance;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[BlueprintReadWrite]
	[Category("Quest")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:QuestActorType")]
	public EQuestActorType QuestActorType
	{
		get
		{
			CheckDestroyed();
			if (!QuestActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:QuestActorType");
				return EQuestActorType.None;
			}
			return EnumMarshaler<EQuestActorType>.FromNative(IntPtr.Add(base.Address, QuestActorType_Offset), 0, QuestActorType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!QuestActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:QuestActorType");
			}
			else
			{
				EnumMarshaler<EQuestActorType>.ToNative(IntPtr.Add(base.Address, QuestActorType_Offset), 0, QuestActorType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Quest|Overlap")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:bAutoEnableOverlap")]
	public bool bAutoEnableOverlap
	{
		get
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bAutoEnableOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bAutoEnableOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Quest|BirthDecideArea")]
	[EditAnywhere]
	[DisplayName("对应的出生点ID")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:AssignBirthPointID")]
	public int AssignBirthPointID
	{
		get
		{
			CheckDestroyed();
			if (!AssignBirthPointID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:AssignBirthPointID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AssignBirthPointID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AssignBirthPointID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:AssignBirthPointID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AssignBirthPointID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Quest|DynamicObstacle")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:bAutoEnableDynamicObstacle")]
	public bool bAutoEnableDynamicObstacle
	{
		get
		{
			CheckDestroyed();
			if (!bAutoEnableDynamicObstacle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bAutoEnableDynamicObstacle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoEnableDynamicObstacle_Offset), 0, bAutoEnableDynamicObstacle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoEnableDynamicObstacle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bAutoEnableDynamicObstacle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoEnableDynamicObstacle_Offset), 0, bAutoEnableDynamicObstacle_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Quest|DynamicObstacle")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:PerformID")]
	public int PerformID
	{
		get
		{
			CheckDestroyed();
			if (!PerformID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:PerformID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PerformID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:PerformID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PerformID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Quest|DynamicObstacle")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:bEnableDynamicObstacleCollisionDebug")]
	public bool bEnableDynamicObstacleCollisionDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDynamicObstacleCollisionDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bEnableDynamicObstacleCollisionDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDynamicObstacleCollisionDebug_Offset), 0, bEnableDynamicObstacleCollisionDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDynamicObstacleCollisionDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bEnableDynamicObstacleCollisionDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDynamicObstacleCollisionDebug_Offset), 0, bEnableDynamicObstacleCollisionDebug_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Quest|隐性区域计时器")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:Timer_InArea")]
	public float Timer_InArea
	{
		get
		{
			CheckDestroyed();
			if (!Timer_InArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:Timer_InArea");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Timer_InArea_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Timer_InArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:Timer_InArea");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Timer_InArea_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Quest|隐性区域计时器")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("填-1，则不开启出区域过期倒计时")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:Timer_OutArea")]
	public float Timer_OutArea
	{
		get
		{
			CheckDestroyed();
			if (!Timer_OutArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:Timer_OutArea");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Timer_OutArea_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Timer_OutArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:Timer_OutArea");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Timer_OutArea_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Quest|红鳞蟒临时")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:HLMActor")]
	public AActor HLMActor
	{
		get
		{
			CheckDestroyed();
			if (!HLMActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:HLMActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, HLMActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HLMActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:HLMActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, HLMActor_Offset), value);
			}
		}
	}

	[Category("Quest|红鳞蟒临时")]
	[DisplayName("红鳞蟒在State1时的Transform")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:NewTrans_HLM_State1")]
	public FTransform NewTrans_HLM_State1
	{
		get
		{
			CheckDestroyed();
			if (!NewTrans_HLM_State1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:NewTrans_HLM_State1");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, NewTrans_HLM_State1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NewTrans_HLM_State1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:NewTrans_HLM_State1");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, NewTrans_HLM_State1_Offset), value);
			}
		}
	}

	[Category("Quest|红鳞蟒临时")]
	[BlueprintReadWrite]
	[DisplayName("红鳞蟒在WaDead后的Transform")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:NewTrans_HLM_KillWa")]
	public FTransform NewTrans_HLM_KillWa
	{
		get
		{
			CheckDestroyed();
			if (!NewTrans_HLM_KillWa_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:NewTrans_HLM_KillWa");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, NewTrans_HLM_KillWa_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NewTrans_HLM_KillWa_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:NewTrans_HLM_KillWa");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, NewTrans_HLM_KillWa_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Quest|SpawnWaves")]
	[DisplayName("存档恢复时若在Spawned中状态跳转回Idle")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:bRecoverToNoSpawn")]
	public bool bRecoverToNoSpawn
	{
		get
		{
			CheckDestroyed();
			if (!bRecoverToNoSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bRecoverToNoSpawn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRecoverToNoSpawn_Offset), 0, bRecoverToNoSpawn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRecoverToNoSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:bRecoverToNoSpawn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRecoverToNoSpawn_Offset), 0, bRecoverToNoSpawn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("组ID")]
	[Category("Quest|SpawnWaves")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:SpawnWaveGroupID")]
	public int SpawnWaveGroupID
	{
		get
		{
			CheckDestroyed();
			if (!SpawnWaveGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:SpawnWaveGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpawnWaveGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnWaveGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:SpawnWaveGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpawnWaveGroupID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Quest|SpawnWaves")]
	[DisplayName("全局组CD")]
	[Tooltip("当前波单位全部死亡时进入冷却CD")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:SpawnWaveGlobleGroupCD")]
	public float SpawnWaveGlobleGroupCD
	{
		get
		{
			CheckDestroyed();
			if (!SpawnWaveGlobleGroupCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:SpawnWaveGlobleGroupCD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpawnWaveGlobleGroupCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnWaveGlobleGroupCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:SpawnWaveGlobleGroupCD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpawnWaveGlobleGroupCD_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Quest|SpawnWaves")]
	[DisplayName("确保出生点到玩家处是Nav连通的")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:EnsureBornPosCanNavToPlayer")]
	public bool EnsureBornPosCanNavToPlayer
	{
		get
		{
			CheckDestroyed();
			if (!EnsureBornPosCanNavToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:EnsureBornPosCanNavToPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnsureBornPosCanNavToPlayer_Offset), 0, EnsureBornPosCanNavToPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnsureBornPosCanNavToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:EnsureBornPosCanNavToPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnsureBornPosCanNavToPlayer_Offset), 0, EnsureBornPosCanNavToPlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Quest|SpawnWaves")]
	[DisplayName("SpawnWave类型")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:SpawnWaveType")]
	public ESpawnWaveType SpawnWaveType
	{
		get
		{
			CheckDestroyed();
			if (!SpawnWaveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:SpawnWaveType");
				return ESpawnWaveType.SpawnSequence;
			}
			return EnumMarshaler<ESpawnWaveType>.FromNative(IntPtr.Add(base.Address, SpawnWaveType_Offset), 0, SpawnWaveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnWaveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:SpawnWaveType");
			}
			else
			{
				EnumMarshaler<ESpawnWaveType>.ToNative(IntPtr.Add(base.Address, SpawnWaveType_Offset), 0, SpawnWaveType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Quest|SpawnWaves")]
	[DisplayName("WaveStop行为类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:WaveStopActionType")]
	public EWaveStopActionType WaveStopActionType
	{
		get
		{
			CheckDestroyed();
			if (!WaveStopActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:WaveStopActionType");
				return EWaveStopActionType.DestroyAllSpawnedUnits;
			}
			return EnumMarshaler<EWaveStopActionType>.FromNative(IntPtr.Add(base.Address, WaveStopActionType_Offset), 0, WaveStopActionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WaveStopActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:WaveStopActionType");
			}
			else
			{
				EnumMarshaler<EWaveStopActionType>.ToNative(IntPtr.Add(base.Address, WaveStopActionType_Offset), 0, WaveStopActionType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("首波次开始条件")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Quest|SpawnWaves")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:FirstWaveStartCondition")]
	public FCompositeCondition_SpawnWaveStart FirstWaveStartCondition
	{
		get
		{
			CheckDestroyed();
			if (!FirstWaveStartCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:FirstWaveStartCondition");
				return default(FCompositeCondition_SpawnWaveStart);
			}
			return FCompositeCondition_SpawnWaveStart.FromNative(IntPtr.Add(base.Address, FirstWaveStartCondition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstWaveStartCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:FirstWaveStartCondition");
			}
			else
			{
				FCompositeCondition_SpawnWaveStart.ToNative(IntPtr.Add(base.Address, FirstWaveStartCondition_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("波次配置_依次Spawn")]
	[Category("Quest|SpawnWaves")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:Waves")]
	public TArrayReadWrite<FSpawnWaveConfig> Waves
	{
		get
		{
			CheckDestroyed();
			if (!Waves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:Waves");
				return null;
			}
			if (Waves_Marshaler == null)
			{
				Waves_Marshaler = new TArrayReadWriteMarshaler<FSpawnWaveConfig>(1, Waves_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveConfig, FSpawnWaveConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveConfig, FSpawnWaveConfig>.ToNative);
			}
			return Waves_Marshaler.FromNative(IntPtr.Add(base.Address, Waves_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("波次配置_循环Spawn")]
	[Category("Quest|SpawnWaves")]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:InfiniteWave")]
	public FSpawnWaveConfig_Infinite InfiniteWave
	{
		get
		{
			CheckDestroyed();
			if (!InfiniteWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:InfiniteWave");
				return default(FSpawnWaveConfig_Infinite);
			}
			return FSpawnWaveConfig_Infinite.FromNative(IntPtr.Add(base.Address, InfiniteWave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfiniteWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_QuestActor:InfiniteWave");
			}
			else
			{
				FSpawnWaveConfig_Infinite.ToNative(IntPtr.Add(base.Address, InfiniteWave_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SpawnWaveGroupID = -1;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		switch (QuestActorType)
		{
		case EQuestActorType.None:
			break;
		case EQuestActorType.Overlap:
			base.ActorCompContainerCS.AddComp(new BUS_QuestOverlapComponent());
			break;
		case EQuestActorType.DynamicObstacle:
			base.ActorCompContainerCS.AddComp(new BUS_QuestDynamicObstacleComp());
			break;
		case EQuestActorType.Checker:
			base.ActorCompContainerCS.AddComp(new BUS_QuestCheckAreaDeathComp());
			break;
		case EQuestActorType.CovertTimer:
			base.ActorCompContainerCS.AddComp(new BUS_QuestCovertTimerOverlapComp());
			break;
		case EQuestActorType.HLMQuest:
			base.ActorCompContainerCS.AddComp(new BUS_HLMQuestStateComp());
			break;
		case EQuestActorType.PlayerChecker:
			base.ActorCompContainerCS.AddComp(new BUS_QuestCheckOnlinePlayerComp());
			break;
		case EQuestActorType.SpawnWaves:
			base.ActorCompContainerCS.AddComp(new BUS_QuestSpawnWavesComp(), 2);
			break;
		case EQuestActorType.BirthDecideArea:
			base.ActorCompContainerCS.AddComp(new b1.BUS_BirthDecideAreaComp());
			break;
		case EQuestActorType.Spawn:
			break;
		}
	}

	protected override void CreateDataContainer(FObjectInitializer Initializer)
	{
		base.DataComp = Initializer.CreateDefaultSubobject<BUS_QuestDataComp>(this, B1GlobalFNames.DataComp);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:OnEnableDynamicObstacle")]
	public unsafe void OnEnableDynamicObstacle()
	{
		CheckDestroyed();
		if (!OnEnableDynamicObstacle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGU_QuestActor:OnEnableDynamicObstacle");
			return;
		}
		if (OnEnableDynamicObstacle_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEnableDynamicObstacle_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnableDynamicObstacle");
		}
		byte* value = stackalloc byte[(int)(uint)OnEnableDynamicObstacle_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEnableDynamicObstacle_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnEnableDynamicObstacle_InstanceFunctionAddressInstance, intPtr, OnEnableDynamicObstacle_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:OnDisableDynamicObstacle")]
	public unsafe void OnDisableDynamicObstacle()
	{
		CheckDestroyed();
		if (!OnDisableDynamicObstacle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGU_QuestActor:OnDisableDynamicObstacle");
			return;
		}
		if (OnDisableDynamicObstacle_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnDisableDynamicObstacle_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnDisableDynamicObstacle");
		}
		byte* value = stackalloc byte[(int)(uint)OnDisableDynamicObstacle_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnDisableDynamicObstacle_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnDisableDynamicObstacle_InstanceFunctionAddressInstance, intPtr, OnDisableDynamicObstacle_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:OnCollisionBeginOverlap")]
	public unsafe void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		CheckDestroyed();
		if (!OnCollisionBeginOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGU_QuestActor:OnCollisionBeginOverlap");
			return;
		}
		if (OnCollisionBeginOverlap_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnCollisionBeginOverlap_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnCollisionBeginOverlap");
		}
		byte* value = stackalloc byte[(int)(uint)OnCollisionBeginOverlap_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnCollisionBeginOverlap_ParamsSize);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_OverlappedComponent_Offset), OverlappedComponent);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_OtherActor_Offset), OtherActor);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_OtherComp_Offset), OtherComp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_OtherBodyIndex_Offset), OtherBodyIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address, bFromSweep);
		NativeReflection.InitializeValue_InContainer(OnCollisionBeginOverlap_SweepResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_SweepResult_Offset), SweepResult);
		NativeReflection.InvokeFunction(base.Address, OnCollisionBeginOverlap_InstanceFunctionAddressInstance, intPtr, OnCollisionBeginOverlap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnCollisionBeginOverlap_SweepResult_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGU_QuestActor:OnCollisionEndOverlap")]
	public unsafe void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		CheckDestroyed();
		if (!OnCollisionEndOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGU_QuestActor:OnCollisionEndOverlap");
			return;
		}
		if (OnCollisionEndOverlap_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnCollisionEndOverlap_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnCollisionEndOverlap");
		}
		byte* value = stackalloc byte[(int)(uint)OnCollisionEndOverlap_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnCollisionEndOverlap_ParamsSize);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, OnCollisionEndOverlap_OverlappedComponent_Offset), OverlappedComponent);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnCollisionEndOverlap_OtherActor_Offset), OtherActor);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, OnCollisionEndOverlap_OtherComp_Offset), OtherComp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnCollisionEndOverlap_OtherBodyIndex_Offset), OtherBodyIndex);
		NativeReflection.InvokeFunction(base.Address, OnCollisionEndOverlap_InstanceFunctionAddressInstance, intPtr, OnCollisionEndOverlap_ParamsSize);
	}

	[USharpPath("/Script/b1-Managed.BGU_QuestActor:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		if (QuestActorType == EQuestActorType.DynamicObstacle)
		{
			BUC_QuestDynamicObstacleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_QuestDynamicObstacleData>(this);
			readOnlyData.Evt_EnableDynamicObstacle = (Del_Void)Delegate.Remove(readOnlyData.Evt_EnableDynamicObstacle, new Del_Void(OnEnableDynamicObstacle));
			readOnlyData.Evt_DisableDynamicObstacle = (Del_Void)Delegate.Remove(readOnlyData.Evt_DisableDynamicObstacle, new Del_Void(OnDisableDynamicObstacle));
		}
		if (QuestActorType == EQuestActorType.Overlap || QuestActorType == EQuestActorType.BirthDecideArea)
		{
			BUC_QuestOverlapData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_QuestOverlapData>(this);
			readOnlyData2.BeginOverlapAction = (Del_CollisionBeginOverlap)Delegate.Remove(readOnlyData2.BeginOverlapAction, new Del_CollisionBeginOverlap(OnCollisionBeginOverlap));
			readOnlyData2.EndOverlapAction = (Del_CollisionEndOverlap)Delegate.Remove(readOnlyData2.EndOverlapAction, new Del_CollisionEndOverlap(OnCollisionEndOverlap));
		}
	}

	[USharpPath("/Script/b1-Managed.BGU_QuestActor:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("SpawnWaveType"))
		{
			ForceRefreshDetailView();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_QuestActor:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_QuestActor bGU_QuestActor = GCHelper.Find<BGU_QuestActor>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGU_QuestActor.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_QuestActor:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_QuestActor bGU_QuestActor = GCHelper.Find<BGU_QuestActor>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bGU_QuestActor.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_QuestActor");
		NativeReflection.GetPropertyRef(ref QuestActorType_PropertyAddress, intPtr, "QuestActorType");
		QuestActorType_Offset = NativeReflection.GetPropertyOffset(intPtr, "QuestActorType");
		QuestActorType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QuestActorType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bAutoEnableOverlap_PropertyAddress, intPtr, "bAutoEnableOverlap");
		bAutoEnableOverlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAutoEnableOverlap");
		bAutoEnableOverlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAutoEnableOverlap", Classes.FBoolProperty);
		AssignBirthPointID_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssignBirthPointID");
		AssignBirthPointID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssignBirthPointID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bAutoEnableDynamicObstacle_PropertyAddress, intPtr, "bAutoEnableDynamicObstacle");
		bAutoEnableDynamicObstacle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAutoEnableDynamicObstacle");
		bAutoEnableDynamicObstacle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAutoEnableDynamicObstacle", Classes.FBoolProperty);
		PerformID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformID");
		PerformID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bEnableDynamicObstacleCollisionDebug_PropertyAddress, intPtr, "bEnableDynamicObstacleCollisionDebug");
		bEnableDynamicObstacleCollisionDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableDynamicObstacleCollisionDebug");
		bEnableDynamicObstacleCollisionDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableDynamicObstacleCollisionDebug", Classes.FBoolProperty);
		Timer_InArea_Offset = NativeReflection.GetPropertyOffset(intPtr, "Timer_InArea");
		Timer_InArea_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Timer_InArea", Classes.FFloatProperty);
		Timer_OutArea_Offset = NativeReflection.GetPropertyOffset(intPtr, "Timer_OutArea");
		Timer_OutArea_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Timer_OutArea", Classes.FFloatProperty);
		HLMActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "HLMActor");
		HLMActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HLMActor", Classes.FObjectProperty);
		NewTrans_HLM_State1_Offset = NativeReflection.GetPropertyOffset(intPtr, "NewTrans_HLM_State1");
		NewTrans_HLM_State1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NewTrans_HLM_State1", Classes.FStructProperty);
		NewTrans_HLM_KillWa_Offset = NativeReflection.GetPropertyOffset(intPtr, "NewTrans_HLM_KillWa");
		NewTrans_HLM_KillWa_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NewTrans_HLM_KillWa", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bRecoverToNoSpawn_PropertyAddress, intPtr, "bRecoverToNoSpawn");
		bRecoverToNoSpawn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRecoverToNoSpawn");
		bRecoverToNoSpawn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRecoverToNoSpawn", Classes.FBoolProperty);
		SpawnWaveGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveGroupID");
		SpawnWaveGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveGroupID", Classes.FIntProperty);
		SpawnWaveGlobleGroupCD_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveGlobleGroupCD");
		SpawnWaveGlobleGroupCD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveGlobleGroupCD", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnsureBornPosCanNavToPlayer_PropertyAddress, intPtr, "EnsureBornPosCanNavToPlayer");
		EnsureBornPosCanNavToPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnsureBornPosCanNavToPlayer");
		EnsureBornPosCanNavToPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnsureBornPosCanNavToPlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpawnWaveType_PropertyAddress, intPtr, "SpawnWaveType");
		SpawnWaveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveType");
		SpawnWaveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref WaveStopActionType_PropertyAddress, intPtr, "WaveStopActionType");
		WaveStopActionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaveStopActionType");
		WaveStopActionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaveStopActionType", Classes.FEnumProperty);
		FirstWaveStartCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstWaveStartCondition");
		FirstWaveStartCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstWaveStartCondition", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Waves_PropertyAddress, intPtr, "Waves");
		Waves_Offset = NativeReflection.GetPropertyOffset(intPtr, "Waves");
		Waves_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Waves", Classes.FArrayProperty);
		InfiniteWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "InfiniteWave");
		InfiniteWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InfiniteWave", Classes.FStructProperty);
		OnCollisionEndOverlap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCollisionEndOverlap");
		OnCollisionEndOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionEndOverlap_FunctionAddress);
		OnCollisionEndOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent");
		OnCollisionEndOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnCollisionEndOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherActor");
		OnCollisionEndOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnCollisionEndOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherComp");
		OnCollisionEndOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnCollisionEndOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex");
		OnCollisionEndOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		OnCollisionEndOverlap_IsValid = OnCollisionEndOverlap_FunctionAddress != IntPtr.Zero && OnCollisionEndOverlap_OverlappedComponent_IsValid && OnCollisionEndOverlap_OtherActor_IsValid && OnCollisionEndOverlap_OtherComp_IsValid && OnCollisionEndOverlap_OtherBodyIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_QuestActor:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
		OnCollisionBeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCollisionBeginOverlap");
		OnCollisionBeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionBeginOverlap_FunctionAddress);
		OnCollisionBeginOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent");
		OnCollisionBeginOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnCollisionBeginOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherActor");
		OnCollisionBeginOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnCollisionBeginOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherComp");
		OnCollisionBeginOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnCollisionBeginOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex");
		OnCollisionBeginOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_bFromSweep_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
		OnCollisionBeginOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
		OnCollisionBeginOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_SweepResult_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
		OnCollisionBeginOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
		OnCollisionBeginOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
		OnCollisionBeginOverlap_IsValid = OnCollisionBeginOverlap_FunctionAddress != IntPtr.Zero && OnCollisionBeginOverlap_OverlappedComponent_IsValid && OnCollisionBeginOverlap_OtherActor_IsValid && OnCollisionBeginOverlap_OtherComp_IsValid && OnCollisionBeginOverlap_OtherBodyIndex_IsValid && OnCollisionBeginOverlap_bFromSweep_IsValid && OnCollisionBeginOverlap_SweepResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_QuestActor:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		OnEnableDynamicObstacle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnableDynamicObstacle");
		OnEnableDynamicObstacle_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnableDynamicObstacle_FunctionAddress);
		OnEnableDynamicObstacle_IsValid = OnEnableDynamicObstacle_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_QuestActor:OnEnableDynamicObstacle", OnEnableDynamicObstacle_IsValid);
		OnDisableDynamicObstacle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDisableDynamicObstacle");
		OnDisableDynamicObstacle_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDisableDynamicObstacle_FunctionAddress);
		OnDisableDynamicObstacle_IsValid = OnDisableDynamicObstacle_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_QuestActor:OnDisableDynamicObstacle", OnDisableDynamicObstacle_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_QuestActor:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_QuestActor:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static BGU_QuestActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_QuestActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_QuestActor));
	}
}
