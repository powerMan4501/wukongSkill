using b1.CppExport;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestCompBase : UActorCompBaseCS
{
	protected IBUC_GuidData GuidData { get; set; }

	protected new AActor Owner { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		Owner = GetOwner();
		base.BUSEventCollection.Evt_NotifyFromGraph += new Del_Void_GameplayTagContainer(NotifyFromGraph);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BUSEventCollection.Evt_NotifyFromGraph -= new Del_Void_GameplayTagContainer(NotifyFromGraph);
	}

	protected void WriteLog(string Log)
	{
	}

	protected void NotifyGraph(FGameplayTag NotifyTag)
	{
		string finalGuid = GuidData.GetFinalGuid();
		if (IsOnline())
		{
			base.BUSEventCollection.Evt_NotifyGraphClient.Invoke(finalGuid, NotifyTag);
			return;
		}
		base.BGSEventCollection?.Evt_BGS_NotifyGraph.Invoke(finalGuid, NotifyTag);
		base.BGWEventCollection?.Evt_TaskGraphNotifyGraph(finalGuid, NotifyTag);
	}

	protected virtual void NotifyFromGraph(GameplayTagContainerRef NotifyTags)
	{
	}
}
