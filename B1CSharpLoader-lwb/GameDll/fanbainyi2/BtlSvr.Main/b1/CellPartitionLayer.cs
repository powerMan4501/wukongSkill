using System;
using System.Collections.Generic;

namespace b1;

public class CellPartitionLayer
{
	private List<CellPartitionActorInfo> ActorInfosInLayer = new List<CellPartitionActorInfo>();

	public CellPartitionLayerTag LayerTag;

	public float LayerRadius;

	public int UnitFilter;

	public int TeamFilter;

	public int Priority;

	public bool FilterAnd;

	public string LayerName;

	public event Action<CellPartitionActorInfo> OnActorLeave;

	public event Action<CellPartitionActorInfo> OnActorEnter;

	public void AddActor(CellPartitionActorInfo ActorInfo)
	{
		ActorInfo.LayerTag |= (uint)LayerTag;
		if (!ActorInfosInLayer.Contains(ActorInfo))
		{
			BGW_LogUtil.LogError(LayerName + " AddActor:" + ActorInfo.RelatedActor.GetName());
			ActorInfosInLayer.Add(ActorInfo);
			this.OnActorEnter?.Invoke(ActorInfo);
		}
	}

	public void RemoveActor(CellPartitionActorInfo ActorInfo, bool ChangeTag = true)
	{
		BGW_LogUtil.LogError(LayerName + " RemoveActor:" + ActorInfo.RelatedActor.GetName());
		ActorInfosInLayer.Remove(ActorInfo);
		this.OnActorLeave?.Invoke(ActorInfo);
		if (ChangeTag)
		{
			ActorInfo.LayerTag &= (uint)(~LayerTag);
		}
	}

	public void RemoveAllTagedActor()
	{
		for (int num = ActorInfosInLayer.Count - 1; num >= 0; num--)
		{
			if ((ActorInfosInLayer[num].LayerTag & (uint)LayerTag) != 0)
			{
				RemoveActor(ActorInfosInLayer[num], ChangeTag: false);
			}
		}
	}

	public void RemoveAllUnTagedActor()
	{
		for (int num = ActorInfosInLayer.Count - 1; num >= 0; num--)
		{
			if ((ActorInfosInLayer[num].LayerTag & (uint)LayerTag) == 0)
			{
				RemoveActor(ActorInfosInLayer[num]);
			}
		}
	}
}
