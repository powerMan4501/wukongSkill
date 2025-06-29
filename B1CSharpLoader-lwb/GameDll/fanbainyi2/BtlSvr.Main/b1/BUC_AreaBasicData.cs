using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AreaBasicData : b1.IBUC_AreaBasicData
{
	public EAreaType AreaType { get; set; }

	public FAreaUnitFilter UnitFilter { get; set; }

	public bool IngnorePlayerTrans { get; set; }

	public bool bAutoEnableOverlap { get; set; }

	public bool bNotifyGraph { get; set; }

	private Dictionary<Entity, bool> CanTriggerFirstEnter { get; set; }

	public HashSet<Entity> InnerEntityList { get; set; }

	public Dictionary<Entity, int> InnerEntityCounter_EnterArea { get; set; }

	public Dictionary<Entity, int> InnerEntityCounter_Actor { get; set; }

	public Dictionary<Entity, Entity> EntityChangedMap { get; set; }

	public Dictionary<Entity, int> OldEntityCounter { get; set; }

	public BUC_AreaBasicData()
	{
		CanTriggerFirstEnter = new Dictionary<Entity, bool>();
		InnerEntityCounter_EnterArea = new Dictionary<Entity, int>();
		InnerEntityCounter_Actor = new Dictionary<Entity, int>();
		EntityChangedMap = new Dictionary<Entity, Entity>();
		OldEntityCounter = new Dictionary<Entity, int>();
		InnerEntityList = new HashSet<Entity>();
	}

	public bool EntityEnter_EnterArea(Entity _Entity_Enter)
	{
		Entity finalEntity = GetFinalEntity(_Entity_Enter, bIsEnter: true);
		if (InnerEntityCounter_EnterArea.ContainsKey(finalEntity))
		{
			InnerEntityCounter_EnterArea[finalEntity]++;
			return false;
		}
		InnerEntityCounter_EnterArea.Add(finalEntity, 1);
		if (CanTriggerFirstEnter.TryGetValue(finalEntity, out var value) && value)
		{
			return false;
		}
		if (CanTriggerFirstEnter.ContainsKey(finalEntity))
		{
			CanTriggerFirstEnter[finalEntity] = true;
		}
		else
		{
			CanTriggerFirstEnter.Add(finalEntity, value: true);
		}
		InnerEntityList.Add(_Entity_Enter);
		return true;
	}

	public void EntityExit_EnterArea(Entity _Entity_Exit)
	{
		Entity finalEntity = GetFinalEntity(_Entity_Exit, bIsEnter: false);
		if (!InnerEntityCounter_EnterArea.ContainsKey(finalEntity))
		{
			return;
		}
		InnerEntityCounter_EnterArea[finalEntity]--;
		if (InnerEntityCounter_EnterArea[finalEntity] <= 0)
		{
			InnerEntityCounter_EnterArea.Remove(finalEntity);
			if (AreaType == EAreaType.SimpleTrigger)
			{
				CanTriggerFirstEnter.Remove(finalEntity);
			}
		}
	}

	public void EntityEnter_Actor(Entity _Entity_Enter)
	{
		Entity finalEntity = GetFinalEntity(_Entity_Enter, bIsEnter: true);
		if (InnerEntityCounter_Actor.ContainsKey(finalEntity))
		{
			InnerEntityCounter_Actor[finalEntity]++;
			return;
		}
		InnerEntityCounter_Actor.Add(finalEntity, 1);
		if (CanTriggerFirstEnter.ContainsKey(finalEntity))
		{
			CanTriggerFirstEnter[finalEntity] = false;
		}
		else
		{
			CanTriggerFirstEnter.Add(finalEntity, value: false);
		}
	}

	public bool EntityExit_Actor(Entity _Entity_Exit)
	{
		Entity finalEntity = GetFinalEntity(_Entity_Exit, bIsEnter: false);
		if (InnerEntityCounter_Actor.ContainsKey(finalEntity))
		{
			InnerEntityCounter_Actor[finalEntity]--;
			if (InnerEntityCounter_Actor[finalEntity] <= 0)
			{
				InnerEntityCounter_Actor.Remove(finalEntity);
				CanTriggerFirstEnter.Remove(finalEntity);
				InnerEntityList.Remove(finalEntity);
				return true;
			}
		}
		return false;
	}

	public void OnPossessEntityChanged(Entity OldEntity, Entity NewEntity)
	{
		if (!EntityChangedMap.ContainsKey(OldEntity))
		{
			EntityChangedMap.Add(OldEntity, NewEntity);
			OldEntityCounter.Add(OldEntity, 0);
		}
		if (InnerEntityCounter_EnterArea.ContainsKey(OldEntity) && !InnerEntityCounter_EnterArea.ContainsKey(NewEntity))
		{
			InnerEntityCounter_EnterArea.Add(NewEntity, InnerEntityCounter_EnterArea[OldEntity]);
			OldEntityCounter[OldEntity] += InnerEntityCounter_EnterArea[OldEntity];
			InnerEntityCounter_EnterArea.Remove(OldEntity);
		}
		if (InnerEntityCounter_Actor.ContainsKey(OldEntity) && !InnerEntityCounter_Actor.ContainsKey(NewEntity))
		{
			InnerEntityCounter_Actor.Add(NewEntity, InnerEntityCounter_Actor[OldEntity]);
			OldEntityCounter[OldEntity] += InnerEntityCounter_Actor[OldEntity];
			InnerEntityCounter_Actor.Remove(OldEntity);
		}
		if (InnerEntityList.Remove(OldEntity))
		{
			InnerEntityList.Add(NewEntity);
		}
	}

	private Entity GetFinalEntity(Entity _Entity, bool bIsEnter)
	{
		Entity result = _Entity;
		if (EntityChangedMap.ContainsKey(_Entity))
		{
			result = EntityChangedMap[_Entity];
			if (bIsEnter)
			{
				OldEntityCounter[_Entity]++;
			}
			else
			{
				OldEntityCounter[_Entity]--;
				if (OldEntityCounter[_Entity] <= 0)
				{
					EntityChangedMap.Remove(_Entity);
					OldEntityCounter.Remove(_Entity);
				}
			}
		}
		return result;
	}

	public bool bIsEntityInner(Entity _Entity)
	{
		return InnerEntityList.Contains(_Entity);
	}

	public bool IsLocalPlayer(ACharacter Character)
	{
		ACharacter aCharacter = Character;
		Entity key = ECSExtension.ToEntity(Character);
		if (EntityChangedMap.ContainsKey(key))
		{
			aCharacter = ECSUtil.ToActor(EntityChangedMap[key]) as ACharacter;
		}
		if (aCharacter.IsNullOrDestroyed())
		{
			return false;
		}
		if (aCharacter != null && aCharacter.GetController() != null && aCharacter.GetController().IsLocalPlayerController())
		{
			return true;
		}
		return false;
	}
}
