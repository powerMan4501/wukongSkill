using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_PlayerMoveToTrainDummyTarget : QuestNodeInstance
{
	private float MoveFinishDistance;

	protected override void PostCreate()
	{
		QuestCustom_PlayerMoveToTrainDummyTarget questCustom_PlayerMoveToTrainDummyTarget = new QuestCustom_PlayerMoveToTrainDummyTarget();
		questCustom_PlayerMoveToTrainDummyTarget.MergeFrom(base.Node.NodeData);
		MoveFinishDistance = questCustom_PlayerMoveToTrainDummyTarget.MoveFinishDistance;
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player);
		if (Player == null)
		{
			TriggerFirstOutput(bFinish: true);
			return;
		}
		b1.IBUC_TrainDummyMgrData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_TrainDummyMgrData, BUC_TrainDummyMgrData>(UGameplayStatics.GetActorOfClass(Player, UClass.GetClass<b1.BGUTrainDummyMgrActor>()));
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsUnitManaged)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Player, unPersistentReadOnlyData.SpawnUnitGuid);
			if (actorByGuid != null && (Player.GetActorLocation() - actorByGuid.GetActorLocation()).Size() > MoveFinishDistance)
			{
				BGUFuncLibAICS.BGURequestAIMoveToTarget(Player, actorByGuid, EAIMoveSpeedType.SPRINT, MoveFinishDistance, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false);
			}
			else
			{
				TriggerFirstOutput(bFinish: true);
			}
		}
	}

	private AActor GetPlayerTarget(AActor Player)
	{
		if (Player == null)
		{
			return null;
		}
		return BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Player)?.GetTargetInfo().LockTargetActor;
	}

	private UnitLockTargetInfo GetPlayerTargetInfo(AActor Player)
	{
		if (Player == null)
		{
			return null;
		}
		return BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Player)?.GetTargetInfo();
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
