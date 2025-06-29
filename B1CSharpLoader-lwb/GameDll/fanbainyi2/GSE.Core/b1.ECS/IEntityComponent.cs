namespace b1.ECS;

public interface IEntityComponent
{
	float GetAccumulatedDeltaTime();

	int GetTickGroupMask();

	void OnTickWithGroup(float DeltaTime, int TickGroup);

	int GetOwnerNetRole();

	int GetNetRoleFilter();

	int GetRejectNetRoleFilter();

	void OnNetActive();

	void OnNetDeActive();

	bool IsNetActive();

	Entity GetOwnerEntity();

	void AddRelativeEventCollection(object EventCollection);

	void RemoveRelativeEventCollection(object EventCollection);

	float GetCustomTimeDilation();
}
