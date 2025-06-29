using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_LevelActorData : IBGC_LevelActorData, IPersistentECSData
{
	public Dictionary<AStaticMeshActor, TStrongObjectPtr<BGWDataAsset_StaticMeshActorSetting>> SpawnedActors { get; } = new Dictionary<AStaticMeshActor, TStrongObjectPtr<BGWDataAsset_StaticMeshActorSetting>>();

	public MultiMap<FName, AActor> TagSceneItemMultiMap { get; } = new MultiMap<FName, AActor>();

	public MultiMap<AActor, FName> RegisteredSceneItemTags { get; } = new MultiMap<AActor, FName>();

	public MultiMap<int, BUAllowUseSpecialItemArea> AllowUseSpecialItemAreaMultiMap { get; } = new MultiMap<int, BUAllowUseSpecialItemArea>();

	public void GetSceneItemsByTag(FName Tag, out List<AActor> OutSceneItems)
	{
		OutSceneItems = new List<AActor>();
		if (TagSceneItemMultiMap.TryGetValue(Tag, out var value))
		{
			OutSceneItems.AddRange(value);
		}
	}

	public void GetAllowUseSpecialItemArea(int ItemID, out List<BUAllowUseSpecialItemArea> OutAreas)
	{
		OutAreas = new List<BUAllowUseSpecialItemArea>();
		if (AllowUseSpecialItemAreaMultiMap.TryGetValue(ItemID, out var value))
		{
			OutAreas.AddRange(value);
		}
	}

	public bool CheckIsInSpecialItemArea(int ItemID, AActor Caster)
	{
		if (Caster == null)
		{
			return false;
		}
		if (AllowUseSpecialItemAreaMultiMap.TryGetValue(ItemID, out var value))
		{
			if (value.Count == 0)
			{
				return false;
			}
			foreach (BUAllowUseSpecialItemArea item in value)
			{
				if (item.GetComponentByClass<UBoxComponent>().IsOverlappingActor(Caster))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void GetSceneItemsByTags(List<FName> Tags, out List<AActor> OutSceneItems)
	{
		HashSet<AActor> hashSet = new HashSet<AActor>();
		foreach (FName Tag in Tags)
		{
			if (!TagSceneItemMultiMap.TryGetValue(Tag, out var value))
			{
				continue;
			}
			foreach (AActor item in value)
			{
				hashSet.Add(item);
			}
		}
		OutSceneItems = hashSet.ToList();
	}
}
