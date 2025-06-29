using UnrealEngine.Engine;

namespace b1.BGU.BUAnim;

internal interface IBUEnityAnim
{
	void OnEntityInitFinish();

	void OnEntityEndPlay(EEndPlayReason EndPlayReason);
}
