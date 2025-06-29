using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class EntitySharedRefFuncLib
{
	public static bool IsNull(this EntitySharedRef Ref)
	{
		if ((object)Ref != null)
		{
			return Ref.Ref == null;
		}
		return true;
	}

	public static AActor Actor(this EntitySharedRef Ref)
	{
		if (IsNull(Ref))
		{
			return null;
		}
		AActor aActor = Ref.Ref?.WorldObj as AActor;
		if (aActor.IsNullOrDestroyed())
		{
			aActor = null;
		}
		return aActor;
	}

	public static Entity Entity(this EntitySharedRef Ref)
	{
		if (IsNull(Ref))
		{
			return b1.ECS.Entity.Null;
		}
		return Ref.Ref.Entity;
	}
}
