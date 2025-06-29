using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_StoryAreaLogicComp : UActorCompBaseCS
{
	private string OwnerGUID;

	public override void OnAttach()
	{
		OwnerGUID = BGU_DataUtil.GetActorGuid(Owner);
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorExit);
	}

	public override void OnBeginPlay()
	{
	}

	private void OnActorEnter(AActor OtherActor)
	{
		b1.BGUStoryArea bGUStoryArea = Owner as b1.BGUStoryArea;
		if (!(bGUStoryArea == null) && !OtherActor.IsNullOrDestroyed())
		{
			base.BGSEventCollection?.Evt_IntoSpecificStoryArea.Invoke(OwnerGUID, bGUStoryArea.Pority, bGUStoryArea.AreaID);
		}
	}

	private void OnActorExit(AActor OtherActor)
	{
		if (!OtherActor.IsNullOrDestroyed())
		{
			base.BGSEventCollection?.Evt_ExitSpecificStoryArea.Invoke(OwnerGUID);
		}
	}
}
