using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class EntitySharedRef
{
	public IEntityRef Ref { get; private set; }

	protected void InitWithWorldObj(AActor actor)
	{
		if (!actor.IsNullOrDestroyed() && actor is IECSWorldObj)
		{
			BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get((actor as IECSWorldObj).ECSEntity);
			if (bGW_ECSWorld != null)
			{
				Ref = bGW_ECSWorld.GetOrAllocEntityRef(actor as IECSWorldObj);
				Ref.Retain();
			}
		}
	}

	public EntitySharedRef()
	{
		Ref = null;
	}

	public void Set(AActor actor)
	{
		Ref = null;
		InitWithWorldObj(actor);
	}

	public void Set(Entity Entity)
	{
		if (!(Entity == Entity.Null))
		{
			AActor aActor = ECSUtil.ToActor(Entity);
			if (!aActor.IsNullOrDestroyed())
			{
				InitWithWorldObj(aActor);
			}
		}
	}

	public EntitySharedRef(AActor actor)
	{
		Set(actor);
	}

	public EntitySharedRef(Entity Entity)
	{
		Set(Entity);
	}

	internal void Clear()
	{
		Ref?.Release();
		Ref = null;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return Ref == null;
		}
		if (obj is EntitySharedRef)
		{
			return Ref == (obj as EntitySharedRef).Ref;
		}
		if (obj is AActor)
		{
			return EntitySharedRefFuncLib.Actor(this) == obj as AActor;
		}
		if (obj is Entity)
		{
			return EntitySharedRefFuncLib.Entity(this) == (Entity)obj;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Ref?.GetHashCode() ?? 0;
	}

	~EntitySharedRef()
	{
		Clear();
	}

	public static bool operator ==(EntitySharedRef t1, EntitySharedRef t2)
	{
		if (EntitySharedRefFuncLib.IsNull(t1))
		{
			return EntitySharedRefFuncLib.IsNull(t2);
		}
		return t1.Equals(t2);
	}

	public static bool operator !=(EntitySharedRef t1, EntitySharedRef t2)
	{
		if (EntitySharedRefFuncLib.IsNull(t1))
		{
			return !EntitySharedRefFuncLib.IsNull(t2);
		}
		return !t1.Equals(t2);
	}

	public static bool operator ==(EntitySharedRef t1, Entity t2)
	{
		return EntitySharedRefFuncLib.Entity(t1) == t2;
	}

	public static bool operator !=(EntitySharedRef t1, Entity t2)
	{
		return EntitySharedRefFuncLib.Entity(t1) != t2;
	}
}
