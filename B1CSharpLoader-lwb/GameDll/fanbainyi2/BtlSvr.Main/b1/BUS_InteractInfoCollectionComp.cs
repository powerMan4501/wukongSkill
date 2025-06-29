using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_InteractInfoCollectionComp : UActorCompBaseCS
{
	private b1.BUC_InteractInfoCollectionData InteractInfoCollectionData;

	private IBUC_TickRateData TickRateData;

	private BGW_DynamicSDFMgr SDFMgr;

	public override void OnAttach()
	{
		InteractInfoCollectionData = RequireWritableData<b1.BUC_InteractInfoCollectionData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		base.BUSEventCollection.Evt_InteractOverrideBegin += new Del_InteractOverrideBegin(InteractScaleBegin);
		base.BUSEventCollection.Evt_InteractOverrideEnd += new Del_Void_Int(InteractScaleEnd);
		base.BUSEventCollection.Evt_RegistExtraInteractBones += new Del_RegistExtraInteractBones(RegistExtraInteractBones);
		base.BUSEventCollection.Evt_CancelExtraInteractBones += new Del_Void_Int(CancelExtraInteractBones);
		base.BUSEventCollection.Evt_TriggerPerformerStateChange += new Del_TriggerPerformerStateChange(TriggerPerformerStateChange);
		base.BUSEventCollection.Evt_TriggerNPCShowStateChange += new Del_TriggerNPCShowStateChange(TriggerNPCShowStateChange);
		base.BUSEventCollection.Evt_SwitchDispInteractConfig += new Del_SwitchDispInteractConfig(SwitchDispInteractConfig);
		base.BUSEventCollection.Evt_ResetDispInteractConfig += new Del_Void(ResetDispInteractConfig);
	}

	public override void OnBeginPlay()
	{
		EnableInteract();
		SDFMgr = BGW_DynamicSDFMgr.Get(Owner);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (InteractInfoCollectionData.EnableInteract)
		{
			float AccumulatedDeltaTime;
			float DifferenceTimeToLast100ms;
			float DifferenceTimeToLast200ms;
			float DifferenceTimeToLast500ms;
			float DifferenceTimeToLast1000ms;
			if (TickRateData == null)
			{
				SDFMgr?.UpdateUnitLocalDistance(Owner);
			}
			else if (TickRateData.CanTickFor500msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms))
			{
				SDFMgr?.UpdateUnitLocalDistance(Owner);
			}
		}
	}

	private void InteractScaleBegin(int NotifyID, TArrayReadWrite<DispInteractOverride> OverrideInfoArr)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed() || InteractInfoCollectionData.InteractOverrideMap.ContainsKey(NotifyID))
		{
			return;
		}
		float timeSeconds = owner.World.GetTimeSeconds();
		List<DispInteractOverride> list = new List<DispInteractOverride>();
		foreach (DispInteractOverride item in OverrideInfoArr)
		{
			DispInteractOverride current = item;
			current.StartTime = timeSeconds;
			list.Add(current);
		}
		InteractInfoCollectionData.InteractOverrideMap.Add(NotifyID, list);
	}

	private void InteractScaleEnd(int NotifyID)
	{
		if (InteractInfoCollectionData.InteractOverrideMap.ContainsKey(NotifyID))
		{
			InteractInfoCollectionData.InteractOverrideMap.Remove(NotifyID);
		}
	}

	private void RegistExtraInteractBones(int NotifyID, TArrayReadWrite<FBoneUseForDispMap> InteractBones)
	{
		if (InteractInfoCollectionData.ExtraDispInteractBones.ContainsKey(NotifyID))
		{
			return;
		}
		List<FBoneUseForDispMap> list = new List<FBoneUseForDispMap>();
		foreach (FBoneUseForDispMap InteractBone in InteractBones)
		{
			list.Add(InteractBone);
		}
		InteractInfoCollectionData.ExtraDispInteractBones.Add(NotifyID, list);
	}

	private void CancelExtraInteractBones(int NotifyID)
	{
		if (InteractInfoCollectionData.ExtraDispInteractBones.ContainsKey(NotifyID))
		{
			InteractInfoCollectionData.ExtraDispInteractBones.Remove(NotifyID);
		}
	}

	private void CloseInteract()
	{
		InteractInfoCollectionData.EnableInteract = false;
		SDFMgr?.LogoutInteractObj(Owner);
	}

	private void EnableInteract()
	{
		InteractInfoCollectionData.EnableInteract = true;
	}

	private void TriggerPerformerStateChange(bool Enable)
	{
		if (Enable)
		{
			EnableInteract();
		}
		else
		{
			CloseInteract();
		}
	}

	private void TriggerNPCShowStateChange(bool Enable)
	{
		if (Enable)
		{
			EnableInteract();
		}
		else
		{
			CloseInteract();
		}
	}

	private void SwitchDispInteractConfig(List<FBoneUseForDispMap> DispInteractBoneList_New)
	{
		if (DispInteractBoneList_New != null)
		{
			InteractInfoCollectionData.DispInteractBoneList.Clear();
			InteractInfoCollectionData.DispInteractBoneList.AddRange(DispInteractBoneList_New);
		}
	}

	private void ResetDispInteractConfig()
	{
		InteractInfoCollectionData.DispInteractBoneList.Clear();
		InteractInfoCollectionData.DispInteractBoneList.AddRange(InteractInfoCollectionData.DispInteractBoneList_Default);
	}
}
