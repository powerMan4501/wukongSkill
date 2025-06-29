using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_MeditationPointData
{
	int MeditationPointConfigID { get; }

	FTransform MeditationPointMeditationTrans { get; }

	bool bActiveState { get; }
}
