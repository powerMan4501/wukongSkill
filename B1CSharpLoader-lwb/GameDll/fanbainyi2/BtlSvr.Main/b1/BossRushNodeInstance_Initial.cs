using CommB1;
using Google.Protobuf;

namespace b1;

public class BossRushNodeInstance_Initial : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.BossRushNode.Initial };

	private BossRushCustom_InitialV2 CustomData { get; set; }

	public override void PostCreate()
	{
		base.PostCreate();
		CustomData = new BossRushCustom_InitialV2();
		switch (base.Node.CustomDataVersion)
		{
		case 1u:
		{
			BossRushCustom_Initial bossRushCustom_Initial = new BossRushCustom_Initial();
			bossRushCustom_Initial.MergeFrom(base.Node.NodeData);
			CustomData.AssetParams.AddRange(bossRushCustom_Initial.AssetParams);
			CustomData.LevelName = bossRushCustom_Initial.LevelName;
			CustomData.ModifiedLevelState.AddRange(bossRushCustom_Initial.ModifiedLevelState);
			CustomData.PlayerStartForSingle = bossRushCustom_Initial.PlayerStartForSingle;
			CustomData.PlayerStartForGroup = bossRushCustom_Initial.PlayerStartForGroup;
			break;
		}
		case 2u:
			CustomData.MergeFrom(base.Node.NodeData);
			break;
		}
		foreach (ProcessCustom_Param assetParam in CustomData.AssetParams)
		{
			base.ParentInstance.RegisterParameter(assetParam);
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGW_EventCollection.Get(base.ParentInstance.Owner)?.Evt_UpdateBossRushConfig(CustomData);
		TriggerFirstOutput(bFinish: true);
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
