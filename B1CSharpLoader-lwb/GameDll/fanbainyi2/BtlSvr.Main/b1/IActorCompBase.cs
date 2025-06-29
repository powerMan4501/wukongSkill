namespace b1;

public interface IActorCompBase
{
	bool IsNetActive();

	bool CanTick();

	bool CanTickForDebug();

	bool AllowTRO();

	void RecalculateCanTick();
}
