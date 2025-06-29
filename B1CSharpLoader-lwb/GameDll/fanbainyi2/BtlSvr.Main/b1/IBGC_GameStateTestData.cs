using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBGC_GameStateTestData
{
	int TestID { get; }

	bool StopOptimizeTickRate { get; }
}
