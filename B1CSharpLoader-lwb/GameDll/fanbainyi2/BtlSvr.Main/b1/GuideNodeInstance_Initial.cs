using CommB1;
using Google.Protobuf;

namespace b1;

public class GuideNodeInstance_Initial : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.GuideNode.Initial };

	private GuideCustom_Initial CustomData { get; set; }

	private string GroupName => "PlayerGuideGroup";

	public override void PostCreate()
	{
		CustomData = new GuideCustom_Initial();
		CustomData.MergeFrom(base.Node.NodeData);
		foreach (ProcessCustom_Param assetParam in CustomData.AssetParams)
		{
			base.ParentInstance.RegisterParameter(assetParam);
		}
		if (base.ParentInstance != null)
		{
			base.ParentInstance.RegisterGroupStartNodeInstance(GroupName, this);
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}

	public override void OnReset()
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
