using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AIData : IBUC_AIData
{
	private struct FPursuitRangeStackElement
	{
		public EPursuitRangeReqType ReqType;

		public float PursuitRange;

		public FPursuitRangeStackElement(EPursuitRangeReqType ReqType, float PursuitRange)
		{
			this.ReqType = ReqType;
			this.PursuitRange = PursuitRange;
		}
	}

	public BUS_AIComp.FsmSolverBase CurrentUseSolver;

	private TStrongObjectPtr<UBehaviorTree> mConfigBT = new TStrongObjectPtr<UBehaviorTree>();

	private TStrongObjectPtr<UBehaviorTree> mCurrentRunBT = new TStrongObjectPtr<UBehaviorTree>();

	public AIData_Memory Memory = new AIData_Memory();

	public AIData_BasicTimers Timers = new AIData_BasicTimers();

	public AIData_FsmContext FsmContext = new AIData_FsmContext();

	public int ChargeSkillMoveIdx;

	public bool bCanSetBT;

	public bool bHasRunBT;

	private bool IsMoveInvalidByNav;

	private Entity EQSTarget;

	public bool StopPerception;

	public EUnitAIAttackType UnitAIAttackType;

	public EFsmSolverType OriginFsmSolverType;

	public float AIWatchTimeMin;

	public float AIWatchTimeMax;

	private List<FPursuitRangeStackElement> PursuitRangeStack = new List<FPursuitRangeStackElement>();

	public float HearRange;

	public bool CanSearchTargetWhenSetTeamID;

	public EFsmStateLogicTriggerType GazeAndSurroundTriggerType;

	public EFsmMoveLogicType GazeAndSurroundMoveType;

	public string GazeAndSurroundEQSPath;

	public EFsmStateLogicTriggerType StalemateTriggerType;

	public EFsmMoveLogicType StalemateMoveType;

	public EFsmStateLogicTriggerType ReturnHomeTriggerType;

	public EFsmMoveLogicType ReturnHomeMoveType;

	public int ReturnHomeSkill;

	public int ReturnHomeBuff;

	public bool IsAI { get; set; }

	public UBehaviorTree ConfigBT
	{
		get
		{
			return mConfigBT.Get();
		}
		set
		{
			mConfigBT.Set(value);
		}
	}

	public UBehaviorTree CurrentRunBT
	{
		get
		{
			return mCurrentRunBT.Get();
		}
		set
		{
			mCurrentRunBT.Set(value);
		}
	}

	public bool UseMultipointLock { get; set; }

	public float MultipointLockMaxAngle { get; set; }

	public float MultipointLockDistanceScoreRating { get; set; }

	public AIData_ComboInfo ComboInfo { get; set; } = new AIData_ComboInfo();

	public EFsmSolverType CurrentFsmSolverType { get; set; }

	public int PendingOnFightSkillID { get; set; }

	public bool IsBeHitResetAIWatchTime { get; private set; }

	public bool AlwaysInPursuitRange { get; set; }

	private float PursuitRange { get; set; }

	public EUnitAIDetourCrowdType DetourCrowdType { get; private set; }

	public float SightRange { get; private set; }

	public float VisionAngleDegrees { get; private set; }

	public int DefaultLeftSmallTurnSkillID { get; private set; }

	public int DefaultRightSmallTurnSkillID { get; private set; }

	public int DefaultLeftBigTurnSkillID { get; private set; }

	public int DefaultRightBigTurnSkillID { get; private set; }

	public int DefaultLeftSmallMoveSkillID { get; private set; }

	public int DefaultRightSmallMoveSkillID { get; private set; }

	public int DefaultLeftBigMoveSkillID { get; private set; }

	public int DefaultRightBigMoveSkillID { get; private set; }

	public int HatredTargetRandomSelectNum { get; private set; }

	public float StrongPerceptionDistance { get; private set; }

	public bool CanEffectPlayerBattleState { get; private set; }

	public void CopyBPDataToData(UBehaviorTree BT)
	{
		ConfigBT = BT;
	}

	public void Init(AActor OwnerActor)
	{
		FTransform spawnPosition = BGUFuncLibActorTransformCS.BGUGetActorTransform(OwnerActor);
		int actorResID = BGU_DataUtil.GetActorResID(OwnerActor);
		Memory.Init(spawnPosition);
		ComboInfo.Init(actorResID);
		FsmContext.Init();
		Timers.Init();
		UseMultipointLock = false;
		MultipointLockMaxAngle = 0f;
		MultipointLockDistanceScoreRating = 0f;
		bHasRunBT = false;
		bCanSetBT = true;
		ChargeSkillMoveIdx = 0;
		StopPerception = false;
		CurrentFsmSolverType = EFsmSolverType.Normal;
		OriginFsmSolverType = EFsmSolverType.Normal;
		FUStUnitAIDesc unitAIDesc = BGW_GameDB.GetUnitAIDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(OwnerActor));
		BUC_ConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ConfigInfoData>(OwnerActor);
		if (unitAIDesc != null)
		{
			UseMultipointLock = unitAIDesc.IsUseMultipointLock == EGSYesNo.Yes;
			MultipointLockMaxAngle = unitAIDesc.MultipointLockMaxAngle;
			MultipointLockDistanceScoreRating = FMath.Clamp(FMath.RandRange(unitAIDesc.MultipointLockDistanceScoreRatingMin, unitAIDesc.MultipointLockDistanceScoreRatingMax), 0f, 1f);
			DetourCrowdType = unitAIDesc.DetourCrowdType;
			DefaultLeftSmallTurnSkillID = unitAIDesc.DefaultLeftSmallTurnSkillID;
			DefaultRightSmallTurnSkillID = unitAIDesc.DefaultRightSmallTurnSkillID;
			DefaultLeftBigTurnSkillID = unitAIDesc.DefaultLeftBigTurnSkillID;
			DefaultRightBigTurnSkillID = unitAIDesc.DefaultRightBigTurnSkillID;
			DefaultLeftSmallMoveSkillID = unitAIDesc.DefaultLeftSmallMoveSkillID;
			DefaultRightSmallMoveSkillID = unitAIDesc.DefaultRightSmallMoveSkillID;
			DefaultLeftBigMoveSkillID = unitAIDesc.DefaultLeftBigMoveSkillID;
			DefaultRightBigMoveSkillID = unitAIDesc.DefaultRightBigMoveSkillID;
			HatredTargetRandomSelectNum = unitAIDesc.HatredTargetRandomSelectNum;
			CanSearchTargetWhenSetTeamID = unitAIDesc.CanSearchTargetWhenSetTeamID == EGSYesNo.Yes;
			GazeAndSurroundTriggerType = unitAIDesc.GazeAndSurroundTriggerType;
			GazeAndSurroundMoveType = unitAIDesc.GazeAndSurroundMoveType;
			GazeAndSurroundEQSPath = unitAIDesc.GazeAndSurroundEQSPath;
			StalemateTriggerType = unitAIDesc.StalemateTriggerType;
			StalemateMoveType = unitAIDesc.StalemateMoveType;
			ReturnHomeTriggerType = unitAIDesc.ReturnHomeTriggerType;
			ReturnHomeMoveType = unitAIDesc.ReturnHomeMoveType;
			ReturnHomeSkill = unitAIDesc.ReturnHomeSkill;
			ReturnHomeBuff = unitAIDesc.ReturnHomeBuff;
			StrongPerceptionDistance = unitAIDesc.StrongPerceptionDistance;
			CanEffectPlayerBattleState = unitAIDesc.CanEffectPlayerBattleState == EGSYesNo.Yes;
			if (readOnlyData != null)
			{
				UnitAIAttackType = (readOnlyData.bOverrideUnitAIAttackType ? readOnlyData.UnitAIAttackType : unitAIDesc.UnitAIAttackType);
				OriginFsmSolverType = unitAIDesc.FsmSolverType;
				AIWatchTimeMin = ((readOnlyData.AIWatchTimeMin == -1f) ? unitAIDesc.DefaultAIWatchTimeMin : readOnlyData.AIWatchTimeMin);
				AIWatchTimeMax = ((readOnlyData.AIWatchTimeMax == -1f) ? unitAIDesc.DefaultAIWatchTimeMax : readOnlyData.AIWatchTimeMax);
				IsBeHitResetAIWatchTime = unitAIDesc.IsBeHitResetAIWatchTime == EGSYesNo.Yes;
				SetPursuitRange(EPursuitRangeReqType.Origin, (readOnlyData.PursuitRange == -1f) ? unitAIDesc.PursuitRange : readOnlyData.PursuitRange);
				HearRange = ((readOnlyData.HearRange == -1f) ? unitAIDesc.HearRange : readOnlyData.HearRange);
				SightRange = ((readOnlyData.SightRange == -1f) ? unitAIDesc.SightRange : readOnlyData.SightRange);
				VisionAngleDegrees = ((readOnlyData.VisionAngleDegrees == -1f) ? unitAIDesc.VisionAngleDegrees : readOnlyData.VisionAngleDegrees);
			}
		}
		PendingOnFightSkillID = -1;
	}

	public void SetIsMoveInvalidByNav(bool IsInValid)
	{
		IsMoveInvalidByNav = IsInValid;
	}

	public bool GetIsMoveInValidByNav()
	{
		return IsMoveInvalidByNav;
	}

	public void SetCurEQSTarget(AActor TargetActor)
	{
		if (!TargetActor.IsNullOrDestroyed())
		{
			EQSTarget = ECSUtil.ToEntity(TargetActor);
		}
		else
		{
			EQSTarget = Entity.Null;
		}
	}

	public bool GetIsFirstSkill()
	{
		return ComboInfo.IsFirstSkill;
	}

	public int GetCurComboSkillNum()
	{
		return ComboInfo.CurComboSkillNum;
	}

	public int GetCurComboStage()
	{
		return ComboInfo.CurComboStage;
	}

	public AActor GetCurEQSTarget(AActor Owner)
	{
		return ECSUtil.ToActor(EQSTarget);
	}

	public int GetMaxComboNum()
	{
		if (ComboInfo == null)
		{
			return -1;
		}
		return ComboInfo.MaxComboNum;
	}

	public int GetCurComboLength()
	{
		if (ComboInfo == null)
		{
			return -1;
		}
		return ComboInfo.CurComboLength;
	}

	public float GetWatchTime()
	{
		return Timers.GetWatchTime();
	}

	public float GetStalemateMoveTime()
	{
		return Timers.GetStalemateMoveTime();
	}

	public float GetLastAttackTime()
	{
		return Memory.LastAttackTime;
	}

	public float GetLastBeHitTime()
	{
		return Memory.LastBeHitTime;
	}

	public AActor GetLastAttacker()
	{
		return ECSUtil.ToActor(Memory.LastAttackerEntity);
	}

	public float GetLastAtkDmgTime()
	{
		return Memory.LastAtkDmgTime;
	}

	public List<int> GetGroupAISkillList()
	{
		return Memory.GroupAISkillList;
	}

	public UBehaviorTree GetConfigBT()
	{
		return ConfigBT;
	}

	public UBehaviorTree GetCurrentRunBT()
	{
		return CurrentRunBT;
	}

	public void SetMaxComboNum(int MaxComboNum)
	{
		ComboInfo.SetMaxComboNum(MaxComboNum);
	}

	public void SetCurComboLength(int CurComboLength)
	{
		ComboInfo.CurComboLength = CurComboLength;
	}

	public void SetWatchTime(float WatchTime)
	{
		Timers.SetWatchTime(WatchTime);
	}

	public void SetStalemateMoveTime(float InTime)
	{
		Timers.SetStalemateMoveTime(InTime);
	}

	public void SetLastAttackTime(float LastAttackTime)
	{
		Memory.LastAttackTime = LastAttackTime;
	}

	public void SetLastBeHitTime(float LastBeHitTime)
	{
		Memory.LastBeHitTime = LastBeHitTime;
	}

	public void SetLastAttackerID(AActor LastAttackerID)
	{
		Memory.LastAttackerEntity = ECSUtil.ToEntity(LastAttackerID);
	}

	public void SetLastAtkDmgTime(float LastAtkDmgTime)
	{
		Memory.LastAtkDmgTime = LastAtkDmgTime;
	}

	public void SetGroupAISkill(List<int> SkillIDList)
	{
		Memory.GroupAISkillList = SkillIDList;
	}

	public void SetObstacleCheckResult(float InScore)
	{
		Memory.ObstacleCheckScore = InScore;
	}

	public void SetEscapeLocation(FVector InLocation)
	{
		Memory.EscapeLocation = InLocation;
	}

	public EFsmSolverType GetCurrentFsmSolverType()
	{
		return CurrentUseSolver?.FsmSolverType ?? EFsmSolverType.Normal;
	}

	public void SetPursuitRange(EPursuitRangeReqType ReqType, float PursuitRange)
	{
		PursuitRangeStack.RemoveAll((FPursuitRangeStackElement r) => r.ReqType == ReqType);
		if (PursuitRange >= 0f || ReqType == EPursuitRangeReqType.Origin)
		{
			PursuitRangeStack.Add(new FPursuitRangeStackElement(ReqType, PursuitRange));
		}
		this.PursuitRange = PursuitRangeStack[PursuitRangeStack.Count - 1].PursuitRange;
	}

	public void ResetPursuitRange()
	{
		PursuitRangeStack.RemoveAll((FPursuitRangeStackElement r) => r.ReqType != EPursuitRangeReqType.Origin);
		PursuitRange = ((PursuitRangeStack.Count > 0) ? PursuitRangeStack[PursuitRangeStack.Count - 1].PursuitRange : (-1f));
	}

	public bool IsInPursuitRange(FVector CheckPos)
	{
		if (PursuitRange <= 0f || AlwaysInPursuitRange)
		{
			return true;
		}
		FTransform myPosWhenEnterBattle = Memory.MyPosWhenEnterBattle;
		return FVector.Distance(myPosWhenEnterBattle.GetLocation(), CheckPos) <= PursuitRange;
	}

	public FVector GetEnterBattlePosition()
	{
		return Memory.MyPosWhenEnterBattle.GetLocation();
	}
}
