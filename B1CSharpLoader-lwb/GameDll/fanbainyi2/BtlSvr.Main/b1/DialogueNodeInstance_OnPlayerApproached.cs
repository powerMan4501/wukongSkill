using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class DialogueNodeInstance_OnPlayerApproached : FBehaviorRightNodeInstance
{
	private DialogueCustom_OnPlayerApproached CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.DialogueNode.OnPlayerApproached;

	protected override void PostCreate()
	{
		CustomData = new DialogueCustom_OnPlayerApproached();
		CustomData.MergeFrom(base.Node.NodeData);
		base.BUSEventCollection.Evt_OnPlayerApproached += new Del_Void_Actor(OnPlayerApproached);
	}

	private void OnPlayerApproached(AActor PlayerActor)
	{
		if (CustomData.ResId <= 0)
		{
			NotifyTriggerInput();
		}
		else if (BGU_DataUtil.GetActorResID(PlayerActor) == CustomData.ResId)
		{
			NotifyTriggerInput();
		}
	}

	protected override void Shutdown()
	{
		base.BUSEventCollection.Evt_OnPlayerApproached -= new Del_Void_Actor(OnPlayerApproached);
	}
}
