using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class EntitySharedRefDic<T>
{
	private Dictionary<EntitySharedRef, T> mEntitySharedRefDic = new Dictionary<EntitySharedRef, T>();

	public int Count => mEntitySharedRefDic.Count;

	public Dictionary<EntitySharedRef, T>.KeyCollection Keys => mEntitySharedRefDic.Keys;

	public Dictionary<EntitySharedRef, T>.ValueCollection Values => mEntitySharedRefDic.Values;

	public T this[EntitySharedRef Entity]
	{
		get
		{
			return mEntitySharedRefDic[Entity];
		}
		set
		{
			mEntitySharedRefDic[Entity] = value;
		}
	}

	public T this[AActor Actor]
	{
		set
		{
			mEntitySharedRefDic[new EntitySharedRef(Actor)] = value;
		}
	}

	public T this[Entity Entity]
	{
		set
		{
			mEntitySharedRefDic[new EntitySharedRef(Entity)] = value;
		}
	}

	public bool ContainsKey(EntitySharedRef EntityRef)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			return mEntitySharedRefDic.ContainsKey(EntityRef);
		}
		return false;
	}

	public bool ContainsKey(AActor Actor)
	{
		EntitySharedRef OutEntityRef;
		if (!Actor.IsNullOrDestroyed())
		{
			return TryGetEntityRef(Actor, out OutEntityRef);
		}
		BGW_LogUtil.LogError($"Actor {Actor} in EntitySharedRefDic.ContainsKey is null or destroyed!");
		return false;
	}

	public bool ContainsKey(Entity Entity)
	{
		if (!Entity.IsNull() && !ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			return ContainsKey(ECSExtension.ToActor(Entity));
		}
		BGW_LogUtil.LogError($"Entity {Entity} in EntitySharedRefDic.ContainsKey is null or destroyed!");
		return false;
	}

	public void Add(EntitySharedRef EntityRef, T TValue)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			mEntitySharedRefDic.Add(EntityRef, TValue);
		}
		else
		{
			BGW_LogUtil.LogError($"EntityRef {EntityRef} in EntitySharedRefDic.Add is null!");
		}
	}

	public void Add(AActor Actor, T TValue)
	{
		if (!Actor.IsNullOrDestroyed())
		{
			EntitySharedRef entityRef = new EntitySharedRef(Actor);
			Add(entityRef, TValue);
		}
		else
		{
			BGW_LogUtil.LogError($"Actor {Actor} in EntitySharedRefDic.Add is null or destroyed!");
		}
	}

	public void Add(Entity Entity, T TValue)
	{
		if (!Entity.IsNull() && !ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			EntitySharedRef entityRef = new EntitySharedRef(Entity);
			Add(entityRef, TValue);
		}
		else
		{
			BGW_LogUtil.LogError($"Entity {Entity} in EntitySharedRefDic.Add is null or destroyed!");
		}
	}

	public void Remove(EntitySharedRef EntityRef)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			mEntitySharedRefDic.Remove(EntityRef);
		}
		else
		{
			BGW_LogUtil.LogError($"Entity {EntityRef} in EntitySharedRefDic.Remove is null or destroyed!");
		}
	}

	public void Remove(AActor Actor)
	{
		if (!Actor.IsNullOrDestroyed())
		{
			if (TryGetEntityRef(Actor, out var OutEntityRef))
			{
				Remove(OutEntityRef);
			}
		}
		else
		{
			BGW_LogUtil.LogError($"Actor {Actor} in EntitySharedRefDic.Remove is null or destroyed!");
		}
	}

	public void Remove(Entity Entity)
	{
		if (!Entity.IsNull() && ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			Remove(ECSExtension.ToActor(Entity));
		}
		else
		{
			BGW_LogUtil.LogError($"Entity {Entity} in EntitySharedRefDic.Remove is null or destroyed");
		}
	}

	public bool TryGetValue(EntitySharedRef EntityRef, out T TValue)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			if (mEntitySharedRefDic.ContainsKey(EntityRef))
			{
				TValue = mEntitySharedRefDic[EntityRef];
				return true;
			}
			BGW_LogUtil.LogError($"EntityRef {EntityRef} in EntitySharedRefDic.TryGetValue can not find value!");
		}
		else
		{
			BGW_LogUtil.LogError($"EntityRef {EntityRef} in EntitySharedRefDic.TryGetValue is null!");
		}
		TValue = default(T);
		return false;
	}

	public bool TryGetValue(AActor Actor, out T TValue)
	{
		if (!Actor.IsNullOrDestroyed())
		{
			if (TryGetEntityRef(Actor, out var OutEntityRef) && TryGetValue(OutEntityRef, out TValue))
			{
				return true;
			}
		}
		else
		{
			BGW_LogUtil.LogError($"Actor {Actor} in EntitySharedRefDic.TryGetValue is null or destroyed!");
		}
		TValue = default(T);
		return false;
	}

	public bool TryGetValue(Entity Entity, out T TValue)
	{
		if (!Entity.IsNull() && ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			if (TryGetValue(ECSExtension.ToActor(Entity), out TValue))
			{
				return true;
			}
		}
		else
		{
			BGW_LogUtil.LogError($"Entity {Entity} in EntitySharedRefDic.TryGetValue is null or destroyed!");
		}
		TValue = default(T);
		return false;
	}

	public Dictionary<EntitySharedRef, T>.Enumerator GetEnumerator()
	{
		return mEntitySharedRefDic.GetEnumerator();
	}

	public void Clear()
	{
		mEntitySharedRefDic.Clear();
	}

	private bool TryGetEntityRef(AActor Actor, out EntitySharedRef OutEntityRef)
	{
		foreach (EntitySharedRef key in mEntitySharedRefDic.Keys)
		{
			if (EntitySharedRefFuncLib.Actor(key) == Actor)
			{
				OutEntityRef = key;
				return true;
			}
		}
		BGW_LogUtil.LogError($"Actor {Actor} in EntitySharedRefDic.TryGetEntityRef can not find OutEntityRef!");
		OutEntityRef = null;
		return false;
	}
}
