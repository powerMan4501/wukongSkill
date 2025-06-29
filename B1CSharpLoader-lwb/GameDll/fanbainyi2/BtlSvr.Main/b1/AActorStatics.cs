using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class AActorStatics
{
	public static int GetEntityHash(this AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			return 0;
		}
		return ECSUtil.ToEntity(Actor).GetHashCode();
	}
}
