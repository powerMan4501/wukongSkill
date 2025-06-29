using b1.CppExport;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class PsmStateNodeInstance_NotifySelf : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.NotifySelf";

	private GameplayTagContainerRef NotifyTags { get; set; }

	private ProcessStateCustom_NotifySelf CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_NotifySelf();
		CustomData.MergeFrom(base.Node.NodeData);
		NotifyTags = new GameplayTagContainerRef();
		foreach (string notifyTagString in CustomData.NotifyTagStrings)
		{
			NotifyTags.AddTag(GameplayTagExtension.MakeGameplayTag(notifyTagString));
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		foreach (FGameplayTag notifyTag in NotifyTags)
		{
			base.ParentInstance.ParentInstance.OnEvent(notifyTag);
		}
		TriggerFirstOutput(bFinish: true);
	}
}
