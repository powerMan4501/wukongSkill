using System.Collections.Generic;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_NpcMoveTo : FIdleProcessExecutorBase
{
	private class AIMoveTask
	{
		private string UnitGuid;

		private string TargetActorGuid;

		private ENpcMoveType NpcMoveType;

		private EAIMoveSpeedType MoveSpeedType;

		private EBGUMoveAIType MoveAIType;

		private float AcceptableRadius;

		private bool NeedSwitchSpeedByDistanceToPlayer;

		private float MaxDistance_Sprint;

		private float MaxDistance_Run;

		private float MaxDistance_Jog;

		private float DistanceBuffer;

		public AIMoveTask(string _UnitGuid, ENpcMoveType _NpcMoveType, string _TargetActorGuid, EAIMoveSpeedType _MoveSpeedType, EBGUMoveAIType _MoveAIType, float _AcceptableRadius)
		{
			UnitGuid = _UnitGuid;
			NpcMoveType = _NpcMoveType;
			TargetActorGuid = _TargetActorGuid;
			MoveSpeedType = _MoveSpeedType;
			MoveAIType = _MoveAIType;
			AcceptableRadius = _AcceptableRadius;
		}

		public AIMoveTask(string _UnitGuid, ENpcMoveType _NpcMoveType, string _SplineActorGuid, bool _NeedSwitchSpeedByDistanceToPlayer, EAIMoveSpeedType _MoveSpeedType, float _MaxDistance_Sprint, float _MaxDistance_Run, float _MaxDistance_Jog, float _DistanceBuffer)
		{
			UnitGuid = _UnitGuid;
			NpcMoveType = _NpcMoveType;
			TargetActorGuid = _SplineActorGuid;
			NeedSwitchSpeedByDistanceToPlayer = _NeedSwitchSpeedByDistanceToPlayer;
			MoveSpeedType = _MoveSpeedType;
			MaxDistance_Sprint = _MaxDistance_Sprint;
			MaxDistance_Run = _MaxDistance_Run;
			MaxDistance_Jog = _MaxDistance_Jog;
			DistanceBuffer = _DistanceBuffer;
		}

		public bool CheckMoveFinished(UObject WorldContext)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(WorldContext, UnitGuid);
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(WorldContext, TargetActorGuid);
			if (actorByGuid == null || actorByGuid2 == null)
			{
				return false;
			}
			switch (NpcMoveType)
			{
			case ENpcMoveType.Navigation:
				BGUFuncLibAICS.BGURequestAIMoveToTarget(actorByGuid, actorByGuid2, MoveSpeedType, 0f, MoveAIType, IncludeSelfRadius: true, IncludeTargetRadius: true);
				if ((actorByGuid.GetActorLocation() - actorByGuid2.GetActorLocation()).Size() < AcceptableRadius)
				{
					OnExitAction(WorldContext);
					return true;
				}
				return false;
			case ENpcMoveType.Spline:
				BGUFuncLibForMove.BGUNpcGuideSplineMove(bEnableNpcGuideSplineMove: true, actorByGuid, TargetActorGuid, NeedSwitchSpeedByDistanceToPlayer, MoveSpeedType, MaxDistance_Sprint, MaxDistance_Run, MaxDistance_Jog, DistanceBuffer);
				return true;
			default:
				return false;
			}
		}

		public void OnExitAction(UObject WorldContext)
		{
			BGUFuncLibForMove.CancelMove(BGU_DataUtil.GetActorByGuid(WorldContext, UnitGuid));
		}
	}

	private List<AIMoveTask> AIMoveTasks = new List<AIMoveTask>();

	public override EIdleProcessActionType ActionType => EIdleProcessActionType.NpcMoveTo;

	private float DistanceBuffer { get; set; }

	private float MaxDistance_Jog { get; set; }

	private float MaxDistance_Run { get; set; }

	private float MaxDistance_Sprint { get; set; }

	private bool NeedSwitchSpeedByDistanceToPlayer { get; set; }

	private float MoveAcceptableRadius { get; set; }

	private EBGUMoveAIType MoveAIType { get; set; }

	private EAIMoveSpeedType MoveSpeedType { get; set; }

	private string TargetActorGuid { get; set; }

	private string UnitGuid { get; set; }

	private ENpcMoveType NpcMoveType { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		NpcMoveType = (ENpcMoveType)InIdleProcessAction.NpcMoveType;
		TargetActorGuid = InIdleProcessAction.TargetActorGuid;
		MoveAIType = (EBGUMoveAIType)InIdleProcessAction.MoveAiType;
		MoveSpeedType = (EAIMoveSpeedType)InIdleProcessAction.MoveSpeedType;
		MoveAcceptableRadius = InIdleProcessAction.MoveAcceptableRadius;
		NeedSwitchSpeedByDistanceToPlayer = InIdleProcessAction.NeedSwitchSpeedByDistanceToPlayer;
		MaxDistance_Sprint = InIdleProcessAction.MaxDistanceSprint;
		MaxDistance_Run = InIdleProcessAction.MaxDistanceRun;
		MaxDistance_Jog = InIdleProcessAction.MaxDistanceJog;
		DistanceBuffer = InIdleProcessAction.DistanceBuffer;
		PsmInstance parentInstance = InPsmNodeInstance.ParentInstance;
		if (parentInstance != null)
		{
			UnitGuid = parentInstance.ConvertParamID2UnitGuid(InIdleProcessAction.UnitGuid);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		switch (NpcMoveType)
		{
		case ENpcMoveType.Navigation:
			AIMoveTasks.Add(new AIMoveTask(UnitGuid, NpcMoveType, TargetActorGuid, MoveSpeedType, MoveAIType, MoveAcceptableRadius));
			break;
		case ENpcMoveType.Spline:
			AIMoveTasks.Add(new AIMoveTask(UnitGuid, NpcMoveType, TargetActorGuid, NeedSwitchSpeedByDistanceToPlayer, MoveSpeedType, MaxDistance_Sprint, MaxDistance_Run, MaxDistance_Jog, DistanceBuffer));
			break;
		}
	}

	public override void Shutdown(UObject InWorldContext)
	{
		foreach (AIMoveTask aIMoveTask in AIMoveTasks)
		{
			aIMoveTask.OnExitAction(InWorldContext);
		}
		AIMoveTasks.Clear();
	}

	public override void OnTick(UObject InWorldContext, float InDeltaTime)
	{
		for (int num = AIMoveTasks.Count - 1; num >= 0; num--)
		{
			if (AIMoveTasks[num].CheckMoveFinished(InWorldContext))
			{
				AIMoveTasks.RemoveAt(num);
			}
		}
	}

	public override bool IsFinished()
	{
		return AIMoveTasks.Count == 0;
	}
}
