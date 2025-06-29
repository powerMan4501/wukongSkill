using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmNodeInstance_Initial : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[2]
	{
		B1CalliopeDef.ProcessMachineNode.Initial,
		B1CalliopeDef.BossRushNode.Initial
	};

	private ProcessCustom_Initial CustomData { get; set; }

	public override void PostCreate()
	{
		base.PostCreate();
		if (base.Node.CustomDataVersion != 1)
		{
			return;
		}
		CustomData = new ProcessCustom_Initial();
		CustomData.MergeFrom(base.Node.NodeData);
		foreach (ProcessCustom_Param assetParam in CustomData.AssetParams)
		{
			base.ParentInstance.RegisterParameter(assetParam);
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
