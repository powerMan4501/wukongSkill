using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class EntitySharedRefList
{
	private List<EntitySharedRef> mEntitySharedRefList = new List<EntitySharedRef>();

	public int Count => mEntitySharedRefList.Count;

	public EntitySharedRef this[int Index] => mEntitySharedRefList[Index];

	public List<EntitySharedRef>.Enumerator GetEnumerator()
	{
		return mEntitySharedRefList.GetEnumerator();
	}

	public void RemoveAt(int Index)
	{
		mEntitySharedRefList.RemoveAt(Index);
	}

	public void Remove(EntitySharedRef EntityRef)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			mEntitySharedRefList.Remove(EntityRef);
		}
	}

	public void Remove(AActor Actor)
	{
		if (!Actor.IsNullOrDestroyed() && TryGetEntityRef(Actor, out var OutEntityRef))
		{
			Remove(OutEntityRef);
		}
	}

	public void Remove(Entity Entity)
	{
		if (!Entity.IsNull() && !ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			Remove(ECSExtension.ToActor(Entity));
		}
	}

	public void Add(EntitySharedRef EntityRef)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			mEntitySharedRefList.Add(EntityRef);
		}
	}

	public void Add(AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			mEntitySharedRefList.Add(new EntitySharedRef(Actor));
		}
	}

	public void Add(Entity Entity)
	{
		if (!Entity.IsNull() && !ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			mEntitySharedRefList.Add(new EntitySharedRef(Entity));
		}
	}

	public bool Contains(EntitySharedRef EntityRef)
	{
		if (!EntitySharedRefFuncLib.IsNull(EntityRef))
		{
			return mEntitySharedRefList.Contains(EntityRef);
		}
		return false;
	}

	public bool Contains(AActor Actor)
	{
		EntitySharedRef OutEntityRef;
		if (!Actor.IsNullOrDestroyed())
		{
			return TryGetEntityRef(Actor, out OutEntityRef);
		}
		return false;
	}

	public bool Contains(Entity Entity)
	{
		if (!Entity.IsNull() && !ECSExtension.ToActor(Entity).IsNullOrDestroyed())
		{
			return Contains(ECSExtension.ToActor(Entity));
		}
		return false;
	}

	public void Clear()
	{
		mEntitySharedRefList.Clear();
	}

	private bool TryGetEntityRef(AActor Actor, out EntitySharedRef OutEntityRef)
	{
		foreach (EntitySharedRef mEntitySharedRef in mEntitySharedRefList)
		{
			if (EntitySharedRefFuncLib.Actor(mEntitySharedRef) == Actor)
			{
				OutEntityRef = mEntitySharedRef;
				return true;
			}
		}
		OutEntityRef = null;
		return false;
	}
}
