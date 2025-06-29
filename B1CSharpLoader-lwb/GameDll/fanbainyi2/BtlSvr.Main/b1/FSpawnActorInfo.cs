using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class FSpawnActorInfo
{
	public string ActorGuid;

	public int PointsIndex;

	public int ActorsIndex;

	public FSpawnActorInfo(string InActorGuid, int InPointsIndex, int InActorsIndex)
	{
		ActorGuid = InActorGuid;
		PointsIndex = InPointsIndex;
		ActorsIndex = InActorsIndex;
	}
}
