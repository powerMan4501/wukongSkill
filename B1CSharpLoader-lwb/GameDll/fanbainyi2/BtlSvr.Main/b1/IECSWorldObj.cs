using b1.ECS;

namespace b1;

public interface IECSWorldObj
{
	Entity ECSEntity { get; set; }

	Chunk ECSChunk { get; set; }

	int ECSIndexInChunk { get; set; }

	int ECSArcheType { get; }

	UActorCompContainerCS ActorCompContainerCS { get; }

	UActorDataContainer DataComp { get; }

	object GetEventCollection();

	void InitAllComp();

	void AfterInitAllComp();

	bool IsBeginPlayFinished();

	object GetDataByChunk(int TypeIndex);
}
