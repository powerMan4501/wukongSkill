using System.Linq;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_AiConversation : QuestNodeInstance
{
	private QuestCustom_AiConversation CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_AiConversation();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor aActor = ((!(CustomData.CasterGuid == B1GlobalFNames.Player_Wukong.PlainName)) ? BGU_DataUtil.GetActorByGuid(base.Owner, CustomData.CasterGuid) : UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn());
		if (!aActor.IsNullOrDestroyed())
		{
			string text = "";
			if (base.ParentInstance != null && base.ParentInstance.TemplateAsset != null)
			{
				text = base.ParentInstance.TemplateAsset.AssetPath;
			}
			string sourceLog = "CQG:" + text;
			BGS_EventCollectionCS.Get(aActor)?.Evt_PocessEventByContentIDList.Invoke(sourceLog, aActor, CustomData.ContentIds.ToList());
		}
		TriggerFirstOutput(bFinish: true);
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
