using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_PlayDBCEfxToInteract : QuestNodeInstance
{
	private string ObservedUnitGuid { get; set; }

	private string DbcEfxPath { get; set; }

	private QuestCustom_PlayDBCEfxToInteract CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayDBCEfxToInteract();
		CustomData.MergeFrom(base.Node.NodeData);
		ObservedUnitGuid = CustomData.ObserveActorGuid;
		DbcEfxPath = CustomData.DbcEfxPath;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, ObservedUnitGuid);
		string[] array = DbcEfxPath.Split('/');
		if (array.Length != 0)
		{
			string text = array[^1];
			string dispConfigDAPath = "BGWDataAsset_B1DBC'" + DbcEfxPath + "." + text + "'";
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_RequestSpawnFXByDispConfig.Invoke(dispConfigDAPath, out var _);
		}
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
