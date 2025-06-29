using System.Linq;
using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_AiConversation : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.AiConversation;

	public BehaviorCustom_AiConversation CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_AiConversation();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		if (CustomData != null)
		{
			string text = "";
			if (base.ParentInstance != null && base.ParentInstance.TemplateAsset != null)
			{
				text = base.ParentInstance.TemplateAsset.AssetPath;
			}
			string sourceLog = "CBG:" + text;
			base.BGSEventCollection?.Evt_PocessEventByContentIDList.Invoke(sourceLog, base.Owner, CustomData.ContentIdList.ToList());
		}
	}
}
