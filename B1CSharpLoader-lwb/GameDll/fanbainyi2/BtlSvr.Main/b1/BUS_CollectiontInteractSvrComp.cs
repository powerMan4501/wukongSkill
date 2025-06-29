using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_CollectiontInteractSvrComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_DropCollectionItem += new Del_DropCollectionItem(OnDropCollectionItem);
		}
	}

	public void OnDropCollectionItem(AActor Player, int CollectionDropId, int DropLevel)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(Player);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_PlayerCollected.Invoke(Player, CollectionDropId, DropLevel, Owner);
		}
	}
}
