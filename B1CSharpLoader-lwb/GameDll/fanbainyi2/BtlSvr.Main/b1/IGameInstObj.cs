namespace b1;

public interface IGameInstObj
{
	bool bTickEnabled { get; }

	int StatId { get; }

	void OnAttach();

	void OnInit();

	void OnAfterInit();

	bool CanTick();

	int GetTickGroupMask();

	void OnTickWithGroup(float DeltaTime, int TickGroup);

	void OnShutdown();

	void OnPostLoadMap();
}
