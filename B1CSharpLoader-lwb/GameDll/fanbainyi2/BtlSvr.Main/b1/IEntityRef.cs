using b1.ECS;

namespace b1;

public interface IEntityRef
{
	Entity Entity { get; }

	IECSWorldObj WorldObj { get; }

	void Retain();

	void Release();
}
