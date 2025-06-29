using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_PlayerLockTrainDummyTarget : QuestNodeInstance
{
	private QuestCustom_PlayerLockTrainDummyTarget CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayerLockTrainDummyTarget();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		PlayerTryLockTarget();
	}

	private void PlayerTryLockTarget()
	{
		BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player);
		if (!(Player == null))
		{
			b1.IBUC_TrainDummyMgrData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_TrainDummyMgrData, BUC_TrainDummyMgrData>(UGameplayStatics.GetActorOfClass(Player, UClass.GetClass<b1.BGUTrainDummyMgrActor>()));
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsUnitManaged)
			{
				BUS_EventCollectionCS.Get(Player).Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(BGU_DataUtil.GetActorByGuid(base.Owner, unPersistentReadOnlyData.SpawnUnitGuid), ETargetSourceType.None));
				TriggerFirstOutput(bFinish: true);
			}
		}
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
