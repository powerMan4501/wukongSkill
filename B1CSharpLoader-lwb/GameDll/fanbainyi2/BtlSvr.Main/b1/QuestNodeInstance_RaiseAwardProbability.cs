using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_RaiseAwardProbability : QuestNodeInstance
{
	private QuestCustom_RaiseAwardProbability CustomData;

	private EAwardProbabilityRaiseType RaiseType;

	private int Probability;

	private bool CanReduce;

	private int EventId { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_RaiseAwardProbability();
		CustomData.MergeFrom(base.Node.NodeData);
		EventId = CustomData.EventId;
		RaiseType = (EAwardProbabilityRaiseType)CustomData.RaiseType;
		Probability = CustomData.Probability;
		CanReduce = CustomData.CanReduce;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGU_DataUtil.GetReadOnlyData<BGC_RandomEventData>(UGameplayStatics.GetGameState(base.Owner))?.RasieRandomProbabilityById(EventId, RaiseType, Probability, CanReduce);
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
