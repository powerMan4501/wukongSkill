using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeamPlayerInfo
{
	public readonly int PlayerIdx;

	public readonly GSBindProp<ABGPPlayerState> PlayerState = new GSBindProp<ABGPPlayerState>();

	public readonly GSBindProp<AActor> PlayerActor = new GSBindProp<AActor>();

	public TeamPlayerInfo(int InPlayerIdx)
	{
		PlayerIdx = InPlayerIdx;
	}

	public bool IsValid()
	{
		return !PlayerState.Value.IsNullOrDestroyed();
	}

	public void SetPlayerState(ABGPPlayerState InPlayerState)
	{
		PlayerState.SetValue(EChangeReason.ManualSet, InPlayerState);
	}

	public void SetPlayerActor(AActor InActor)
	{
		PlayerActor.SetValue(EChangeReason.ManualSet, InActor);
	}
}
