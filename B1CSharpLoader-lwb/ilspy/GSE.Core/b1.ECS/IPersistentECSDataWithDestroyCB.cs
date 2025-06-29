namespace b1.ECS;

public interface IPersistentECSDataWithDestroyCB : IPersistentECSData
{
	void OnUnPersistentDestroy();
}
