using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_ForceOriginalFormComp : BUS_QuestOverlapComponent
{
	private BUC_ForceOriginalFormData ForceOriginalFormData;

	private bool FixCheck;

	public override void OnAttach()
	{
		base.OnAttach();
		ForceOriginalFormData = RequireWritableData<BUC_ForceOriginalFormData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (FixCheck)
		{
			return;
		}
		BGUForceOriginalFormTriggerBoxActor bGUForceOriginalFormTriggerBoxActor = GetOwner() as BGUForceOriginalFormTriggerBoxActor;
		if (bGUForceOriginalFormTriggerBoxActor != null)
		{
			List<AActor> OverlappingActors = new List<AActor>();
			bGUForceOriginalFormTriggerBoxActor.ForceOriginalFormTriggerBox.GetOverlappingActors(out OverlappingActors, null);
			foreach (AActor item in OverlappingActors)
			{
				OnActorEnter(bGUForceOriginalFormTriggerBoxActor, item);
			}
		}
		FixCheck = true;
	}

	protected override void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = OtherActor.GetInstigatorController() as BGP_PlayerControllerCS;
		if (!(bGP_PlayerControllerCS == null))
		{
			GetPlayerEventCollection(bGP_PlayerControllerCS)?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.DisableTransformBegin, -1f);
			int actorResID = BGU_DataUtil.GetActorResID(OtherActor);
			ForceOriginalFormData.OverrideSkillIDs.TryGetValue(actorResID, out var value);
			PlayerTransParam playerTransParam = new PlayerTransParam
			{
				TransSkillId = value
			};
			BPS_EventCollectionCS.Get(bGP_PlayerControllerCS.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.TriggerBoxForceTransBack, playerTransParam);
		}
	}

	protected override void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = OtherActor.GetInstigatorController() as BGP_PlayerControllerCS;
		if (!(bGP_PlayerControllerCS == null))
		{
			GetPlayerEventCollection(bGP_PlayerControllerCS)?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.DisableTransformEnd, -1f);
		}
	}

	private BPS_GSEventCollection GetPlayerEventCollection(BGP_PlayerControllerCS PC)
	{
		return (PC.PlayerState as BGP_PlayerStateCS).PlayerEventCollection;
	}
}
