using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestRegCollectionCompBase : UActorCompBaseCS
{
	protected new AActor Owner { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		Owner = GetOwner();
		base.BUSEventCollection.Evt_NotifyGraphClient += new Del_NotifyGraphClient(OnNotifyGraphClient);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BUSEventCollection.Evt_NotifyGraphClient -= new Del_NotifyGraphClient(OnNotifyGraphClient);
	}

	private void OnNotifyGraphClient(string FinalGuid, FGameplayTag NotifyTag)
	{
		base.BGSEventCollection.Evt_BGS_NotifyGraph.Invoke(FinalGuid, NotifyTag);
		base.BGWEventCollection.Evt_TaskGraphNotifyGraph(FinalGuid, NotifyTag);
	}
}
