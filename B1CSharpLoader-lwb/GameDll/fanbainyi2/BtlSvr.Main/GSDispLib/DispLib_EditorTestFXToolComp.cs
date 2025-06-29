using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp")]
public class DispLib_EditorTestFXToolComp : UBaseEditorTickableActorComp
{
	private class SimpleChildEventData
	{
		public float DoPlayTime;

		public int EventIndex;

		public bool CurTickNewSpawned;

		public bool isRealEnd;

		public bool isOnEndDispStage;

		public float GameAge;

		public float EndDispStageStartTime;

		public FVector SystemPosOnEventDoPlay;

		public FQuat SystemRotOnEventDoPlay;

		public FVector CurTickSystemPos;

		public SimpleChildEventData(float _DoPlayTime, int _EventIndex, FVector SystemPos, FQuat SystemRot)
		{
			DoPlayTime = _DoPlayTime;
			CurTickNewSpawned = true;
			EventIndex = _EventIndex;
			SystemPosOnEventDoPlay = SystemPos;
			SystemRotOnEventDoPlay = SystemRot;
			CurTickSystemPos = SystemPosOnEventDoPlay;
		}
	}

	private FHitResult TempHitResult;

	private GSDispLib.TestFXTool_LoopState State;

	private float TimeACC;

	private int CurLoopTickCount;

	private bool CurLoopHasHit;

	private float MultiSpawn_SpawnBrustACC;

	private int MultiSpawnSpawnCountACC;

	private List<SimpleChildEventData> DBCMergeNiagaraAllChildEvent;

	private List<int> MgrList_CurTickNewDoPlayChildEventIndex;

	private List<FVector> MgrList_CurTickChildEventLifeState;

	private List<FVector> MgrList_CurTickChildEventSystemPosWS;

	private List<FQuat> MgrList_CurTickChildEventSystemRotationWS;

	private List<int> MgrList_CurTickValidChildEventIndex;

	private static bool Enable_IsValid;

	private static int Enable_Offset;

	private static FFieldAddress Enable_PropertyAddress;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool SimDBCMergeNiagara_IsValid;

	private static int SimDBCMergeNiagara_Offset;

	private static FFieldAddress SimDBCMergeNiagara_PropertyAddress;

	private static bool SimulaHitTime_IsValid;

	private static int SimulaHitTime_Offset;

	private static bool FlySpeed_IsValid;

	private static int FlySpeed_Offset;

	private static bool AutoResetTimeAfterLoopEnd_IsValid;

	private static int AutoResetTimeAfterLoopEnd_Offset;

	private static bool MultiSpawnSimulaLoopDuration_IsValid;

	private static int MultiSpawnSimulaLoopDuration_Offset;

	private static bool MultiSpawnInfo_SpawnBrust_IsValid;

	private static int MultiSpawnInfo_SpawnBrust_Offset;

	private static bool MultiSpawnInfo_SpawnRate_IsValid;

	private static int MultiSpawnInfo_SpawnRate_Offset;

	private static bool MultiSpawn_EveryChildEventStdPlayingDuration_IsValid;

	private static int MultiSpawn_EveryChildEventStdPlayingDuration_Offset;

	private static bool MultiSpawn_EveryChildEventEndDispStageDuration_IsValid;

	private static int MultiSpawn_EveryChildEventEndDispStageDuration_Offset;

	private static bool MultiSpawn_ChildEventSpawnOnGridPlane_IsValid;

	private static int MultiSpawn_ChildEventSpawnOnGridPlane_Offset;

	private static FFieldAddress MultiSpawn_ChildEventSpawnOnGridPlane_PropertyAddress;

	private static bool MultiSpawn_ChildEventSpawnBoxSize_IsValid;

	private static int MultiSpawn_ChildEventSpawnBoxSize_Offset;

	private static bool MultiSpawn_SimFlyBullet_IsValid;

	private static int MultiSpawn_SimFlyBullet_Offset;

	private static FFieldAddress MultiSpawn_SimFlyBullet_PropertyAddress;

	private static bool MultiSpawn_RandomFlyVelocity_IsValid;

	private static int MultiSpawn_RandomFlyVelocity_Offset;

	private static FFieldAddress MultiSpawn_RandomFlyVelocity_PropertyAddress;

	private static bool MultiSpawn_FlyVelocity_IsValid;

	private static int MultiSpawn_FlyVelocity_Offset;

	private static bool MgrSystemNGActor_IsValid;

	private static int MgrSystemNGActor_Offset;

	private static bool OriginPosWS_IsValid;

	private static int OriginPosWS_Offset;

	private static bool NC_IsValid;

	private static int NC_Offset;

	private static bool HitMarkObj_IsValid;

	private static int HitMarkObj_Offset;

	private static bool ForceCleanAllNiagaraComp_IsValid;

	private static IntPtr ForceCleanAllNiagaraComp_FunctionAddress;

	private static int ForceCleanAllNiagaraComp_ParamsSize;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:Enable")]
	public bool Enable
	{
		get
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:Enable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:Enable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:Template")]
	public UNiagaraSystem Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:Template");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:Template");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:SimDBCMergeNiagara")]
	public bool SimDBCMergeNiagara
	{
		get
		{
			CheckDestroyed();
			if (!SimDBCMergeNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:SimDBCMergeNiagara");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimDBCMergeNiagara_Offset), 0, SimDBCMergeNiagara_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimDBCMergeNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:SimDBCMergeNiagara");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimDBCMergeNiagara_Offset), 0, SimDBCMergeNiagara_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!SimDBCMergeNiagara")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:SimulaHitTime")]
	public float SimulaHitTime
	{
		get
		{
			CheckDestroyed();
			if (!SimulaHitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:SimulaHitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimulaHitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulaHitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:SimulaHitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimulaHitTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!SimDBCMergeNiagara")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:FlySpeed")]
	public float FlySpeed
	{
		get
		{
			CheckDestroyed();
			if (!FlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:FlySpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlySpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:FlySpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlySpeed_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:AutoResetTimeAfterLoopEnd")]
	public float AutoResetTimeAfterLoopEnd
	{
		get
		{
			CheckDestroyed();
			if (!AutoResetTimeAfterLoopEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:AutoResetTimeAfterLoopEnd");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoResetTimeAfterLoopEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoResetTimeAfterLoopEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:AutoResetTimeAfterLoopEnd");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoResetTimeAfterLoopEnd_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnSimulaLoopDuration")]
	public float MultiSpawnSimulaLoopDuration
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawnSimulaLoopDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnSimulaLoopDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MultiSpawnSimulaLoopDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawnSimulaLoopDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnSimulaLoopDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MultiSpawnSimulaLoopDuration_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "X and Y: 每隔X秒，一次性创建Y个特效; Z : 总持续时间超过此值后本次循环停止创建")]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnInfo_SpawnBrust")]
	public FVector MultiSpawnInfo_SpawnBrust
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawnInfo_SpawnBrust_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnInfo_SpawnBrust");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MultiSpawnInfo_SpawnBrust_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawnInfo_SpawnBrust_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnInfo_SpawnBrust");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MultiSpawnInfo_SpawnBrust_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnInfo_SpawnRate")]
	public FVector MultiSpawnInfo_SpawnRate
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawnInfo_SpawnRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnInfo_SpawnRate");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MultiSpawnInfo_SpawnRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawnInfo_SpawnRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawnInfo_SpawnRate");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MultiSpawnInfo_SpawnRate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_EveryChildEventStdPlayingDuration")]
	public float MultiSpawn_EveryChildEventStdPlayingDuration
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_EveryChildEventStdPlayingDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_EveryChildEventStdPlayingDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MultiSpawn_EveryChildEventStdPlayingDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_EveryChildEventStdPlayingDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_EveryChildEventStdPlayingDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MultiSpawn_EveryChildEventStdPlayingDuration_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_EveryChildEventEndDispStageDuration")]
	public float MultiSpawn_EveryChildEventEndDispStageDuration
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_EveryChildEventEndDispStageDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_EveryChildEventEndDispStageDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MultiSpawn_EveryChildEventEndDispStageDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_EveryChildEventEndDispStageDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_EveryChildEventEndDispStageDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MultiSpawn_EveryChildEventEndDispStageDuration_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_ChildEventSpawnOnGridPlane")]
	public bool MultiSpawn_ChildEventSpawnOnGridPlane
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_ChildEventSpawnOnGridPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_ChildEventSpawnOnGridPlane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MultiSpawn_ChildEventSpawnOnGridPlane_Offset), 0, MultiSpawn_ChildEventSpawnOnGridPlane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_ChildEventSpawnOnGridPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_ChildEventSpawnOnGridPlane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MultiSpawn_ChildEventSpawnOnGridPlane_Offset), 0, MultiSpawn_ChildEventSpawnOnGridPlane_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "随机发射时，每次发射都将在此box范围内随机位置；规律发射时，参数表示距离间隔")]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_ChildEventSpawnBoxSize")]
	public FVector MultiSpawn_ChildEventSpawnBoxSize
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_ChildEventSpawnBoxSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_ChildEventSpawnBoxSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MultiSpawn_ChildEventSpawnBoxSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_ChildEventSpawnBoxSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_ChildEventSpawnBoxSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MultiSpawn_ChildEventSpawnBoxSize_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_SimFlyBullet")]
	public bool MultiSpawn_SimFlyBullet
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_SimFlyBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_SimFlyBullet");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MultiSpawn_SimFlyBullet_Offset), 0, MultiSpawn_SimFlyBullet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_SimFlyBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_SimFlyBullet");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MultiSpawn_SimFlyBullet_Offset), 0, MultiSpawn_SimFlyBullet_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_RandomFlyVelocity")]
	public bool MultiSpawn_RandomFlyVelocity
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_RandomFlyVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_RandomFlyVelocity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MultiSpawn_RandomFlyVelocity_Offset), 0, MultiSpawn_RandomFlyVelocity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_RandomFlyVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_RandomFlyVelocity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MultiSpawn_RandomFlyVelocity_Offset), 0, MultiSpawn_RandomFlyVelocity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_FlyVelocity")]
	public FVector MultiSpawn_FlyVelocity
	{
		get
		{
			CheckDestroyed();
			if (!MultiSpawn_FlyVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_FlyVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MultiSpawn_FlyVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSpawn_FlyVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MultiSpawn_FlyVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MultiSpawn_FlyVelocity_Offset), value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MgrSystemNGActor")]
	public AActor MgrSystemNGActor
	{
		get
		{
			CheckDestroyed();
			if (!MgrSystemNGActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MgrSystemNGActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, MgrSystemNGActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MgrSystemNGActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:MgrSystemNGActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, MgrSystemNGActor_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "SimDBCMergeNiagara")]
	[BlueprintReadOnly]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:OriginPosWS")]
	public FVector OriginPosWS
	{
		get
		{
			CheckDestroyed();
			if (!OriginPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:OriginPosWS");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, OriginPosWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OriginPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:OriginPosWS");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, OriginPosWS_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:NC")]
	public UNiagaraComponent NC
	{
		get
		{
			CheckDestroyed();
			if (!NC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:NC");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, NC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:NC");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, NC_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:HitMarkObj")]
	public UStaticMeshComponent HitMarkObj
	{
		get
		{
			CheckDestroyed();
			if (!HitMarkObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:HitMarkObj");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, HitMarkObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitMarkObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTestFXToolComp:HitMarkObj");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, HitMarkObj_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
	}

	private void GetHitMarkObj()
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		base.EndPlayInCS_Implementation(EndPlayReason);
	}

	private bool CheckSettingLegitimate()
	{
		return false;
	}

	private void SpawnNC()
	{
	}

	private void OnHit()
	{
	}

	private void WaitAfterRealEnd()
	{
	}

	private void CleanCurLoop()
	{
	}

	private void Fly(float DeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTestFXToolComp:ForceCleanAllNiagaraComp")]
	public void ForceCleanAllNiagaraComp()
	{
		if (!MgrSystemNGActor.IsNullOrDestroyed())
		{
			MgrSystemNGActor.DestroyActor();
		}
		if (!NC.IsNullOrDestroyed())
		{
			NC.DestroyComponent(GetOwner().World);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTestFXToolComp:ForceCleanAllNiagaraComp")]
	private static void ForceCleanAllNiagaraComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTestFXToolComp dispLib_EditorTestFXToolComp = GCHelper.Find<DispLib_EditorTestFXToolComp>(obj);
		dispLib_EditorTestFXToolComp.ForceCleanAllNiagaraComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTestFXToolComp:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTestFXToolComp dispLib_EditorTestFXToolComp = GCHelper.Find<DispLib_EditorTestFXToolComp>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		dispLib_EditorTestFXToolComp.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTestFXToolComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTestFXToolComp dispLib_EditorTestFXToolComp = GCHelper.Find<DispLib_EditorTestFXToolComp>(obj);
		dispLib_EditorTestFXToolComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTestFXToolComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTestFXToolComp dispLib_EditorTestFXToolComp = GCHelper.Find<DispLib_EditorTestFXToolComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		dispLib_EditorTestFXToolComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorTestFXToolComp");
		NativeReflection.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "Enable");
		Enable_Offset = NativeReflection.GetPropertyOffset(intPtr, "Enable");
		Enable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Enable", Classes.FBoolProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SimDBCMergeNiagara_PropertyAddress, intPtr, "SimDBCMergeNiagara");
		SimDBCMergeNiagara_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimDBCMergeNiagara");
		SimDBCMergeNiagara_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimDBCMergeNiagara", Classes.FBoolProperty);
		SimulaHitTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimulaHitTime");
		SimulaHitTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimulaHitTime", Classes.FFloatProperty);
		FlySpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlySpeed");
		FlySpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlySpeed", Classes.FFloatProperty);
		AutoResetTimeAfterLoopEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoResetTimeAfterLoopEnd");
		AutoResetTimeAfterLoopEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoResetTimeAfterLoopEnd", Classes.FFloatProperty);
		MultiSpawnSimulaLoopDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawnSimulaLoopDuration");
		MultiSpawnSimulaLoopDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawnSimulaLoopDuration", Classes.FFloatProperty);
		MultiSpawnInfo_SpawnBrust_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawnInfo_SpawnBrust");
		MultiSpawnInfo_SpawnBrust_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawnInfo_SpawnBrust", Classes.FStructProperty);
		MultiSpawnInfo_SpawnRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawnInfo_SpawnRate");
		MultiSpawnInfo_SpawnRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawnInfo_SpawnRate", Classes.FStructProperty);
		MultiSpawn_EveryChildEventStdPlayingDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_EveryChildEventStdPlayingDuration");
		MultiSpawn_EveryChildEventStdPlayingDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_EveryChildEventStdPlayingDuration", Classes.FFloatProperty);
		MultiSpawn_EveryChildEventEndDispStageDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_EveryChildEventEndDispStageDuration");
		MultiSpawn_EveryChildEventEndDispStageDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_EveryChildEventEndDispStageDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MultiSpawn_ChildEventSpawnOnGridPlane_PropertyAddress, intPtr, "MultiSpawn_ChildEventSpawnOnGridPlane");
		MultiSpawn_ChildEventSpawnOnGridPlane_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_ChildEventSpawnOnGridPlane");
		MultiSpawn_ChildEventSpawnOnGridPlane_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_ChildEventSpawnOnGridPlane", Classes.FBoolProperty);
		MultiSpawn_ChildEventSpawnBoxSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_ChildEventSpawnBoxSize");
		MultiSpawn_ChildEventSpawnBoxSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_ChildEventSpawnBoxSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref MultiSpawn_SimFlyBullet_PropertyAddress, intPtr, "MultiSpawn_SimFlyBullet");
		MultiSpawn_SimFlyBullet_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_SimFlyBullet");
		MultiSpawn_SimFlyBullet_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_SimFlyBullet", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MultiSpawn_RandomFlyVelocity_PropertyAddress, intPtr, "MultiSpawn_RandomFlyVelocity");
		MultiSpawn_RandomFlyVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_RandomFlyVelocity");
		MultiSpawn_RandomFlyVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_RandomFlyVelocity", Classes.FBoolProperty);
		MultiSpawn_FlyVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSpawn_FlyVelocity");
		MultiSpawn_FlyVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSpawn_FlyVelocity", Classes.FStructProperty);
		MgrSystemNGActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "MgrSystemNGActor");
		MgrSystemNGActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MgrSystemNGActor", Classes.FObjectProperty);
		OriginPosWS_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriginPosWS");
		OriginPosWS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriginPosWS", Classes.FStructProperty);
		NC_Offset = NativeReflection.GetPropertyOffset(intPtr, "NC");
		NC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NC", Classes.FObjectProperty);
		HitMarkObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitMarkObj");
		HitMarkObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitMarkObj", Classes.FObjectProperty);
		ForceCleanAllNiagaraComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceCleanAllNiagaraComp");
		ForceCleanAllNiagaraComp_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceCleanAllNiagaraComp_FunctionAddress);
		ForceCleanAllNiagaraComp_IsValid = ForceCleanAllNiagaraComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTestFXToolComp:ForceCleanAllNiagaraComp", ForceCleanAllNiagaraComp_IsValid);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTestFXToolComp:EndPlayInCS", EndPlayInCS_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTestFXToolComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTestFXToolComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static DispLib_EditorTestFXToolComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorTestFXToolComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorTestFXToolComp));
	}
}
