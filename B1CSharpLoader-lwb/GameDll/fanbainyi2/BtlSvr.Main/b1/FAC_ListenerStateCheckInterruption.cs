using UnrealEngine.Engine;

namespace b1;

public struct FAC_ListenerStateCheckInterruption
{
	public bool bActive;

	public float OverDistance;

	public string ListenerGuid;

	public AActor Listener;

	public void Disable()
	{
		bActive = false;
		OverDistance = 0f;
		ListenerGuid = "";
		Listener = null;
	}
}
